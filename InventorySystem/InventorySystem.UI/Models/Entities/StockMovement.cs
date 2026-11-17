using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// رأس الحركة المخزنية
    /// يُمثل جدول StockMovements في قاعدة البيانات
    /// </summary>
    public class StockMovement
    {
        /// <summary>
        /// معرف الحركة (المفتاح الأساسي)
        /// </summary>
        public int MovementId { get; set; }

        /// <summary>
        /// نوع الحركة (IN / OUT / TRANSFER / ADJUST)
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// تاريخ الحركة
        /// </summary>
        public DateTime MovementDate { get; set; }

        /// <summary>
        /// معرف المستخدم (مفتاح أجنبي)
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// من مستودع (فارغ للاستلام)
        /// </summary>
        public int? FromWarehouseId { get; set; }

        /// <summary>
        /// إلى مستودع (فارغ للصرف)
        /// </summary>
        public int? ToWarehouseId { get; set; }

        /// <summary>
        /// معرف الشريك (مورد أو عميل)
        /// </summary>
        public int? PartnerId { get; set; }

        /// <summary>
        /// رقم مرجعي
        /// </summary>
        public string Reference { get; set; }

        /// <summary>
        /// ملاحظات
        /// </summary>
        public string Notes { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// اسم المستخدم (للعرض)
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// اسم المستودع المصدر (للعرض)
        /// </summary>
        public string FromWarehouseName { get; set; }

        /// <summary>
        /// اسم المستودع الهدف (للعرض)
        /// </summary>
        public string ToWarehouseName { get; set; }

        /// <summary>
        /// اسم الشريك (للعرض)
        /// </summary>
        public string PartnerName { get; set; }

        /// <summary>
        /// نوع الحركة بالعربية (للعرض)
        /// </summary>
        public string TypeName
        {
            get
            {
                switch (Type)
                {
                    case "IN": return "استلام";
                    case "OUT": return "صرف";
                    case "TRANSFER": return "تحويل";
                    case "ADJUST": return "تسوية";
                    default: return Type;
                }
            }
        }

        /// <summary>
        /// تفاصيل الحركة
        /// </summary>
        public List<StockMovementDetail> Details { get; set; }

        // ============================================
        // Constructor
        // ============================================

        public StockMovement()
        {
            MovementDate = DateTime.Now;
            Details = new List<StockMovementDetail>();
        }
    }
}