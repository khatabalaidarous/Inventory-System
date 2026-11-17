namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// تفاصيل الجرد
    /// يُمثل جدول StocktakeDetails في قاعدة البيانات
    /// </summary>
    public class StocktakeDetail
    {
        /// <summary>
        /// معرف السجل (المفتاح الأساسي)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// معرف الجرد (مفتاح أجنبي)
        /// </summary>
        public int StocktakeId { get; set; }

        /// <summary>
        /// معرف المنتج (مفتاح أجنبي)
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// معرف الدفعة (مفتاح أجنبي - اختياري)
        /// </summary>
        public int? BatchId { get; set; }

        /// <summary>
        /// الكمية في النظام
        /// </summary>
        public decimal SystemQty { get; set; }

        /// <summary>
        /// الكمية الفعلية
        /// </summary>
        public decimal CountedQty { get; set; }

        /// <summary>
        /// الفرق (محسوب)
        /// </summary>
        public decimal Difference { get; set; }

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
    }
}