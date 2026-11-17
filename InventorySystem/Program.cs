using InventorySystem.UI.Forms;
using System;
using System.Windows.Forms;

namespace InventorySystem.UI
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // إعدادات عامة
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // معالج الأخطاء العام
            Application.ThreadException += (sender, e) =>
            {
                Helpers.LogHelper.LogError(e.Exception, "Unhandled Thread Exception");
                Helpers.MessageHelper.ShowError($"حدث خطأ غير متوقع: {e.Exception.Message}");
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                var ex = e.ExceptionObject as Exception;
                Helpers.LogHelper.LogError(ex, "Unhandled Domain Exception");
            };

            // تشغيل التطبيق
            Application.Run(new frmLogin());
        }
    }
}