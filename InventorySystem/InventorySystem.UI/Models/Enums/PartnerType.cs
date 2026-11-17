using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.UI.Models.Enums
{
    /// <summary>
    /// أنواع الشركاء
    /// </summary>
    public enum PartnerType
    {
        /// <summary>
        /// مورد
        /// </summary>
        Supplier = 1,

        /// <summary>
        /// عميل
        /// </summary>
        Customer = 2,

        /// <summary>
        /// مورد وعميل
        /// </summary>
        Both = 3
    }
}
