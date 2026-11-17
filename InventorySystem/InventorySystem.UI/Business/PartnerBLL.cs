using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل الشركاء
    /// </summary>
    public class PartnerBLL
    {
        private readonly PartnerDAL _dal;

        public PartnerBLL()
        {
            _dal = new PartnerDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل الشركاء
        /// </summary>
        public List<Partner> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الشركاء: {ex.Message}";
                return new List<Partner>();
            }
        }

        /// <summary>
        /// الحصول على الموردين
        /// </summary>
        public List<Partner> GetSuppliers(out string error)
        {
            error = null;
            try
            {
                return _dal.GetSuppliers();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الموردين: {ex.Message}";
                return new List<Partner>();
            }
        }

        /// <summary>
        /// الحصول على العملاء
        /// </summary>
        public List<Partner> GetCustomers(out string error)
        {
            error = null;
            try
            {
                return _dal.GetCustomers();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل العملاء: {ex.Message}";
                return new List<Partner>();
            }
        }

        /// <summary>
        /// البحث
        /// </summary>
        public List<Partner> Search(string keyword, out string error)
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
                return new List<Partner>();
            }
        }

        /// <summary>
        /// الحصول على شريك
        /// </summary>
        public Partner GetById(int partnerId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetById(partnerId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الشريك: {ex.Message}";
                return null;
            }
        }

        // ============================================
        // الإضافة
        // ============================================

        /// <summary>
        /// إضافة شريك
        /// </summary>
        public bool Add(Partner partner, out string error)
        {
            error = null;

            if (!Validate(partner, out error))
                return false;

            if (_dal.IsNameExists(partner.Name))
            {
                error = "اسم الشريك موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Add(partner);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إضافة الشريك: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التعديل
        // ============================================

        /// <summary>
        /// تعديل شريك
        /// </summary>
        public bool Update(Partner partner, out string error)
        {
            error = null;

            if (!Validate(partner, out error))
                return false;

            if (_dal.IsNameExists(partner.Name, partner.PartnerId))
            {
                error = "اسم الشريك موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Update(partner);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعديل الشريك: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف شريك
        /// </summary>
        public bool Delete(int partnerId, out string error)
        {
            error = null;

            if (_dal.HasMovements(partnerId))
            {
                error = "لا يمكن حذف الشريك لأنه مرتبط بحركات مخزنية";
                return false;
            }

            try
            {
                _dal.Delete(partnerId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف الشريك: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التحقق
        // ============================================

        private bool Validate(Partner partner, out string error)
        {
            error = null;

            if (partner == null)
            {
                error = "البيانات فارغة";
                return false;
            }

            if (string.IsNullOrWhiteSpace(partner.Name))
            {
                error = "اسم الشريك مطلوب";
                return false;
            }

            if (partner.Name.Length > 200)
            {
                error = "اسم الشريك طويل جداً (الحد الأقصى 200 حرف)";
                return false;
            }

            if (string.IsNullOrWhiteSpace(partner.Type))
            {
                error = "نوع الشريك مطلوب";
                return false;
            }

            if (partner.Type != "Supplier" && partner.Type != "Customer" && partner.Type != "Both")
            {
                error = "نوع الشريك غير صحيح";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(partner.Phone) && partner.Phone.Length > 50)
            {
                error = "رقم الهاتف طويل جداً";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(partner.Email) && partner.Email.Length > 100)
            {
                error = "البريد الإلكتروني طويل جداً";
                return false;
            }

            return true;
        }
    }
}