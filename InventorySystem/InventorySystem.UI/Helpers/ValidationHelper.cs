using System;
using System.Text.RegularExpressions;

namespace InventorySystem.UI.Helpers
{
    /// <summary>
    /// مساعد التحقق من المدخلات
    /// </summary>
    public static class ValidationHelper
    {
        // ============================================
        // التحقق من النصوص
        // ============================================

        /// <summary>
        /// هل النص فارغ؟
        /// </summary>
        public static bool IsEmpty(string text)
        {
            return string.IsNullOrWhiteSpace(text);
        }

        /// <summary>
        /// هل النص غير فارغ؟
        /// </summary>
        public static bool IsNotEmpty(string text)
        {
            return !string.IsNullOrWhiteSpace(text);
        }

        /// <summary>
        /// هل النص رقم؟
        /// </summary>
        public static bool IsNumber(string text)
        {
            if (IsEmpty(text)) return false;
            return decimal.TryParse(text, out _);
        }

        /// <summary>
        /// هل النص عدد صحيح؟
        /// </summary>
        public static bool IsInteger(string text)
        {
            if (IsEmpty(text)) return false;
            return int.TryParse(text, out _);
        }

        /// <summary>
        /// هل النص رقم موجب؟
        /// </summary>
        public static bool IsPositiveNumber(string text)
        {
            if (!IsNumber(text)) return false;
            return decimal.Parse(text) > 0;
        }

        // ============================================
        // التحقق من البريد الإلكتروني
        // ============================================

        /// <summary>
        /// هل البريد الإلكتروني صحيح؟
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            if (IsEmpty(email)) return false;

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // ============================================
        // التحقق من رقم الهاتف
        // ============================================

        /// <summary>
        /// هل رقم الهاتف صحيح؟
        /// </summary>
        public static bool IsValidPhone(string phone)
        {
            if (IsEmpty(phone)) return false;

            // يسمح بـ: أرقام، +، -، مسافات، أقواس
            return Regex.IsMatch(phone, @"^[\d\s\+\-\(\)]{7,20}$");
        }

        // ============================================
        // التحقق من الأطوال
        // ============================================

        /// <summary>
        /// هل الطول ضمن الحد المسموح؟
        /// </summary>
        public static bool IsValidLength(string text, int minLength, int maxLength)
        {
            if (text == null) return minLength == 0;
            return text.Length >= minLength && text.Length <= maxLength;
        }

        /// <summary>
        /// هل الطول لا يتجاوز الحد الأقصى؟
        /// </summary>
        public static bool IsWithinMaxLength(string text, int maxLength)
        {
            if (text == null) return true;
            return text.Length <= maxLength;
        }

        // ============================================
        // التحقق من الأرقام
        // ============================================

        /// <summary>
        /// هل الرقم ضمن النطاق؟
        /// </summary>
        public static bool IsInRange(decimal value, decimal min, decimal max)
        {
            return value >= min && value <= max;
        }

        /// <summary>
        /// هل الرقم موجب أو صفر؟
        /// </summary>
        public static bool IsNonNegative(decimal value)
        {
            return value >= 0;
        }

        // ============================================
        // التحقق من التاريخ
        // ============================================

        /// <summary>
        /// هل التاريخ صحيح؟
        /// </summary>
        public static bool IsValidDate(string dateText)
        {
            if (IsEmpty(dateText)) return false;
            return DateTime.TryParse(dateText, out _);
        }

        /// <summary>
        /// هل التاريخ في المستقبل؟
        /// </summary>
        public static bool IsFutureDate(DateTime date)
        {
            return date > DateTime.Now;
        }

        /// <summary>
        /// هل التاريخ في الماضي؟
        /// </summary>
        public static bool IsPastDate(DateTime date)
        {
            return date < DateTime.Now;
        }

        // ============================================
        // التحقق من الكود
        // ============================================

        /// <summary>
        /// هل الكود صحيح؟ (أحرف، أرقام، -، _)
        /// </summary>
        public static bool IsValidCode(string code)
        {
            if (IsEmpty(code)) return false;
            return Regex.IsMatch(code, @"^[A-Za-z0-9\-_]+$");
        }

        // ============================================
        // دوال مساعدة للرسائل
        // ============================================

        /// <summary>
        /// الحصول على رسالة خطأ للنص الفارغ
        /// </summary>
        public static string GetRequiredMessage(string fieldName)
        {
            return $"{fieldName} مطلوب";
        }

        /// <summary>
        /// الحصول على رسالة خطأ للطول
        /// </summary>
        public static string GetLengthMessage(string fieldName, int maxLength)
        {
            return $"{fieldName} طويل جداً (الحد الأقصى {maxLength} حرف)";
        }

        /// <summary>
        /// الحصول على رسالة خطأ للنطاق
        /// </summary>
        public static string GetRangeMessage(string fieldName, decimal min, decimal max)
        {
            return $"{fieldName} يجب أن يكون بين {min} و {max}";
        }
    }
}