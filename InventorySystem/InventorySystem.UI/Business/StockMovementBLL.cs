using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل حركات المخزون
    /// </summary>
    public class StockMovementBLL
    {
        private readonly StockMovementDAL _movementDal;
        private readonly StockMovementDetailDAL _detailDal;
        private readonly InventoryDAL _inventoryDal;
        private readonly InventoryBatchDAL _inventoryBatchDal;
        private readonly BatchDAL _batchDal;

        public StockMovementBLL()
        {
            _movementDal = new StockMovementDAL();
            _detailDal = new StockMovementDetailDAL();
            _inventoryDal = new InventoryDAL();
            _inventoryBatchDal = new InventoryBatchDAL();
            _batchDal = new BatchDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل الحركات
        /// </summary>
        public List<StockMovement> GetAll(out string error)
        {
            error = null;
            try
            {
                return _movementDal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الحركات: {ex.Message}";
                return new List<StockMovement>();
            }
        }

        /// <summary>
        /// الحركات حسب النوع
        /// </summary>
        public List<StockMovement> GetByType(string type, out string error)
        {
            error = null;
            try
            {
                return _movementDal.GetByType(type);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الحركات: {ex.Message}";
                return new List<StockMovement>();
            }
        }

        /// <summary>
        /// الحركات في فترة
        /// </summary>
        public List<StockMovement> GetByDateRange(DateTime fromDate, DateTime toDate, out string error)
        {
            error = null;
            try
            {
                return _movementDal.GetByDateRange(fromDate, toDate);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الحركات: {ex.Message}";
                return new List<StockMovement>();
            }
        }

        /// <summary>
        /// الحصول على حركة مع تفاصيلها
        /// </summary>
        public StockMovement GetById(int movementId, out string error)
        {
            error = null;
            try
            {
                var movement = _movementDal.GetById(movementId);
                if (movement != null)
                {
                    movement.Details = _detailDal.GetByMovement(movementId);
                }
                return movement;
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الحركة: {ex.Message}";
                return null;
            }
        }

        /// <summary>
        /// عدد حركات اليوم
        /// </summary>
        public int GetTodayCount(out string error)
        {
            error = null;
            try
            {
                return _movementDal.GetTodayCount();
            }
            catch (Exception ex)
            {
                error = $"فشل في الحصول على العدد: {ex.Message}";
                return 0;
            }
        }

        // ============================================
        // إضافة حركة (مع تنفيذ التأثير على المخزون)
        // ============================================

        /// <summary>
        /// إضافة حركة جديدة مع تنفيذ التأثير
        /// </summary>
        public bool Add(StockMovement movement, out string error)
        {
            error = null;

            if (!Validate(movement, out error))
                return false;

            // التحقق من التفاصيل
            if (movement.Details == null || movement.Details.Count == 0)
            {
                error = "يجب إضافة منتج واحد على الأقل";
                return false;
            }

            try
            {
                // حفظ الحركة
                int movementId = _movementDal.Add(movement);
                movement.MovementId = movementId;

                // حفظ التفاصيل وتنفيذ التأثير
                foreach (var detail in movement.Details)
                {
                    detail.MovementId = movementId;

                    // التحقق من الكمية
                    if (detail.Quantity <= 0)
                    {
                        error = "الكمية يجب أن تكون أكبر من صفر";
                        return false;
                    }

                    // تنفيذ التأثير حسب نوع الحركة
                    if (!ExecuteMovementEffect(movement, detail, out error))
                        return false;

                    // حفظ التفصيل
                    _detailDal.Add(detail);
                }

                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إضافة الحركة: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // تنفيذ تأثير الحركة على المخزون
        // ============================================

        private bool ExecuteMovementEffect(StockMovement movement, StockMovementDetail detail, out string error)
        {
            error = null;

            try
            {
                switch (movement.Type)
                {
                    case "IN":  // استلام - زيادة المخزون
                        _inventoryDal.AddOrUpdateQuantity(
                            detail.ProductId,
                            movement.ToWarehouseId.Value,
                            detail.Quantity);

                        if (detail.BatchId.HasValue)
                        {
                            _inventoryBatchDal.AddOrUpdateQuantity(
                                detail.BatchId.Value,
                                movement.ToWarehouseId.Value,
                                detail.Quantity);
                        }
                        break;

                    case "OUT":  // صرف - خصم من المخزون
                        var deductResult = _inventoryDal.DeductQuantity(
                            detail.ProductId,
                            movement.FromWarehouseId.Value,
                            detail.Quantity);

                        if (!deductResult)
                        {
                            error = $"الكمية غير كافية في المستودع للمنتج";
                            return false;
                        }

                        if (detail.BatchId.HasValue)
                        {
                            _inventoryBatchDal.DeductQuantity(
                                detail.BatchId.Value,
                                movement.FromWarehouseId.Value,
                                detail.Quantity);
                        }
                        break;

                    case "TRANSFER":  // تحويل - خصم من مصدر وإضافة لهدف
                        // خصم من المصدر
                        var transferDeduct = _inventoryDal.DeductQuantity(
                            detail.ProductId,
                            movement.FromWarehouseId.Value,
                            detail.Quantity);

                        if (!transferDeduct)
                        {
                            error = "الكمية غير كافية في المستودع المصدر";
                            return false;
                        }

                        // إضافة للهدف
                        _inventoryDal.AddOrUpdateQuantity(
                            detail.ProductId,
                            movement.ToWarehouseId.Value,
                            detail.Quantity);

                        if (detail.BatchId.HasValue)
                        {
                            _inventoryBatchDal.DeductQuantity(
                                detail.BatchId.Value,
                                movement.FromWarehouseId.Value,
                                detail.Quantity);

                            _inventoryBatchDal.AddOrUpdateQuantity(
                                detail.BatchId.Value,
                                movement.ToWarehouseId.Value,
                                detail.Quantity);
                        }
                        break;

                    case "ADJUST":  // تسوية - حسب الكمية (موجبة أو سالبة)
                        if (detail.Quantity > 0)
                        {
                            _inventoryDal.AddOrUpdateQuantity(
                                detail.ProductId,
                                movement.ToWarehouseId.Value,
                                detail.Quantity);
                        }
                        else
                        {
                            _inventoryDal.DeductQuantity(
                                detail.ProductId,
                                movement.ToWarehouseId.Value,
                                Math.Abs(detail.Quantity));
                        }
                        break;
                }

                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تنفيذ الحركة: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف حركة
        /// </summary>
        public bool Delete(int movementId, out string error)
        {
            error = null;

            try
            {
                // حذف التفاصيل أولاً
                _detailDal.DeleteByMovement(movementId);

                // حذف الحركة
                _movementDal.Delete(movementId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف الحركة: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التحقق
        // ============================================

        private bool Validate(StockMovement movement, out string error)
        {
            error = null;

            if (movement == null)
            {
                error = "البيانات فارغة";
                return false;
            }

            if (string.IsNullOrWhiteSpace(movement.Type))
            {
                error = "نوع الحركة مطلوب";
                return false;
            }

            if (movement.Type != "IN" && movement.Type != "OUT" &&
                movement.Type != "TRANSFER" && movement.Type != "ADJUST")
            {
                error = "نوع الحركة غير صحيح";
                return false;
            }

            if (movement.UserId <= 0)
            {
                error = "المستخدم مطلوب";
                return false;
            }

            // التحقق حسب النوع
            switch (movement.Type)
            {
                case "IN":
                    if (!movement.ToWarehouseId.HasValue)
                    {
                        error = "يجب تحديد المستودع الهدف";
                        return false;
                    }
                    break;

                case "OUT":
                    if (!movement.FromWarehouseId.HasValue)
                    {
                        error = "يجب تحديد المستودع المصدر";
                        return false;
                    }
                    break;

                case "TRANSFER":
                    if (!movement.FromWarehouseId.HasValue || !movement.ToWarehouseId.HasValue)
                    {
                        error = "يجب تحديد المستودع المصدر والهدف";
                        return false;
                    }
                    if (movement.FromWarehouseId == movement.ToWarehouseId)
                    {
                        error = "لا يمكن التحويل لنفس المستودع";
                        return false;
                    }
                    break;

                case "ADJUST":
                    if (!movement.ToWarehouseId.HasValue)
                    {
                        error = "يجب تحديد المستودع";
                        return false;
                    }
                    break;
            }

            return true;
        }
    }
}