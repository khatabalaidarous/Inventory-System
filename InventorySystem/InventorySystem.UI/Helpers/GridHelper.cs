using System;
using System.Drawing;
using System.Windows.Forms;
using InventorySystem.InventorySystem.UI.Forms;

namespace InventorySystem.UI.Helpers
{
    /// <summary>
    /// مساعد تنسيق DataGridView
    /// </summary>
    public static class GridHelper
    {
        // ============================================
        // التنسيق العام
        // ============================================

        /// <summary>
        /// تنسيق DataGridView بشكل احترافي
        /// </summary>
        public static void StyleGrid(DataGridView grid)
        {
            // الألوان
            grid.BackgroundColor = Color.White;
            grid.GridColor = Color.FromArgb(230, 230, 230);

            // الرأس
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 128, 185);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.ColumnHeadersHeight = 40;
            grid.EnableHeadersVisualStyles = false;

            // الخلايا
            grid.DefaultCellStyle.BackColor = Color.White;
            grid.DefaultCellStyle.ForeColor = Color.Black;
            grid.DefaultCellStyle.Font = new Font("Arial", 9F);
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // الصفوف
            grid.RowTemplate.Height = 30;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245);

            // السلوك
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToResizeRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowHeadersVisible = false;

            // RTL
            grid.RightToLeft = RightToLeft.Yes;
        }

        // ============================================
        // إخفاء الأعمدة
        // ============================================

        /// <summary>
        /// إخفاء عمود
        /// </summary>
        public static void HideColumn(DataGridView grid, string columnName)
        {
            if (grid.Columns.Contains(columnName))
                grid.Columns[columnName].Visible = false;
        }

        /// <summary>
        /// إخفاء عدة أعمدة
        /// </summary>
        public static void HideColumns(DataGridView grid, params string[] columnNames)
        {
            foreach (var name in columnNames)
                HideColumn(grid, name);
        }

        // ============================================
        // تنسيق الأعمدة
        // ============================================

        /// <summary>
        /// تعيين عنوان عمود
        /// </summary>
        public static void SetColumnHeader(DataGridView grid, string columnName, string headerText)
        {
            if (grid.Columns.Contains(columnName))
                grid.Columns[columnName].HeaderText = headerText;
        }

        /// <summary>
        /// تعيين عرض عمود
        /// </summary>
        public static void SetColumnWidth(DataGridView grid, string columnName, int width)
        {
            if (grid.Columns.Contains(columnName))
            {
                grid.Columns[columnName].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                grid.Columns[columnName].Width = width;
            }
        }

        /// <summary>
        /// تنسيق عمود كمبلغ
        /// </summary>
        public static void FormatAsCurrency(DataGridView grid, string columnName)
        {
            if (grid.Columns.Contains(columnName))
                grid.Columns[columnName].DefaultCellStyle.Format = "N2";
        }

        /// <summary>
        /// تنسيق عمود كتاريخ
        /// </summary>
        public static void FormatAsDate(DataGridView grid, string columnName)
        {
            if (grid.Columns.Contains(columnName))
                grid.Columns[columnName].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        /// <summary>
        /// تنسيق عمود كتاريخ ووقت
        /// </summary>
        public static void FormatAsDateTime(DataGridView grid, string columnName)
        {
            if (grid.Columns.Contains(columnName))
                grid.Columns[columnName].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        // ============================================
        // التلوين الشرطي
        // ============================================

        /// <summary>
        /// تلوين الصفوف حسب عمود
        /// </summary>
        public static void ColorRowsByValue(DataGridView grid, string columnName,
            Func<object, Color> colorSelector)
        {
            grid.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex < 0) return;

                if (grid.Columns.Contains(columnName))
                {
                    var value = grid.Rows[e.RowIndex].Cells[columnName].Value;
                    var color = colorSelector(value);

                    if (color != Color.Empty)
                    {
                        e.CellStyle.BackColor = color;
                    }
                }
            };
        }

        /// <summary>
        /// تلوين الصف حسب حالة التفعيل
        /// </summary>
        public static void ColorByActiveStatus(DataGridView grid, string activeColumnName)
        {
            ColorRowsByValue(grid, activeColumnName, (value) =>
            {
                if (value is bool isActive)
                    return isActive ? Color.White : Color.FromArgb(255, 235, 235);

                return Color.White;
            });
        }

        // ============================================
        // الصف المحدد
        // ============================================

        /// <summary>
        /// الحصول على قيمة من الصف المحدد
        /// </summary>
        public static T GetSelectedValue<T>(DataGridView grid, string columnName)
        {
            if (grid.CurrentRow == null) return default(T);
            if (!grid.Columns.Contains(columnName)) return default(T);

            var value = grid.CurrentRow.Cells[columnName].Value;

            if (value == null || value == DBNull.Value) return default(T);

            try
            {
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch
            {
                return default(T);
            }
        }

        /// <summary>
        /// الحصول على معرف الصف المحدد
        /// </summary>
        public static int GetSelectedId(DataGridView grid, string idColumnName = "Id")
        {
            return GetSelectedValue<int>(grid, idColumnName);
        }

        // ============================================
        // البحث
        // ============================================

        /// <summary>
        /// تصفية الصفوف حسب النص
        /// </summary>
        public static void FilterRows(DataGridView grid, string keyword)
        {
            if (string.IsNullOrWhiteSpace(keyword))
            {
                foreach (DataGridViewRow row in grid.Rows)
                    row.Visible = true;
                return;
            }

            foreach (DataGridViewRow row in grid.Rows)
            {
                bool visible = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null &&
                        cell.Value.ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        visible = true;
                        break;
                    }
                }

                row.Visible = visible;
            }
        }

        // ============================================
        // الإحصائيات
        // ============================================

        /// <summary>
        /// عدد الصفوف الظاهرة
        /// </summary>
        public static int GetVisibleRowCount(DataGridView grid)
        {
            int count = 0;

            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.Visible) count++;
            }

            return count;
        }

        // ============================================
        // التصدير (للاستخدام مع ExportHelper)
        // ============================================

        /// <summary>
        /// تحويل DataGridView إلى DataTable
        /// </summary>
        public static System.Data.DataTable ToDataTable(DataGridView grid)
        {
            var dt = new System.Data.DataTable();

            // الأعمدة
            foreach (DataGridViewColumn column in grid.Columns)
            {
                if (column.Visible)
                    dt.Columns.Add(column.HeaderText);
            }

            // الصفوف
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (!row.Visible) continue;

                var dataRow = dt.NewRow();
                int colIndex = 0;

                foreach (DataGridViewColumn column in grid.Columns)
                {
                    if (column.Visible)
                    {
                        dataRow[colIndex] = row.Cells[column.Name].Value ?? DBNull.Value;
                        colIndex++;
                    }
                }

                dt.Rows.Add(dataRow);
            }

            return dt;
        }
    }
}