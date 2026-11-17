using System;

namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// التصنيف
    /// يُمثل جدول Categories في قاعدة البيانات
    /// </summary>
    public class Category
    {
        /// <summary>
        /// معرف التصنيف (المفتاح الأساسي)
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// اسم التصنيف
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// معرف التصنيف الأب (للتصنيفات الهرمية)
        /// </summary>
        public int? ParentId { get; set; }

        /// <summary>
        /// هل التصنيف مفعّل؟
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedAt { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// اسم التصنيف الأب (للعرض)
        /// </summary>
        public string ParentName { get; set; }

        // ============================================
        // Constructor
        // ============================================

        public Category()
        {
            IsActive = true;
            CreatedAt = DateTime.Now;
        }
    }
}