using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// إدارة جلسة المستخدم
    /// Singleton Pattern
    /// </summary>
    public static class SessionManager
    {
        // ============================================
        // الخصائص
        // ============================================

        /// <summary>
        /// المستخدم الحالي
        /// </summary>
        public static User CurrentUser { get; private set; }

        /// <summary>
        /// صلاحيات المستخدم الحالي
        /// </summary>
        public static List<string> Permissions { get; private set; }

        /// <summary>
        /// أدوار المستخدم الحالي
        /// </summary>
        public static List<string> Roles { get; private set; }

        /// <summary>
        /// وقت تسجيل الدخول
        /// </summary>
        public static DateTime LoginTime { get; private set; }

        /// <summary>
        /// هل المستخدم مسجل دخول؟
        /// </summary>
        public static bool IsLoggedIn => CurrentUser != null;

        // ============================================
        // Constructor
        // ============================================

        static SessionManager()
        {
            Permissions = new List<string>();
            Roles = new List<string>();
        }

        // ============================================
        // تسجيل الدخول
        // ============================================

        /// <summary>
        /// تهيئة الجلسة بعد تسجيل الدخول
        /// </summary>
        public static void Initialize(User user, List<string> roles = null, List<string> permissions = null)
        {
            CurrentUser = user;
            LoginTime = DateTime.Now;
            Roles = roles ?? new List<string>();
            Permissions = permissions ?? new List<string>();
        }

        // ============================================
        // تسجيل الخروج
        // ============================================

        /// <summary>
        /// إنهاء الجلسة
        /// </summary>
        public static void Logout()
        {
            CurrentUser = null;
            Permissions.Clear();
            Roles.Clear();
            LoginTime = DateTime.MinValue;
        }

        // ============================================
        // التحقق من الصلاحيات
        // ============================================

        /// <summary>
        /// هل المستخدم لديه صلاحية معينة؟
        /// </summary>
        public static bool HasPermission(string permissionCode)
        {
            if (CurrentUser == null) return false;

            // المدير له كل الصلاحيات
            if (Roles.Contains("مدير النظام")) return true;

            return Permissions.Contains(permissionCode);
        }

        /// <summary>
        /// هل المستخدم لديه أي من الصلاحيات؟
        /// </summary>
        public static bool HasAnyPermission(params string[] permissionCodes)
        {
            return permissionCodes.Any(p => HasPermission(p));
        }

        /// <summary>
        /// هل المستخدم لديه كل الصلاحيات؟
        /// </summary>
        public static bool HasAllPermissions(params string[] permissionCodes)
        {
            return permissionCodes.All(p => HasPermission(p));
        }

        /// <summary>
        /// هل المستخدم لديه دور معين؟
        /// </summary>
        public static bool HasRole(string roleName)
        {
            if (CurrentUser == null) return false;
            return Roles.Contains(roleName);
        }

        /// <summary>
        /// هل المستخدم مدير؟
        /// </summary>
        public static bool IsAdmin()
        {
            return HasRole("مدير النظام");
        }

        // ============================================
        // معلومات المستخدم
        // ============================================

        /// <summary>
        /// معرف المستخدم الحالي
        /// </summary>
        public static int UserId => CurrentUser?.UserId ?? 0;

        /// <summary>
        /// اسم المستخدم الحالي
        /// </summary>
        public static string Username => CurrentUser?.Username ?? "غير معروف";

        /// <summary>
        /// الاسم الكامل للمستخدم الحالي
        /// </summary>
        public static string FullName => CurrentUser?.FullName ?? "غير معروف";

        /// <summary>
        /// مدة الجلسة
        /// </summary>
        public static TimeSpan SessionDuration
        {
            get
            {
                if (!IsLoggedIn) return TimeSpan.Zero;
                return DateTime.Now - LoginTime;
            }
        }
    }
}