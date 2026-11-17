using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل المخزون
    /// </summary>
    public class InventoryBLL
    {
        private readonly InventoryDAL _dal;

        public InventoryBLL()
        {
            _dal = new InventoryDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل رصيد المخزون
        /// </summary>
        public List<Inventory> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المخزون: {ex.Message}";
                return new List<Inventory>();
            }
        }

        /// <summary>
        /// مخزون مستودع معين
        /// </summary>
        public List<Inventory> GetByWarehouse(int warehouseId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetByWarehouse(warehouseId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المخزون: {ex.Message}";
                return new List<Inventory>();
            }
        }

        /// <summary>
        /// مخزون منتج معين
        /// </summary>
        public List<Inventory> GetByProduct(int productId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetByProduct(productId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المخزون: {ex.Message}";
                return new List<Inventory>();
            }
        }

        /// <summary>
        /// كمية منتج في مستودع
        /// </summary>
        public decimal GetQuantity(int productId, int warehouseId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetQuantity(productId, warehouseId);
            }
            catch (Exception ex)
            {
                error = $"فشل في الحصول على الكمية: {ex.Message}";
                return 0;
            }
        }

        /// <summary>
        /// إحصائيات
        /// </summary>
        public int GetCount(out string error)
        {
            error = null;
            try
            {
                return _dal.GetCount();
            }
            catch (Exception ex)
            {
                error = $"فشل في الحصول على العدد: {ex.Message}";
                return 0;
            }
        }

        // ============================================
        // التحديث
        // ============================================

        /// <summary>
        /// إضافة كمية للمخزون
        /// </summary>
        public bool AddQuantity(int productId, int warehouseId, decimal quantity, out string error)
        {
            error = null;

            if (quantity <= 0)
            {
                error = "الكمية يجب أن تكون أكبر من صفر";
                return false;
            }

            try
            {
                _dal.AddOrUpdateQuantity(productId, warehouseId, quantity);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تحديث المخزون: {ex.Message}";
                return false;
            }
        }

        /// <summary>
        /// خصم من المخزون
        /// </summary>
        public bool DeductQuantity(int productId, int warehouseId, decimal quantity, out string error)
        {
            error = null;

            if (quantity <= 0)
            {
                error = "الكمية يجب أن تكون أكبر من صفر";
                return false;
            }

            // التحقق من التوفر
            var current = _dal.GetQuantity(productId, warehouseId);
            if (current < quantity)
            {
                error = $"الكمية غير كافية. المتاح: {current}";
                return false;
            }

            try
            {
                var result = _dal.DeductQuantity(productId, warehouseId, quantity);
                if (!result)
                {
                    error = "فشل في خصم الكمية";
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في خصم المخزون: {ex.Message}";
                return false;
            }
        }

        /// <summary>
        /// حذف رصيد
        /// </summary>
        public bool Delete(int productId, int warehouseId, out string error)
        {
            error = null;

            var current = _dal.GetQuantity(productId, warehouseId);
            if (current > 0)
            {
                error = "لا يمكن حذف رصيد يحتوي على كمية";
                return false;
            }

            try
            {
                _dal.Delete(productId, warehouseId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في الحذف: {ex.Message}";
                return false;
            }
        }
    }
}