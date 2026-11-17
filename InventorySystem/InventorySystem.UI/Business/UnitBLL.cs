using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل الوحدات
    /// </summary>
    public class UnitBLL
    {
        private readonly UnitDAL _dal;

        public UnitBLL()
        {
            _dal = new UnitDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل الوحدات
        /// </summary>
        public List<Unit> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الوحدات: {ex.Message}";
                return new List<Unit>();
            }
        }

        /// <summary>
        /// الحصول على وحدة
        /// </summary>
        public Unit GetById(int unitId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetById(unitId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الوحدة: {ex.Message}";
                return null;
            }
        }

        // ============================================
        // الإضافة
        // ============================================

        /// <summary>
        /// إضافة وحدة جديدة
        /// </summary>
        public bool Add(Unit unit, out string error)
        {
            error = null;

            if (!Validate(unit, out error))
                return false;

            if (_dal.IsNameExists(unit.Name))
            {
                error = "اسم الوحدة موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Add(unit);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إضافة الوحدة: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التعديل
        // ============================================

        /// <summary>
        /// تعديل وحدة
        /// </summary>
        public bool Update(Unit unit, out string error)
        {
            error = null;

            if (!Validate(unit, out error))
                return false;

            if (_dal.IsNameExists(unit.Name, unit.UnitId))
            {
                error = "اسم الوحدة موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Update(unit);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعديل الوحدة: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف وحدة
        /// </summary>
        public bool Delete(int unitId, out string error)
        {
            error = null;

            if (_dal.IsUsedInProducts(unitId))
            {
                error = "لا يمكن حذف الوحدة لأنها مستخدمة في منتجات";
                return false;
            }

            try
            {
                _dal.Delete(unitId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف الوحدة: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التحقق
        // ============================================

        private bool Validate(Unit unit, out string error)
        {
            error = null;

            if (unit == null)
            {
                error = "البيانات فارغة";
                return false;
            }

            if (string.IsNullOrWhiteSpace(unit.Name))
            {
                error = "اسم الوحدة مطلوب";
                return false;
            }

            if (unit.Name.Length > 50)
            {
                error = "اسم الوحدة طويل جداً (الحد الأقصى 50 حرف)";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(unit.Symbol) && unit.Symbol.Length > 10)
            {
                error = "رمز الوحدة طويل جداً (الحد الأقصى 10 أحرف)";
                return false;
            }

            return true;
        }
    }
}