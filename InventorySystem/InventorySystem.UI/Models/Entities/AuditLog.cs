using System;

namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// سجل التدقيق
    /// يُمثل جدول AuditLog في قاعدة البيانات
    /// </summary>
    public class AuditLog
    {
        /// <summary>
        /// معرف السجل (المفتاح الأساسي)
        /// </summary>
        public long LogId { get; set; }

        /// <summary>
        /// معرف المستخدم (مفتاح أجنبي - اختياري)
        /// </summary>
        public int? UserId { get; set; }

        /// <summary>
        /// نوع العملية (Insert / Update / Delete)
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// اسم الجدول
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// معرف السجل المعدّل
        /// </summary>
        public int? RecordId { get; set; }

        /// <summary>
        /// القيمة القديمة
        /// </summary>
        public string OldValue { get; set; }

        /// <summary>
        /// القيمة الجديدة
        /// </summary>
        public string NewValue { get; set; }

        /// <summary>
        /// تاريخ العملية
        /// </summary>
        public DateTime LogDate { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// اسم المستخدم (للعرض)
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// نوع العملية بالعربية (للعرض)
        /// </summary>
        public string ActionName
        {
            get
            {
                switch (Action)
                {
                    case "Insert": return "إضافة";
                    case "Update": return "تعديل";
                    case "Delete": return "حذف";
                    default: return Action;
                }
            }
        }

        // ============================================
        // Constructor
        // ============================================

        public AuditLog()
        {
            LogDate = DateTime.Now;
        }
    }
}