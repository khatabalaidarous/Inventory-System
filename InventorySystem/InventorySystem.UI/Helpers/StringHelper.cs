using System;
using System.Text;
using System.Text.RegularExpressions;

namespace InventorySystem.UI.Helpers
{
    /// <summary>
    /// مساعد التعامل مع النصوص
    /// </summary>
    public static class StringHelper
    {
        // ============================================
        // التنظيف
        // ============================================

        /// <summary>
        /// إزالة المسافات الزائدة
        /// </summary>
        public static string Clean(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;

            // إزالة المسافات المتعددة
            return Regex.Replace(text.Trim(), @"\s+", " ");
        }

        /// <summary>
        /// إزالة المسافات من البداية والنهاية
        /// </summary>
        public static string TrimSafe(string text)
        {
            return text?.Trim() ?? string.Empty;
        }

        // ============================================
        // الاختصار
        // ============================================

        /// <summary>
        /// اختصار النص الطويل
        /// </summary>
        public static string Truncate(string text, int maxLength = 50, string suffix = "...")
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;

            if (text.Length <= maxLength) return text;

            return text.Substring(0, maxLength - suffix.Length) + suffix;
        }

        // ============================================
        // التحويل
        // ============================================

        /// <summary>
        /// تحويل النص إلى عنوان (أول حرف كبير)
        /// </summary>
        public static string ToTitleCase(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return string.Empty;

            return System.Globalization.CultureInfo.CurrentCulture
                .TextInfo.ToTitleCase(text.ToLower());
        }

        /// <summary>
        /// تحويل الأرقام إلى أرقام عربية
        /// </summary>
        public static string ToArabicNumbers(string text)
        {
            if (string.IsNullOrEmpty(text)) return text;

            string[] arabicNumbers = { "٠", "١", "٢", "٣", "٤", "٥", "٦", "٧", "٨", "٩" };

            var sb = new StringBuilder();
            foreach (char c in text)
            {
                if (char.IsDigit(c))
                    sb.Append(arabicNumbers[c - '0']);
                else
                    sb.Append(c);
            }

            return sb.ToString();
        }

        // ============================================
        // التوليد
        // ============================================

        /// <summary>
        /// توليد كود تلقائي
        /// </summary>
        public static string GenerateCode(string prefix, int number, int digits = 4)
        {
            return $"{prefix}-{number.ToString().PadLeft(digits, '0')}";
        }

        /// <summary>
        /// توليد اسم مرجعي عشوائي
        /// </summary>
        public static string GenerateReference(string prefix = "REF")
        {
            return $"{prefix}-{DateTime.Now:yyyyMMddHHmmss}";
        }

        // ============================================
        // البحث والمقارنة
        // ============================================

        /// <summary>
        /// هل النص يحتوي على الكلمة؟ (بدون حساسية لحالة الأحرف)
        /// </summary>
        public static bool ContainsIgnoreCase(string text, string keyword)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(keyword))
                return false;

            return text.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        /// <summary>
        /// هل النصان متساويان؟ (بدون حساسية لحالة الأحرف)
        /// </summary>
        public static bool EqualsIgnoreCase(string text1, string text2)
        {
            return string.Equals(text1, text2, StringComparison.OrdinalIgnoreCase);
        }

        // ============================================
        // التحقق
        // ============================================

        /// <summary>
        /// هل النص يحتوي على أحرف عربية؟
        /// </summary>
        public static bool ContainsArabic(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            return Regex.IsMatch(text, @"[\u0600-\u06FF]");
        }

        /// <summary>
        /// هل النص يتكون من أرقام فقط؟
        /// </summary>
        public static bool IsDigitsOnly(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;

            foreach (char c in text)
            {
                if (!char.IsDigit(c)) return false;
            }

            return true;
        }

        // ============================================
        // التنسيق
        // ============================================

        /// <summary>
        /// تنسيق المبلغ مع فاصلة الآلاف
        /// </summary>
        public static string FormatNumber(decimal number, int decimals = 2)
        {
            return number.ToString($"N{decimals}");
        }

        /// <summary>
        /// تنسيق الكمية (بدون أصفار زائدة)
        /// </summary>
        public static string FormatQuantity(decimal quantity)
        {
            if (quantity == Math.Floor(quantity))
                return quantity.ToString("N0");

            return quantity.ToString("N2").TrimEnd('0').TrimEnd('.');
        }

        // ============================================
        // الحصول على الأحرف الأولى
        // ============================================

        /// <summary>
        /// الحصول على الأحرف الأولى من الاسم
        /// </summary>
        public static string GetInitials(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return "";

            var parts = name.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var initials = new StringBuilder();

            foreach (var part in parts)
            {
                if (part.Length > 0)
                    initials.Append(part[0]);
            }

            return initials.ToString().ToUpper();
        }
    }
}