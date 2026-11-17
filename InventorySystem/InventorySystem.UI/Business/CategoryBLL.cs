using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل التصنيفات
    /// </summary>
    public class CategoryBLL
    {
        private readonly CategoryDAL _dal;

        public CategoryBLL()
        {
            _dal = new CategoryDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل التصنيفات
        /// </summary>
        public List<Category> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل التصنيفات: {ex.Message}";
                return new List<Category>();
            }
        }

        /// <summary>
        /// التصنيفات المفعّلة
        /// </summary>
        public List<Category> GetActive(out string error)
        {
            error = null;
            try
            {
                return _dal.GetActive();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل التصنيفات: {ex.Message}";
                return new List<Category>();
            }
        }

        /// <summary>
        /// التصنيفات الرئيسية
        /// </summary>
        public List<Category> GetMainCategories(out string error)
        {
            error = null;
            try
            {
                return _dal.GetMainCategories();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل التصنيفات: {ex.Message}";
                return new List<Category>();
            }
        }

        /// <summary>
        /// الحصول على تصنيف
        /// </summary>
        public Category GetById(int categoryId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetById(categoryId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل التصنيف: {ex.Message}";
                return null;
            }
        }

        // ============================================
        // الإضافة
        // ============================================

        /// <summary>
        /// إضافة تصنيف جديد
        /// </summary>
        public bool Add(Category category, out string error)
        {
            error = null;

            // التحقق من المدخلات
            if (!Validate(category, out error))
                return false;

            // التحقق من عدم تكرار الاسم
            if (_dal.IsNameExists(category.Name))
            {
                error = "اسم التصنيف موجود مسبقاً";
                return false;
            }

            // التحقق من الأب
            if (category.ParentId.HasValue)
            {
                var parent = _dal.GetById(category.ParentId.Value);
                if (parent == null)
                {
                    error = "التصنيف الأب غير موجود";
                    return false;
                }
            }

            try
            {
                _dal.Add(category);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إضافة التصنيف: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التعديل
        // ============================================

        /// <summary>
        /// تعديل تصنيف
        /// </summary>
        public bool Update(Category category, out string error)
        {
            error = null;

            if (!Validate(category, out error))
                return false;

            if (_dal.IsNameExists(category.Name, category.CategoryId))
            {
                error = "اسم التصنيف موجود مسبقاً";
                return false;
            }

            // منع جعل التصنيف أباً لنفسه
            if (category.ParentId.HasValue && category.ParentId.Value == category.CategoryId)
            {
                error = "لا يمكن أن يكون التصنيف أباً لنفسه";
                return false;
            }

            try
            {
                _dal.Update(category);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعديل التصنيف: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف تصنيف
        /// </summary>
        public bool Delete(int categoryId, out string error)
        {
            error = null;

            // التحقق من الاستخدام
            if (_dal.IsUsedInProducts(categoryId))
            {
                error = "لا يمكن حذف التصنيف لأنه مستخدم في منتجات";
                return false;
            }

            if (_dal.HasChildren(categoryId))
            {
                error = "لا يمكن حذف التصنيف لأنه يحتوي على تصنيفات فرعية";
                return false;
            }

            try
            {
                _dal.Delete(categoryId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف التصنيف: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التحقق من الصحة
        // ============================================

        /// <summary>
        /// التحقق من صحة البيانات
        /// </summary>
        private bool Validate(Category category, out string error)
        {
            error = null;

            if (category == null)
            {
                error = "البيانات فارغة";
                return false;
            }

            if (string.IsNullOrWhiteSpace(category.Name))
            {
                error = "اسم التصنيف مطلوب";
                return false;
            }

            if (category.Name.Length > 100)
            {
                error = "اسم التصنيف طويل جداً (الحد الأقصى 100 حرف)";
                return false;
            }

            return true;
        }
    }
}