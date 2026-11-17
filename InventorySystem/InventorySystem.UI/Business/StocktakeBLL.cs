using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل الجرد
    /// </summary>
    public class StocktakeBLL
    {
        private readonly StocktakeDAL _dal;
        private readonly StocktakeDetailDAL _detailDal;
        private readonly WarehouseDAL _warehouseDal;
        private readonly UserDAL _userDal;
        private readonly InventoryDAL _inventoryDal;

        public StocktakeBLL()
        {
            _dal = new StocktakeDAL();
            _detailDal = new StocktakeDetailDAL();
            _warehouseDal = new WarehouseDAL();
            _userDal = new UserDAL();
            _inventoryDal = new InventoryDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل عمليات الجرد
        /// </summary>
        public List<Stocktake> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الجرد: {ex.Message}";
                return new List<Stocktake>();
            }
        }

        /// <summary>
        /// جرد مستودع معين
        /// </summary>
        public List<Stocktake> GetByWarehouse(int warehouseId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetByWarehouse(warehouseId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الجرد: {ex.Message}";
                return new List<Stocktake>();
            }
        }

        /// <summary>
        /// الحصول على جرد مع تفاصيله
        /// </summary>
        public Stocktake GetById(int stocktakeId, out string error)
        {
            error = null;
            try
            {
                var stocktake = _dal.GetById(stocktakeId);
                if (stocktake != null)
                {
                    stocktake.Details = _detailDal.GetByStocktake(stocktakeId);
                }
                return stocktake;
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الجرد: {ex.Message}";
                return null;
            }
        }

        // ============================================
        // إنشاء جرد جديد
        // ============================================

        /// <summary>
        /// إنشاء جرد جديد
        /// </summary>
        public int Create(int warehouseId, int userId, string notes, out string error)
        {
            error = null;

            // التحقق من المستودع
            if (_warehouseDal.GetById(warehouseId) == null)
            {
                error = "المستودع غير موجود";
                return 0;
            }

            // التحقق من المستخدم
            if (_userDal.GetById(userId) == null)
            {
                error = "المستخدم غير موجود";
                return 0;
            }

            try
            {
                var stocktake = new Stocktake
                {
                    WarehouseId = warehouseId,
                    StocktakeDate = DateTime.Now,
                    Status = "Open",
                    CreatedBy = userId,
                    Notes = notes
                };

                int stocktakeId = _dal.Add(stocktake);

                // تحميل المنتجات من المخزون وإضافتها للجرد
                var inventoryItems = _inventoryDal.GetByWarehouse(warehouseId);

                foreach (var item in inventoryItems)
                {
                    var detail = new StocktakeDetail
                    {
                        StocktakeId = stocktakeId,
                        ProductId = item.ProductId,
                        SystemQty = item.Quantity,
                        CountedQty = item.Quantity  // افتراضياً = الكمية في النظام
                    };

                    _detailDal.Add(detail);
                }

                return stocktakeId;
            }
            catch (Exception ex)
            {
                error = $"فشل في إنشاء الجرد: {ex.Message}";
                return 0;
            }
        }

        // ============================================
        // تحديث كمية في الجرد
        // ============================================

        /// <summary>
        /// تحديث الكمية الفعلية لبند في الجرد
        /// </summary>
        public bool UpdateCountedQuantity(int detailId, decimal countedQty, out string error)
        {
            error = null;

            if (countedQty < 0)
            {
                error = "الكمية لا يمكن أن تكون سالبة";
                return false;
            }

            try
            {
                // نحتاج لتحديث مباشر
                string query = @"
                    UPDATE StocktakeDetails
                    SET CountedQty = @CountedQty
                    WHERE Id = @DetailId";

                int rows = DatabaseHelper.ExecuteNonQuery(query,
                    DatabaseHelper.Param("@DetailId", detailId),
                    DatabaseHelper.Param("@CountedQty", countedQty));

                return rows > 0;
            }
            catch (Exception ex)
            {
                error = $"فشل في تحديث الكمية: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // إغلاق الجرد (تسوية الفروقات)
        // ============================================

        /// <summary>
        /// إغلاق الجرد وتسوية الفروقات
        /// </summary>
        public bool Close(int stocktakeId, int userId, out string error)
        {
            error = null;

            try
            {
                var stocktake = _dal.GetById(stocktakeId);
                if (stocktake == null)
                {
                    error = "الجرد غير موجود";
                    return false;
                }

                if (stocktake.Status == "Closed")
                {
                    error = "الجرد مغلق مسبقاً";
                    return false;
                }

                // تحميل التفاصيل
                var details = _detailDal.GetByStocktake(stocktakeId);

                // تسوية الفروقات
                foreach (var detail in details)
                {
                    if (detail.Difference == 0) continue;

                    // تسجيل حركة تسوية
                    var movement = new StockMovement
                    {
                        Type = "ADJUST",
                        MovementDate = DateTime.Now,
                        UserId = userId,
                        ToWarehouseId = stocktake.WarehouseId,
                        Reference = $"ST-{stocktakeId}",
                        Notes = $"تسوية جرد - الفرق: {detail.Difference}"
                    };

                    var movementDal = new StockMovementDAL();
                    int movementId = movementDal.Add(movement);

                    var movementDetail = new StockMovementDetail
                    {
                        MovementId = movementId,
                        ProductId = detail.ProductId,
                        BatchId = detail.BatchId,
                        Quantity = detail.Difference
                    };

                    var detailDal = new StockMovementDetailDAL();
                    detailDal.Add(movementDetail);

                    // تحديث المخزون
                    if (detail.Difference > 0)
                    {
                        // فائض - إضافة
                        _inventoryDal.AddOrUpdateQuantity(
                            detail.ProductId,
                            stocktake.WarehouseId,
                            detail.Difference);
                    }
                    else
                    {
                        // عجز - خصم
                        _inventoryDal.DeductQuantity(
                            detail.ProductId,
                            stocktake.WarehouseId,
                            Math.Abs(detail.Difference));
                    }
                }

                // إغلاق الجرد
                _dal.UpdateStatus(stocktakeId, "Closed");

                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إغلاق الجرد: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف جرد
        /// </summary>
        public bool Delete(int stocktakeId, out string error)
        {
            error = null;

            try
            {
                var stocktake = _dal.GetById(stocktakeId);
                if (stocktake == null)
                {
                    error = "الجرد غير موجود";
                    return false;
                }

                if (stocktake.Status == "Closed")
                {
                    error = "لا يمكن حذف جرد مغلق";
                    return false;
                }

                // حذف التفاصيل
                _detailDal.DeleteByStocktake(stocktakeId);

                // حذف الجرد
                _dal.Delete(stocktakeId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف الجرد: {ex.Message}";
                return false;
            }
        }
    }
}