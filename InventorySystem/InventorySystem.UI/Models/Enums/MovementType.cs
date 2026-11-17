using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.UI.Models.Enums
{
    /// <summary>
    /// أنواع حركات المخزون
    /// </summary>
    public enum MovementType
    {
        /// <summary>
        /// استلام من مورد
        /// </summary>
        IN = 1,

        /// <summary>
        /// صرف لعميل
        /// </summary>
        OUT = 2,

        /// <summary>
        /// تحويل بين مستودعين
        /// </summary>
        TRANSFER = 3,

        /// <summary>
        /// تسوية بعد الجرد
        /// </summary>
        ADJUST = 4
    }
}
