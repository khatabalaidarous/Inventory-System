using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.UI.Models.Enums
{
    /// <summary>
    /// أنواع عمليات التدقيق
    /// </summary>
    public enum AuditAction
    {
        /// <summary>
        /// إضافة
        /// </summary>
        Insert = 1,

        /// <summary>
        /// تعديل
        /// </summary>
        Update = 2,

        /// <summary>
        /// حذف
        /// </summary>
        Delete = 3
    }
}
