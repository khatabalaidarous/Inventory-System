namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// الصلاحية
    /// يُمثل جدول Permissions في قاعدة البيانات
    /// </summary>
    public class Permission
    {
        /// <summary>
        /// معرف الصلاحية (المفتاح الأساسي)
        /// </summary>
        public int PermissionId { get; set; }

        /// <summary>
        /// كود الصلاحية (فريد)
        /// مثال: Products.View
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// اسم الصلاحية
        /// </summary>
        public string Name { get; set; }

        // ============================================
        // Constructor
        // ============================================

        public Permission()
        {
        }
    }
}