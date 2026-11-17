namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// تفاصيل الحركة المخزنية
    /// يُمثل جدول StockMovementDetails في قاعدة البيانات
    /// </summary>
    public class StockMovementDetail
    {
        /// <summary>
        /// معرف التفصيل (المفتاح الأساسي)
        /// </summary>
        public int DetailId { get; set; }

        /// <summary>
        /// معرف الحركة (مفتاح أجنبي)
        /// </summary>
        public int MovementId { get; set; }

        /// <summary>
        /// معرف المنتج (مفتاح أجنبي)
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// معرف الدفعة (مفتاح أجنبي - اختياري)
        /// </summary>
        public int? BatchId { get; set; }

        /// <summary>
        /// الكمية
        /// </summary>
        public decimal Quantity { get; set; }

        /// <summary>
        /// سعر الوحدة
        /// </summary>
        public decimal? UnitPrice { get; set; }

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
        /// رقم الدفعة (للعرض)
        /// </summary>
        public string BatchNumber { get; set; }

        /// <summary>
        /// الإجمالي (الكمية × السعر)
        /// </summary>
        public decimal Total => UnitPrice.HasValue
            ? Quantity * UnitPrice.Value
            : 0;
    }
}