using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل الدفعات
    /// </summary>
    public class BatchBLL
    {
        private readonly BatchDAL _dal;
        private readonly ProductDAL _productDal;

        public BatchBLL()
        {
            _dal = new BatchDAL();
            _productDal = new ProductDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل الدفعات
        /// </summary>
        public List<Batch> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الدفعات: {ex.Message}";
                return new List<Batch>();
            }
        }

        /// <summary>
        /// دفعات منتج معين
        /// </summary>
        public List<Batch> GetByProduct(int productId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetByProduct(productId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الدفعات: {ex.Message}";
                return new List<Batch>();
            }
        }

        /// <summary>
        /// الدفعات القريبة من الانتهاء
        /// </summary>
        public List<Batch> GetExpiringSoon(out string error, int days = 30)
        {
            error = null;
            try
            {
                return _dal.GetExpiringSoon(days);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الدفعات: {ex.Message}";
                return new List<Batch>();
            }
        }

        /// <summary>
        /// الدفعات المنتهية
        /// </summary>
        public List<Batch> GetExpired(out string error)
        {
            error = null;
            try
            {
                return _dal.GetExpired();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الدفعات: {ex.Message}";
                return new List<Batch>();
            }
        }

        /// <summary>
        /// الحصول على دفعة
        /// </summary>
        public Batch GetById(int batchId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetById(batchId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الدفعة: {ex.Message}";
                return null;
            }
        }

        // ============================================
        // الإضافة
        // ============================================

        /// <summary>
        /// إضافة دفعة
        /// </summary>
        public bool Add(Batch batch, out string error)
        {
            error = null;

            if (!Validate(batch, out error))
                return false;

            // التحقق من المنتج
            if (_productDal.GetById(batch.ProductId) == null)
            {
                error = "المنتج غير موجود";
                return false;
            }

            // التحقق من تكرار رقم الدفعة
            if (_dal.IsBatchNumberExists(batch.ProductId, batch.BatchNumber))
            {
                error = "رقم الدفعة موجود مسبقاً لهذا المنتج";
                return false;
            }

            try
            {
                _dal.Add(batch);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إضافة الدفعة: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التعديل
        // ============================================

        /// <summary>
        /// تعديل دفعة
        /// </summary>
        public bool Update(Batch batch, out string error)
        {
            error = null;

            if (!Validate(batch, out error))
                return false;

            if (_dal.IsBatchNumberExists(batch.ProductId, batch.BatchNumber, batch.BatchId))
            {
                error = "رقم الدفعة موجود مسبقاً لهذا المنتج";
                return false;
            }

            try
            {
                _dal.Update(batch);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعديل الدفعة: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف دفعة
        /// </summary>
        public bool Delete(int batchId, out string error)
        {
            error = null;

            if (_dal.HasQuantity(batchId))
            {
                error = "لا يمكن حذف الدفعة لوجود كمية متبقية منها";
                return false;
            }

            try
            {
                _dal.Delete(batchId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف الدفعة: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التحقق
        // ============================================

        private bool Validate(Batch batch, out string error)
        {
            error = null;

            if (batch == null)
            {
                error = "البيانات فارغة";
                return false;
            }

            if (batch.ProductId <= 0)
            {
                error = "يجب اختيار المنتج";
                return false;
            }

            if (string.IsNullOrWhiteSpace(batch.BatchNumber))
            {
                error = "رقم الدفعة مطلوب";
                return false;
            }

            if (batch.BatchNumber.Length > 50)
            {
                error = "رقم الدفعة طويل جداً (الحد الأقصى 50 حرف)";
                return false;
            }

            if (batch.ProductionDate.HasValue && batch.ExpiryDate.HasValue)
            {
                if (batch.ExpiryDate.Value < batch.ProductionDate.Value)
                {
                    error = "تاريخ الانتهاء يجب أن يكون بعد تاريخ الإنتاج";
                    return false;
                }
            }

            return true;
        }
    }
}