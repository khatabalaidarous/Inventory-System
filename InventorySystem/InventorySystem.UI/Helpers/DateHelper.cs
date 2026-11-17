using System;
using System.Globalization;

namespace InventorySystem.UI.Helpers
{
    /// <summary>
    /// مساعد التعامل مع التواريخ
    /// </summary>
    public static class DateHelper
    {
        // ============================================
        // التواريخ الحالية
        // ============================================

        /// <summary>
        /// اليوم الحالي (تاريخ فقط)
        /// </summary>
        public static DateTime Today => DateTime.Today;

        /// <summary>
        /// الآن (تاريخ ووقت)
        /// </summary>
        public static DateTime Now => DateTime.Now;

        /// <summary>
        /// بداية الشهر الحالي
        /// </summary>
        public static DateTime StartOfMonth =>
            new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

        /// <summary>
        /// نهاية الشهر الحالي
        /// </summary>
        public static DateTime EndOfMonth =>
            StartOfMonth.AddMonths(1).AddDays(-1);

        /// <summary>
        /// بداية السنة الحالية
        /// </summary>
        public static DateTime StartOfYear =>
            new DateTime(DateTime.Now.Year, 1, 1);

        // ============================================
        // التنسيق
        // ============================================

        /// <summary>
        /// تنسيق التاريخ (dd/MM/yyyy)
        /// </summary>
        public static string FormatDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// تنسيق التاريخ والوقت
        /// </summary>
        public static string FormatDateTime(DateTime date)
        {
            return date.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// تنسيق الوقت فقط
        /// </summary>
        public static string FormatTime(DateTime date)
        {
            return date.ToString("HH:mm", CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// تنسيق تاريخ للعرض (بالعربية)
        /// </summary>
        public static string ToArabicDate(DateTime date)
        {
            return date.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        // ============================================
        // الحسابات
        // ============================================

        /// <summary>
        /// عدد الأيام بين تاريخين
        /// </summary>
        public static int DaysBetween(DateTime from, DateTime to)
        {
            return (to.Date - from.Date).Days;
        }

        /// <summary>
        /// عدد الأيام من تاريخ معين حتى اليوم
        /// </summary>
        public static int DaysFromNow(DateTime date)
        {
            return DaysBetween(DateTime.Now, date);
        }

        /// <summary>
        /// عدد الأيام حتى تاريخ معين
        /// </summary>
        public static int DaysUntil(DateTime date)
        {
            return (date.Date - DateTime.Today).Days;
        }

        // ============================================
        // التحقق من الصلاحية
        // ============================================

        /// <summary>
        /// هل التاريخ منتهي؟
        /// </summary>
        public static bool IsExpired(DateTime expiryDate)
        {
            return expiryDate < DateTime.Now;
        }

        /// <summary>
        /// هل التاريخ قريب من الانتهاء؟
        /// </summary>
        public static bool IsExpiringSoon(DateTime? expiryDate, int days = 30)
        {
            if (!expiryDate.HasValue) return false;

            int remainingDays = DaysUntil(expiryDate.Value);
            return remainingDays >= 0 && remainingDays <= days;
        }

        // ============================================
        // الوصف
        // ============================================

        /// <summary>
        /// وصف التاريخ النسبي (منذ يومين، بعد 3 أيام، إلخ)
        /// </summary>
        public static string GetRelativeDate(DateTime date)
        {
            var diff = DateTime.Now - date;

            if (diff.TotalDays < 0)
            {
                // مستقبل
                var futureDiff = date - DateTime.Now;

                if (futureDiff.TotalDays < 1)
                    return "بعد ساعات";
                if (futureDiff.TotalDays < 7)
                    return $"بعد {(int)futureDiff.TotalDays} يوم";
                if (futureDiff.TotalDays < 30)
                    return $"بعد {(int)(futureDiff.TotalDays / 7)} أسبوع";
                if (futureDiff.TotalDays < 365)
                    return $"بعد {(int)(futureDiff.TotalDays / 30)} شهر";
                return $"بعد {(int)(futureDiff.TotalDays / 365)} سنة";
            }
            else
            {
                // ماضي
                if (diff.TotalDays < 1)
                    return "اليوم";
                if (diff.TotalDays < 2)
                    return "أمس";
                if (diff.TotalDays < 7)
                    return $"منذ {(int)diff.TotalDays} يوم";
                if (diff.TotalDays < 30)
                    return $"منذ {(int)(diff.TotalDays / 7)} أسبوع";
                if (diff.TotalDays < 365)
                    return $"منذ {(int)(diff.TotalDays / 30)} شهر";
                return $"منذ {(int)(diff.TotalDays / 365)} سنة";
            }
        }

        /// <summary>
        /// اسم اليوم بالعربية
        /// </summary>
        public static string GetDayNameArabic(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Saturday: return "السبت";
                case DayOfWeek.Sunday: return "الأحد";
                case DayOfWeek.Monday: return "الإثنين";
                case DayOfWeek.Tuesday: return "الثلاثاء";
                case DayOfWeek.Wednesday: return "الأربعاء";
                case DayOfWeek.Thursday: return "الخميس";
                case DayOfWeek.Friday: return "الجمعة";
                default: return "";
            }
        }

        /// <summary>
        /// اسم الشهر بالعربية
        /// </summary>
        public static string GetMonthNameArabic(int month)
        {
            string[] months = {
                "يناير", "فبراير", "مارس", "أبريل", "مايو", "يونيو",
                "يوليو", "أغسطس", "سبتمبر", "أكتوبر", "نوفمبر", "ديسمبر"
            };

            if (month >= 1 && month <= 12)
                return months[month - 1];

            return "";
        }
    }
}