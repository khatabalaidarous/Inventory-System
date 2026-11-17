namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// كمية الدفعة في المستودع
    /// يُمثل جدول InventoryBatches في قاعدة البيانات
    /// </summary>
    public class InventoryBatch
    {
        /// <summary>
        /// معرف السجل (المفتاح الأساسي)
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// معرف الدفعة (مفتاح أجنبي)
        /// </summary>
        public int BatchId { get; set; }

        /// <summary>
        /// معرف المستودع (مفتاح أجنبي)
        /// </summary>
        public int WarehouseId { get; set; }

        /// <summary>
        /// الكمية المتبقية من الدفعة
        /// </summary>
        public decimal Quantity { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// رقم الدفعة (للعرض)
        /// </summary>
        public string BatchNumber { get; set; }

        /// <summary>
        /// اسم المستودع (للعرض)
        /// </summary>
        public string WarehouseName { get; set; }

        // ============================================
        // Constructor
        // ============================================

        public InventoryBatch()
        {
            Quantity = 0;
        }
    }
}