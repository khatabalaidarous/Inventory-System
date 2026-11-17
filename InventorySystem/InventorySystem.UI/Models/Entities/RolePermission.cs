namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// ربط الدور بالصلاحية
    /// يُمثل جدول RolePermissions في قاعدة البيانات
    /// (جدول Many-to-Many)
    /// </summary>
    public class RolePermission
    {
        /// <summary>
        /// معرف الدور (مفتاح أساسي مركّب)
        /// </summary>
        public int RoleId { get; set; }

        /// <summary>
        /// معرف الصلاحية (مفتاح أساسي مركّب)
        /// </summary>
        public int PermissionId { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// اسم الدور (للعرض)
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// اسم الصلاحية (للعرض)
        /// </summary>
        public string PermissionName { get; set; }

        /// <summary>
        /// كود الصلاحية (للعرض)
        /// </summary>
        public string PermissionCode { get; set; }
    }
}