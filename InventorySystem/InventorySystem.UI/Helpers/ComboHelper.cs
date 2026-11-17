using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace InventorySystem.UI.Helpers
{
    /// <summary>
    /// مساعد تحميل ComboBox
    /// </summary>
    public static class ComboHelper
    {
        // ============================================
        // التحميل من DataTable
        // ============================================

        /// <summary>
        /// تحميل ComboBox من DataTable
        /// </summary>
        /// <param name="combo">ComboBox</param>
        /// <param name="dt">DataTable</param>
        /// <param name="valueMember">عمود القيمة</param>
        /// <param name="displayMember">عمود العرض</param>
        public static void LoadFromDataTable(ComboBox combo, DataTable dt,
            string valueMember, string displayMember)
        {
            combo.DataSource = null;
            combo.Items.Clear();

            if (dt != null && dt.Rows.Count > 0)
            {
                combo.DataSource = dt;
                combo.ValueMember = valueMember;
                combo.DisplayMember = displayMember;
            }

            combo.SelectedIndex = -1;
        }

        // ============================================
        // التحميل من List
        // ============================================

        /// <summary>
        /// تحميل ComboBox من قائمة كائنات
        /// </summary>
        public static void LoadFromList<T>(ComboBox combo, List<T> list,
            string valueMember, string displayMember)
        {
            combo.DataSource = null;
            combo.Items.Clear();

            if (list != null && list.Count > 0)
            {
                combo.DataSource = list;
                combo.ValueMember = valueMember;
                combo.DisplayMember = displayMember;
            }

            combo.SelectedIndex = -1;
        }

        /// <summary>
        /// تحميل ComboBox من قائمة بسيطة
        /// </summary>
        public static void LoadSimple<T>(ComboBox combo, List<T> list)
        {
            combo.DataSource = null;
            combo.Items.Clear();

            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                    combo.Items.Add(item);
                }
            }

            combo.SelectedIndex = -1;
        }

        // ============================================
        // إضافة عنصر
        // ============================================

        /// <summary>
        /// إضافة عنصر افتراضي "اختر..."
        /// </summary>
        public static void AddDefaultItem(ComboBox combo, string text = "— اختر —")
        {
            var dt = combo.DataSource as DataTable;

            if (dt != null)
            {
                var newRow = dt.NewRow();
                newRow[combo.ValueMember] = 0;
                newRow[combo.DisplayMember] = text;
                dt.Rows.InsertAt(newRow, 0);
            }
        }

        // ============================================
        // القيم المحددة
        // ============================================

        /// <summary>
        /// الحصول على معرف العنصر المحدد
        /// </summary>
        public static int GetSelectedId(ComboBox combo)
        {
            if (combo.SelectedValue == null) return 0;

            if (combo.SelectedValue is int)
                return (int)combo.SelectedValue;

            return 0;
        }

        /// <summary>
        /// الحصول على معرف العنصر المحدد (مع nullable)
        /// </summary>
        public static int? GetSelectedIdNullable(ComboBox combo)
        {
            if (combo.SelectedValue == null) return null;
            if (combo.SelectedIndex < 0) return null;

            if (combo.SelectedValue is int)
            {
                int id = (int)combo.SelectedValue;
                return id > 0 ? (int?)id : null;
            }

            return null;
        }

        /// <summary>
        /// الحصول على نص العنصر المحدد
        /// </summary>
        public static string GetSelectedText(ComboBox combo)
        {
            return combo.SelectedItem?.ToString() ?? string.Empty;
        }

        /// <summary>
        /// الحصول على العنصر المحدد
        /// </summary>
        public static T GetSelectedItem<T>(ComboBox combo) where T : class
        {
            return combo.SelectedItem as T;
        }

        // ============================================
        // التحديد
        // ============================================

        /// <summary>
        /// تحديد عنصر بواسطة المعرف
        /// </summary>
        public static bool SelectById(ComboBox combo, int id)
        {
            if (combo.DataSource == null) return false;

            for (int i = 0; i < combo.Items.Count; i++)
            {
                combo.SelectedIndex = i;

                if (combo.SelectedValue is int && (int)combo.SelectedValue == id)
                    return true;
            }

            combo.SelectedIndex = -1;
            return false;
        }

        /// <summary>
        /// تحديد عنصر بواسطة النص
        /// </summary>
        public static bool SelectByText(ComboBox combo, string text)
        {
            if (combo.DataSource == null) return false;

            for (int i = 0; i < combo.Items.Count; i++)
            {
                combo.SelectedIndex = i;

                if (combo.Text == text)
                    return true;
            }

            combo.SelectedIndex = -1;
            return false;
        }

        // ============================================
        // القوائم الثابتة
        // ============================================

        /// <summary>
        /// تحميل أنواع الشركاء
        /// </summary>
        public static void LoadPartnerTypes(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add(new { Value = "Supplier", Text = "مورد" });
            combo.Items.Add(new { Value = "Customer", Text = "عميل" });
            combo.Items.Add(new { Value = "Both", Text = "مورد وعميل" });

            combo.DisplayMember = "Text";
            combo.ValueMember = "Value";
        }

        /// <summary>
        /// تحميل أنواع الحركات
        /// </summary>
        public static void LoadMovementTypes(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add(new { Value = "IN", Text = "استلام" });
            combo.Items.Add(new { Value = "OUT", Text = "صرف" });
            combo.Items.Add(new { Value = "TRANSFER", Text = "تحويل" });
            combo.Items.Add(new { Value = "ADJUST", Text = "تسوية" });

            combo.DisplayMember = "Text";
            combo.ValueMember = "Value";
        }

        /// <summary>
        /// تحميل حالات الجرد
        /// </summary>
        public static void LoadStocktakeStatus(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add(new { Value = "Open", Text = "مفتوح" });
            combo.Items.Add(new { Value = "Closed", Text = "مغلق" });

            combo.DisplayMember = "Text";
            combo.ValueMember = "Value";
        }

        /// <summary>
        /// تحميل حالات التفعيل
        /// </summary>
        public static void LoadActiveStatus(ComboBox combo)
        {
            combo.Items.Clear();
            combo.Items.Add(new { Value = true, Text = "مفعّل" });
            combo.Items.Add(new { Value = false, Text = "معطّل" });

            combo.DisplayMember = "Text";
            combo.ValueMember = "Value";
        }
    }
}