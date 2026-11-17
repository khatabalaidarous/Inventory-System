using System;

namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// رصيد المخزون
    /// يُمثل جدول Inventory في قاعدة البيانات
    /// </summary>
    public class Inventory
    {
        /// <summary>
        /// معرف السجل (المفتاح الأساسي)
        /// </summary>
        public int InventoryId { get; set; }

        /// <summary>
        /// معرف المنتج (مفتاح أجنبي)
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// معرف المستودع (مفتاح أجنبي)
        /// </summary>
        public int WarehouseId { get; set; }

        /// <summary>
        /// الكمية المتاحة
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// الكمية المحجوزة
        /// </summary>
        public decimal ReservedQty { get; set; }

        /// <summary>
        /// آخر تحديث
        /// </summary>
        public DateTime LastUpdated { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// اسم المنتج (للعرض)
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// كود المنتج (للعرض)
        /// </summary>
        public string ProductCode { get; set; }

        /// <summary>
        /// اسم المستودع (للعرض)
        /// </summary>
        public string WarehouseName { get; set; }

        /// <summary>
        /// الكمية المتاحة فعلياً (محسوبة)
        /// </summary>
        public decimal AvailableQuantity => Quantity - ReservedQty;

        // ============================================
        // Constructor
        // ============================================

        public Inventory()
        {
            Quantity = 0;
            ReservedQty = 0;
            LastUpdated = DateTime.Now;
        }
    }
}