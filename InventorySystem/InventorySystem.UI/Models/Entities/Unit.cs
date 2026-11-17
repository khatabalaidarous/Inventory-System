namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// الوحدة
    /// يُمثل جدول Units في قاعدة البيانات
    /// </summary>
    public class Unit
    {
        /// <summary>
        /// معرف الوحدة (المفتاح الأساسي)
        /// </summary>
        public int UnitId { get; set; }

        /// <summary>
        /// اسم الوحدة (قطعة، كرتون، كيلو...)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// رمز الوحدة (PCS, CTN, KG...)
        /// </summary>
        public string Symbol { get; set; }

        // ============================================
        // Constructor
        // ============================================

        public Unit()
        {
        }
    }
}