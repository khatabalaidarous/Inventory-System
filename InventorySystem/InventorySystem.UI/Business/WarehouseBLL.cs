using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل المستودعات
    /// </summary>
    public class WarehouseBLL
    {
        private readonly WarehouseDAL _dal;

        public WarehouseBLL()
        {
            _dal = new WarehouseDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل المستودعات
        /// </summary>
        public List<Warehouse> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المستودعات: {ex.Message}";
                return new List<Warehouse>();
            }
        }

        /// <summary>
        /// المستودعات المفعّلة
        /// </summary>
        public List<Warehouse> GetActive(out string error)
        {
            error = null;
            try
            {
                return _dal.GetActive();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المستودعات: {ex.Message}";
                return new List<Warehouse>();
            }
        }

        /// <summary>
        /// الحصول على مستودع
        /// </summary>
        public Warehouse GetById(int warehouseId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetById(warehouseId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المستودع: {ex.Message}";
                return null;
            }
        }

        // ============================================
        // الإضافة
        // ============================================

        /// <summary>
        /// إضافة مستودع
        /// </summary>
        public bool Add(Warehouse warehouse, out string error)
        {
            error = null;

            if (!Validate(warehouse, out error))
                return false;

            if (_dal.IsNameExists(warehouse.Name))
            {
                error = "اسم المستودع موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Add(warehouse);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إضافة المستودع: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التعديل
        // ============================================

        /// <summary>
        /// تعديل مستودع
        /// </summary>
        public bool Update(Warehouse warehouse, out string error)
        {
            error = null;

            if (!Validate(warehouse, out error))
                return false;

            if (_dal.IsNameExists(warehouse.Name, warehouse.WarehouseId))
            {
                error = "اسم المستودع موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Update(warehouse);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعديل المستودع: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف مستودع
        /// </summary>
        public bool Delete(int warehouseId, out string error)
        {
            error = null;

            if (_dal.HasInventory(warehouseId))
            {
                error = "لا يمكن حذف المستودع لأنه يحتوي على مخزون";
                return false;
            }

            try
            {
                _dal.Delete(warehouseId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف المستودع: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // إحصائيات
        // ============================================

        /// <summary>
        /// عدد المستودعات
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
        // التحقق
        // ============================================

        private bool Validate(Warehouse warehouse, out string error)
        {
            error = null;

            if (warehouse == null)
            {
                error = "البيانات فارغة";
                return false;
            }

            if (string.IsNullOrWhiteSpace(warehouse.Name))
            {
                error = "اسم المستودع مطلوب";
                return false;
            }

            if (warehouse.Name.Length > 100)
            {
                error = "اسم المستودع طويل جداً (الحد الأقصى 100 حرف)";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(warehouse.Location) && warehouse.Location.Length > 200)
            {
                error = "الموقع طويل جداً (الحد الأقصى 200 حرف)";
                return false;
            }

            return true;
        }
    }
}