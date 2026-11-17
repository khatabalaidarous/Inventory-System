using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل المنتجات
    /// </summary>
    public class ProductBLL
    {
        private readonly ProductDAL _dal;
        private readonly CategoryDAL _categoryDal;
        private readonly UnitDAL _unitDal;

        public ProductBLL()
        {
            _dal = new ProductDAL();
            _categoryDal = new CategoryDAL();
            _unitDal = new UnitDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل المنتجات
        /// </summary>
        public List<Product> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المنتجات: {ex.Message}";
                return new List<Product>();
            }
        }

        /// <summary>
        /// المنتجات المفعّلة
        /// </summary>
        public List<Product> GetActive(out string error)
        {
            error = null;
            try
            {
                return _dal.GetActive();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المنتجات: {ex.Message}";
                return new List<Product>();
            }
        }

        /// <summary>
        /// البحث في المنتجات
        /// </summary>
        public List<Product> Search(string keyword, out string error)
        {
            error = null;
            try
            {
                if (string.IsNullOrWhiteSpace(keyword))
                    return _dal.GetAll();

                return _dal.Search(keyword);
            }
            catch (Exception ex)
            {
                error = $"فشل في البحث: {ex.Message}";
                return new List<Product>();
            }
        }

        /// <summary>
        /// المنتجات تحت الحد الأدنى
        /// </summary>
        public List<Product> GetBelowMinStock(out string error)
        {
            error = null;
            try
            {
                return _dal.GetBelowMinStock();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المنتجات: {ex.Message}";
                return new List<Product>();
            }
        }

        /// <summary>
        /// الحصول على منتج
        /// </summary>
        public Product GetById(int productId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetById(productId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المنتج: {ex.Message}";
                return null;
            }
        }

        // ============================================
        // الإضافة
        // ============================================

        /// <summary>
        /// إضافة منتج جديد
        /// </summary>
        public bool Add(Product product, out string error)
        {
            error = null;

            if (!Validate(product, out error))
                return false;

            // التحقق من كود المنتج
            if (_dal.IsCodeExists(product.Code))
            {
                error = "كود المنتج موجود مسبقاً";
                return false;
            }

            // التحقق من التصنيف
            if (_categoryDal.GetById(product.CategoryId) == null)
            {
                error = "التصنيف غير موجود";
                return false;
            }

            // التحقق من الوحدة
            if (_unitDal.GetById(product.UnitId) == null)
            {
                error = "الوحدة غير موجودة";
                return false;
            }

            try
            {
                _dal.Add(product);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إضافة المنتج: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التعديل
        // ============================================

        /// <summary>
        /// تعديل منتج
        /// </summary>
        public bool Update(Product product, out string error)
        {
            error = null;

            if (!Validate(product, out error))
                return false;

            if (_dal.IsCodeExists(product.Code, product.ProductId))
            {
                error = "كود المنتج موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Update(product);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعديل المنتج: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف منتج
        /// </summary>
        public bool Delete(int productId, out string error)
        {
            error = null;

            if (_dal.HasStock(productId))
            {
                error = "لا يمكن حذف المنتج لأنه يحتوي على مخزون";
                return false;
            }

            try
            {
                _dal.Delete(productId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف المنتج: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // إحصائيات
        // ============================================

        /// <summary>
        /// عدد المنتجات
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

        private bool Validate(Product product, out string error)
        {
            error = null;

            if (product == null)
            {
                error = "البيانات فارغة";
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Code))
            {
                error = "كود المنتج مطلوب";
                return false;
            }

            if (product.Code.Length > 50)
            {
                error = "كود المنتج طويل جداً (الحد الأقصى 50 حرف)";
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Name))
            {
                error = "اسم المنتج مطلوب";
                return false;
            }

            if (product.Name.Length > 200)
            {
                error = "اسم المنتج طويل جداً (الحد الأقصى 200 حرف)";
                return false;
            }

            if (product.CategoryId <= 0)
            {
                error = "يجب اختيار التصنيف";
                return false;
            }

            if (product.UnitId <= 0)
            {
                error = "يجب اختيار الوحدة";
                return false;
            }

            if (product.MinStock < 0)
            {
                error = "الحد الأدنى لا يمكن أن يكون سالباً";
                return false;
            }

            if (product.MaxStock < 0)
            {
                error = "الحد الأقصى لا يمكن أن يكون سالباً";
                return false;
            }

            if (product.MaxStock > 0 && product.MaxStock < product.MinStock)
            {
                error = "الحد الأقصى يجب أن يكون أكبر من أو يساوي الحد الأدنى";
                return false;
            }

            return true;
        }
    }
}