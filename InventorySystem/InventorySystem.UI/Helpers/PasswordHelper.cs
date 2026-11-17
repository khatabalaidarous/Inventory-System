using System;
using System.Security.Cryptography;
using System.Text;

namespace InventorySystem.UI.Helpers
{
    /// <summary>
    /// مساعد كلمات المرور
    /// يستخدم SHA256 للتشفير
    /// </summary>
    public static class PasswordHelper
    {
        // ============================================
        // تشفير كلمة المرور
        // ============================================

        /// <summary>
        /// تشفير كلمة المرور باستخدام SHA256
        /// </summary>
        /// <param name="password">كلمة المرور الأصلية</param>
        /// <returns>كلمة المرور المشفرة (64 حرف hex)</returns>
        public static string HashPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("كلمة المرور لا يمكن أن تكون فارغة");

            using (var sha256 = SHA256.Create())
            {
                // تحويل كلمة المرور إلى bytes
                var bytes = Encoding.UTF8.GetBytes(password);

                // التشفير
                var hash = sha256.ComputeHash(bytes);

                // تحويل إلى نص hex
                var sb = new StringBuilder();
                foreach (var b in hash)
                {
                    sb.Append(b.ToString("x2"));
                }

                return sb.ToString();
            }
        }

        // ============================================
        // التحقق من كلمة المرور
        // ============================================

        /// <summary>
        /// التحقق من تطابق كلمة المرور مع الهاش
        /// </summary>
        /// <param name="password">كلمة المرور المُدخلة</param>
        /// <param name="hash">الهاش المخزّن</param>
        /// <returns>true إذا كانت مطابقة</returns>
        public static bool VerifyPassword(string password, string hash)
        {
            if (string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(hash))
                return false;

            try
            {
                var inputHash = HashPassword(password);
                return string.Equals(inputHash, hash, StringComparison.OrdinalIgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        // ============================================
        // توليد كلمة مرور عشوائية
        // ============================================

        /// <summary>
        /// توليد كلمة مرور عشوائية قوية
        /// </summary>
        /// <param name="length">طول كلمة المرور (افتراضي 8)</param>
        public static string GenerateRandomPassword(int length = 8)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%";
            var res = new StringBuilder();
            using (var rng = new RNGCryptoServiceProvider())
            {
                var uintBuffer = new byte[sizeof(uint)];

                while (length-- > 0)
                {
                    rng.GetBytes(uintBuffer);
                    uint num = BitConverter.ToUInt32(uintBuffer, 0);
                    res.Append(validChars[(int)(num % (uint)validChars.Length)]);
                }
            }

            return res.ToString();
        }

        // ============================================
        // قوة كلمة المرور
        // ============================================

        /// <summary>
        /// تقييم قوة كلمة المرور
        /// </summary>
        /// <returns>0-4 (0 = ضعيفة جداً، 4 = قوية جداً)</returns>
        public static int GetPasswordStrength(string password)
        {
            if (string.IsNullOrWhiteSpace(password)) return 0;

            int score = 0;

            if (password.Length >= 8) score++;
            if (password.Length >= 12) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[a-z]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[A-Z]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[0-9]")) score++;
            if (System.Text.RegularExpressions.Regex.IsMatch(password, @"[^a-zA-Z0-9]")) score++;

            // تحويل إلى 0-4
            if (score <= 2) return 0;
            if (score <= 3) return 1;
            if (score <= 4) return 2;
            if (score <= 5) return 3;
            return 4;
        }

        /// <summary>
        /// وصف قوة كلمة المرور بالعربية
        /// </summary>
        public static string GetPasswordStrengthText(string password)
        {
            switch (GetPasswordStrength(password))
            {
                case 0: return "ضعيفة جداً";
                case 1: return "ضعيفة";
                case 2: return "متوسطة";
                case 3: return "قوية";
                case 4: return "قوية جداً";
                default: return "غير معروفة";
            }
        }
    }
}