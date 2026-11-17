namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// الدور
    /// يُمثل جدول Roles في قاعدة البيانات
    /// </summary>
    public class Role
    {
        /// <summary>
        /// معرف الدور (المفتاح الأساسي)
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// اسم الدور (فريد)
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// وصف الدور
        /// </summary>
        public string Description { get; set; }

        // ============================================
        // Constructor
        // ============================================

        public Role()
        {
        }
    }
}