using System;

namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// الشريك (مورد أو عميل)
    /// يُمثل جدول Partners في قاعدة البيانات
    /// </summary>
    public class Partner
    {
        /// <summary>
        /// معرف الشريك (المفتاح الأساسي)
        /// </summary>
        public int PartnerId { get; set; }

        /// <summary>
        /// اسم الشريك
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// نوع الشريك (Supplier / Customer / Both)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// رقم الهاتف
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// البريد الإلكتروني
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// العنوان
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// الرقم الضريبي
        /// </summary>
        public string TaxNumber { get; set; }

        /// <summary>
        /// هل الشريك مفعّل؟
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// تاريخ الإضافة
        /// </summary>
        public DateTime CreatedAt { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// اسم النوع بالعربية (للعرض)
        /// </summary>
        public string TypeName
        {
            get
            {
                switch (Type)
                {
                    case "Supplier": return "مورد";
                    case "Customer": return "عميل";
                    case "Both": return "مورد وعميل";
                    default: return Type;
                }
            }
        }

        // ============================================
        // Constructor
        // ============================================

        public Partner()
        {
            IsActive = true;
            CreatedAt = DateTime.Now;
        }
    }
}