namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// ربط المستخدم بالدور
    /// يُمثل جدول UserRoles في قاعدة البيانات
    /// (جدول Many-to-Many)
    /// </summary>
    public class UserRole
    {
        /// <summary>
        /// معرف المستخدم (مفتاح أساسي مركّب)
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// معرف الدور (مفتاح أساسي مركّب)
        /// </summary>
        public int RoleId { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// اسم المستخدم (للعرض)
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// اسم الدور (للعرض)
        /// </summary>
        public string RoleName { get; set; }
    }
}