using System;

namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// الدفعة
    /// يُمثل جدول Batches في قاعدة البيانات
    /// </summary>
    public class Batch
    {
        /// <summary>
        /// معرف الدفعة (المفتاح الأساسي)
        /// </summary>
        public int BatchId { get; set; }

        /// <summary>
        /// معرف المنتج (مفتاح أجنبي)
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// رقم الدفعة
        /// </summary>
        public string BatchNumber { get; set; }

        /// <summary>
        /// تاريخ الإنتاج
        /// </summary>
        public DateTime? ProductionDate { get; set; }

        /// <summary>
        /// تاريخ الانتهاء
        /// </summary>
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// تاريخ التسجيل
        /// </summary>
        public DateTime CreatedAt { get; set; }

        // ============================================
        // خصائص إضافية للعرض
        // ============================================

        /// <summary>
        /// اسم المنتج (للعرض)
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// هل الدفعة قريبة من الانتهاء؟
        /// </summary>
        public bool IsExpiringSoon
        {
            get
            {
                if (!ExpiryDate.HasValue) return false;
                var days = (ExpiryDate.Value - DateTime.Now).Days;
                return days >= 0 && days <= 30;
            }
        }

        /// <summary>
        /// هل الدفعة منتهية؟
        /// </summary>
        public bool IsExpired
        {
            get
            {
                if (!ExpiryDate.HasValue) return false;
                return ExpiryDate.Value < DateTime.Now;
            }
        }

        // ============================================
        // Constructor
        // ============================================

        public Batch()
        {
            CreatedAt = DateTime.Now;
        }
    }
}