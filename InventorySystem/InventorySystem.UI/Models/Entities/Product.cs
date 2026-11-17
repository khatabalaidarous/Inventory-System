using System;

namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// المنتج
    /// يُمثل جدول Products في قاعدة البيانات
    /// </summary>
    public class Product
    {
        /// <summary>
        /// معرف المنتج (المفتاح الأساسي)
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// كود المنتج (فريد)
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم المنتج
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// معرف التصنيف (مفتاح أجنبي)
        /// </summary>
        public int CategoryId { get; set; }

        /// <summary>
        /// معرف الوحدة (مفتاح أجنبي)
        /// </summary>
        public int UnitId { get; set; }

        /// <summary>
        /// الحد الأدنى للمخزون
        /// </summary>
        public decimal MinStock { get; set; }

        /// <summary>
        /// الحد الأقصى للمخزون
        /// </summary>
        public decimal MaxStock { get; set; }

        /// <summary>
        /// هل المنتج مفعّل؟
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
        /// اسم التصنيف (للعرض)
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// اسم الوحدة (للعرض)
        /// </summary>
        public string UnitName { get; set; }

        /// <summary>
        /// الرصيد الحالي (للعرض)
        /// </summary>
        public decimal CurrentStock { get; set; }

        // ============================================
        // Constructor
        // ============================================

        public Product()
        {
            IsActive = true;
            CreatedAt = DateTime.Now;
            MinStock = 0;
            MaxStock = 0;
        }
    }
}