using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventorySystem.UI.Models.Enums
{
    /// <summary>
    /// حالات الجرد
    /// </summary>
    public enum StocktakeStatus
    {
        /// <summary>
        /// مفتوح (جاري)
        /// </summary>
        Open = 1,

        /// <summary>
        /// مغلق (منتهي)
        /// </summary>
        Closed = 2
    }
}
