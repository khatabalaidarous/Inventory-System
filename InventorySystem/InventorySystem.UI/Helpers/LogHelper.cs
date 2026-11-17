using System;
using System.IO;
using System.Text;

namespace InventorySystem.UI.Helpers
{
    /// <summary>
    /// مساعد تسجيل الأخطاء والأحداث
    /// </summary>
    public static class LogHelper
    {
        // ============================================
        // مسارات الملفات
        // ============================================

        /// <summary>
        /// مجلد السجلات
        /// </summary>
        private static string LogFolder
        {
            get
            {
                string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                return folder;
            }
        }

        /// <summary>
        /// مسار ملف الأخطاء
        /// </summary>
        private static string ErrorLogPath
        {
            get
            {
                string fileName = $"Errors_{DateTime.Now:yyyy-MM-dd}.log";
                return Path.Combine(LogFolder, fileName);
            }
        }

        /// <summary>
        /// مسار ملف الأحداث
        /// </summary>
        private static string InfoLogPath
        {
            get
            {
                string fileName = $"Log_{DateTime.Now:yyyy-MM-dd}.log";
                return Path.Combine(LogFolder, fileName);
            }
        }

        // ============================================
        // تسجيل الأخطاء
        // ============================================

        /// <summary>
        /// تسجيل خطأ
        /// </summary>
        public static void LogError(Exception ex, string additionalInfo = null)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("═══════════════════════════════════════");
                sb.AppendLine($"التاريخ: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");

                if (!string.IsNullOrEmpty(additionalInfo))
                    sb.AppendLine($"معلومة إضافية: {additionalInfo}");

                sb.AppendLine($"نوع الخطأ: {ex.GetType().Name}");
                sb.AppendLine($"الرسالة: {ex.Message}");

                if (ex.InnerException != null)
                    sb.AppendLine($"الخطأ الداخلي: {ex.InnerException.Message}");

                sb.AppendLine($"المسار: {ex.StackTrace}");
                sb.AppendLine("═══════════════════════════════════════");
                sb.AppendLine();

                File.AppendAllText(ErrorLogPath, sb.ToString(), Encoding.UTF8);
            }
            catch
            {
                // تجاهل أي خطأ في التسجيل
            }
        }

        /// <summary>
        /// تسجيل خطأ برسالة
        /// </summary>
        public static void LogError(string message)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine("═══════════════════════════════════════");
                sb.AppendLine($"التاريخ: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                sb.AppendLine($"الرسالة: {message}");
                sb.AppendLine("═══════════════════════════════════════");
                sb.AppendLine();

                File.AppendAllText(ErrorLogPath, sb.ToString(), Encoding.UTF8);
            }
            catch
            {
                // تجاهل
            }
        }

        // ============================================
        // تسجيل الأحداث
        // ============================================

        /// <summary>
        /// تسجيل حدث
        /// </summary>
        public static void LogInfo(string message)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");

                File.AppendAllText(InfoLogPath, sb.ToString(), Encoding.UTF8);
            }
            catch
            {
                // تجاهل
            }
        }

        /// <summary>
        /// تسجيل عملية
        /// </summary>
        public static void LogAction(string action, string userName = null, string details = null)
        {
            try
            {
                var sb = new StringBuilder();
                sb.AppendLine($"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}]");
                sb.AppendLine($"  العملية: {action}");

                if (!string.IsNullOrEmpty(userName))
                    sb.AppendLine($"  المستخدم: {userName}");

                if (!string.IsNullOrEmpty(details))
                    sb.AppendLine($"  التفاصيل: {details}");

                sb.AppendLine();

                File.AppendAllText(InfoLogPath, sb.ToString(), Encoding.UTF8);
            }
            catch
            {
                // تجاهل
            }
        }

        // ============================================
        // قراءة السجلات
        // ============================================

        /// <summary>
        /// قراءة ملف الأخطاء لليوم
        /// </summary>
        public static string ReadTodayErrors()
        {
            try
            {
                if (File.Exists(ErrorLogPath))
                    return File.ReadAllText(ErrorLogPath, Encoding.UTF8);

                return "لا توجد أخطاء اليوم";
            }
            catch (Exception ex)
            {
                return $"فشل في قراءة السجل: {ex.Message}";
            }
        }

        /// <summary>
        /// قراءة ملف الأحداث لليوم
        /// </summary>
        public static string ReadTodayLog()
        {
            try
            {
                if (File.Exists(InfoLogPath))
                    return File.ReadAllText(InfoLogPath, Encoding.UTF8);

                return "لا توجد أحداث اليوم";
            }
            catch (Exception ex)
            {
                return $"فشل في قراءة السجل: {ex.Message}";
            }
        }

        // ============================================
        // إدارة السجلات
        // ============================================

        /// <summary>
        /// حذف السجلات القديمة (أكثر من X يوم)
        /// </summary>
        public static int CleanOldLogs(int daysOld = 30)
        {
            try
            {
                int deletedCount = 0;
                var cutoffDate = DateTime.Now.AddDays(-daysOld);

                foreach (var file in Directory.GetFiles(LogFolder))
                {
                    var fileInfo = new FileInfo(file);

                    if (fileInfo.CreationTime < cutoffDate)
                    {
                        File.Delete(file);
                        deletedCount++;
                    }
                }

                return deletedCount;
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// مسار مجلد السجلات
        /// </summary>
        public static string GetLogFolderPath()
        {
            return LogFolder;
        }
    }
}