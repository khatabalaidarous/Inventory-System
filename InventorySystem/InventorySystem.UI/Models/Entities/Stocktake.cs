using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// رأس الجرد
    /// يُمثل جدول Stocktakes في قاعدة البيانات
    /// </summary>
    public class Stocktake
    {
        /// <summary>
        /// معرف الجرد (المفتاح الأساسي)
        /// </summary>
        public int StocktakeId { get; set; }

        /// <summary>
        /// معرف المستودع (مفتاح أجنبي)
        /// </summary>
        public int WarehouseId { get; set; }

        /// <summary>
        /// تاريخ الجرد
        /// </summary>
        public DateTime StocktakeDate { get; set; }

        /// <summary>
        /// حالة الجرد (Open / Closed)
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// معرف من أنشأ الجرد (مفتاح أجنبي)
        /// </summary>
        public int CreatedBy { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// اسم المستودع (للعرض)
        /// </summary>
        public string WarehouseName { get; set; }

        /// <summary>
        /// اسم من أنشأ الجرد (للعرض)
        /// </summary>
        public string CreatorName { get; set; }

        /// <summary>
        /// حالة الجرد بالعربية (للعرض)
        /// </summary>
        public string StatusName
        {
            get
            {
                switch (Status)
                {
                    case "Open": return "مفتوح";
                    case "Closed": return "مغلق";
                    default: return Status;
                }
            }
        }

        /// <summary>
        /// تفاصيل الجرد
        /// </summary>
        public List<StocktakeDetail> Details { get; set; }

        // ============================================
        // Constructor
        // ============================================

        public Stocktake()
        {
            StocktakeDate = DateTime.Now;
            Status = "Open";
            Details = new List<StocktakeDetail>();
        }
    }
}