namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// المستودع
    /// يُمثل جدول Warehouses في قاعدة البيانات
    /// </summary>
    public class Warehouse
    {
        /// <summary>
        /// معرف المستودع (المفتاح الأساسي)
        /// </summary>
        public int WarehouseId { get; set; }

        /// <summary>
        /// اسم المستودع
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// الموقع الجغرافي
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// معرف المدير (مفتاح أجنبي)
        /// </summary>
        public int? ManagerId { get; set; }

        /// <summary>
        /// هل المستودع مفعّل؟
        /// </summary>
        public bool IsActive { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// اسم المدير (للعرض)
        /// </summary>
        public string ManagerName { get; set; }

        // ============================================
        // Constructor
        // ============================================

        public Warehouse()
        {
            IsActive = true;
        }
    }
}