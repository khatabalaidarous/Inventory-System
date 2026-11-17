using System;

namespace InventorySystem.UI.Models.Entities
{
    /// <summary>
    /// المستخدم
    /// يُمثل جدول Users في قاعدة البيانات
    /// </summary>
    public class User
    {
        /// <summary>
        /// معرف المستخدم (المفتاح الأساسي)
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// اسم الدخول (فريد)
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// كلمة المرور مشفرة
        /// </summary>
        public string PasswordHash { get; set; }

        /// <summary>
        /// الاسم الكامل
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// هل المستخدم مفعّل؟
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// تاريخ الإنشاء
        /// </summary>
        public DateTime CreatedAt { get; set; }

        // ============================================
        // Constructor
        // ============================================

        public User()
        {
            IsActive = true;
            CreatedAt = DateTime.Now;
        }
    }
}