using System.Windows.Forms;

namespace InventorySystem.UI.Helpers
{
    /// <summary>
    /// مساعد عرض الرسائل
    /// </summary>
    public static class MessageHelper
    {
        // ============================================
        // رسائل النجاح
        // ============================================

        /// <summary>
        /// عرض رسالة نجاح
        /// </summary>
        public static void ShowSuccess(string message = "تمت العملية بنجاح")
        {
            MessageBox.Show(message, "نجاح",
                MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        // ============================================
        // رسائل الخطأ
        // ============================================

        /// <summary>
        /// عرض رسالة خطأ
        /// </summary>
        public static void ShowError(string message = "حدث خطأ")
        {
            MessageBox.Show(message, "خطأ",
                MessageBoxButtons.OK, MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        // ============================================
        // رسائل التحذير
        // ============================================

        /// <summary>
        /// عرض رسالة تحذير
        /// </summary>
        public static void ShowWarning(string message = "تحذير")
        {
            MessageBox.Show(message, "تحذير",
                MessageBoxButtons.OK, MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        // ============================================
        // رسائل المعلومة
        // ============================================

        /// <summary>
        /// عرض رسالة معلومة
        /// </summary>
        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "معلومة",
                MessageBoxButtons.OK, MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
        }

        // ============================================
        // رسائل التأكيد
        // ============================================

        /// <summary>
        /// عرض رسالة تأكيد (نعم/لا)
        /// </summary>
        public static bool Confirm(string message = "هل أنت متأكد؟")
        {
            var result = MessageBox.Show(message, "تأكيد",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2,
                MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

            return result == DialogResult.Yes;
        }

        /// <summary>
        /// تأكيد الحذف
        /// </summary>
        public static bool ConfirmDelete(string itemName = "العنصر")
        {
            return Confirm($"هل أنت متأكد من حذف {itemName}؟");
        }

        /// <summary>
        /// تأكيد الحفظ
        /// </summary>
        public static bool ConfirmSave()
        {
            return Confirm("هل تريد حفظ التغييرات؟");
        }

        /// <summary>
        /// تأكيد الخروج
        /// </summary>
        public static bool ConfirmExit()
        {
            return Confirm("هل أنت متأكد من الخروج؟");
        }

        /// <summary>
        /// تأكيد تسجيل الخروج
        /// </summary>
        public static bool ConfirmLogout()
        {
            return Confirm("هل أنت متأكد من تسجيل الخروج؟");
        }

        // ============================================
        // رسائل مخصصة
        // ============================================

        /// <summary>
        /// عرض رسالة نجاح الحفظ
        /// </summary>
        public static void ShowSaveSuccess()
        {
            ShowSuccess("تم الحفظ بنجاح ✅");
        }

        /// <summary>
        /// عرض رسالة نجاح التعديل
        /// </summary>
        public static void ShowUpdateSuccess()
        {
            ShowSuccess("تم التعديل بنجاح ✅");
        }

        /// <summary>
        /// عرض رسالة نجاح الحذف
        /// </summary>
        public static void ShowDeleteSuccess()
        {
            ShowSuccess("تم الحذف بنجاح ✅");
        }

        /// <summary>
        /// عرض رسالة فشل
        /// </summary>
        public static void ShowFailure(string message)
        {
            ShowError(message);
        }

        // ============================================
        // رسائل التحقق من المدخلات
        // ============================================

        /// <summary>
        /// عرض رسالة حقل مطلوب
        /// </summary>
        public static void ShowRequiredField(string fieldName)
        {
            ShowWarning($"{fieldName} مطلوب");
        }

        /// <summary>
        /// عرض رسالة اختيار عنصر
        /// </summary>
        public static void ShowSelectItem()
        {
            ShowWarning("يجب اختيار عنصر أولاً");
        }

        // ============================================
        // رسائل البيانات
        // ============================================

        /// <summary>
        /// لا توجد بيانات
        /// </summary>
        public static void ShowNoData()
        {
            ShowInfo("لا توجد بيانات للعرض");
        }

        /// <summary>
        /// لا توجد صلاحية
        /// </summary>
        public static void ShowNoPermission()
        {
            ShowWarning("ليس لديك صلاحية للقيام بهذا الإجراء");
        }

        // ============================================
        // Exception Helper
        // ============================================

        /// <summary>
        /// عرض رسالة خطأ من Exception
        /// </summary>
        public static void ShowException(System.Exception ex)
        {
            ShowError($"حدث خطأ: {ex.Message}");
        }
    }
}