using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace InventorySystem.UI.Helpers
{
    /// <summary>
    /// مساعد التصدير
    /// </summary>
    public static class ExportHelper
    {
        // ============================================
        // تصدير Excel
        // ============================================

        /// <summary>
        /// تصدير DataGridView إلى Excel (CSV)
        /// </summary>
        public static bool ExportToExcel(DataGridView grid, string fileName = null)
        {
            try
            {
                if (grid.Rows.Count == 0)
                {
                    MessageHelper.ShowWarning("لا توجد بيانات للتصدير");
                    return false;
                }

                // اختيار مكان الحفظ
                var saveDialog = new SaveFileDialog
                {
                    Filter = "Excel Files (*.csv)|*.csv|All Files (*.*)|*.*",
                    Title = "حفظ الملف",
                    FileName = fileName ?? $"Export_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
                };

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return false;

                // بناء المحتوى
                var sb = new StringBuilder();

                // الأعمدة
                bool firstColumn = true;
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    if (column.Visible)
                    {
                        if (!firstColumn) sb.Append(",");
                        sb.Append($"\"{column.HeaderText}\"");
                        firstColumn = false;
                    }
                }
                sb.AppendLine();

                // الصفوف
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.Visible) continue;

                    firstColumn = true;
                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        if (column.Visible)
                        {
                            if (!firstColumn) sb.Append(",");

                            var value = row.Cells[column.Name].Value;
                            var text = value?.ToString() ?? "";

                            // تجنب الفواصل
                            text = text.Replace("\"", "\"\"");
                            sb.Append($"\"{text}\"");

                            firstColumn = false;
                        }
                    }
                    sb.AppendLine();
                }

                // الحفظ (بـ UTF-8 مع BOM لدعم العربية في Excel)
                File.WriteAllText(saveDialog.FileName, sb.ToString(), new UTF8Encoding(true));

                MessageHelper.ShowSuccess("تم التصدير بنجاح");

                // فتح المجلد
                if (MessageHelper.Confirm("هل تريد فتح الملف؟"))
                {
                    System.Diagnostics.Process.Start(saveDialog.FileName);
                }

                return true;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "ExportHelper.ExportToExcel");
                MessageHelper.ShowError($"فشل في التصدير: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// تصدير DataTable إلى Excel
        /// </summary>
        public static bool ExportToExcel(DataTable dt, string fileName = null)
        {
            try
            {
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageHelper.ShowWarning("لا توجد بيانات للتصدير");
                    return false;
                }

                var saveDialog = new SaveFileDialog
                {
                    Filter = "Excel Files (*.csv)|*.csv|All Files (*.*)|*.*",
                    Title = "حفظ الملف",
                    FileName = fileName ?? $"Export_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
                };

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return false;

                var sb = new StringBuilder();

                // الأعمدة
                bool firstColumn = true;
                foreach (DataColumn column in dt.Columns)
                {
                    if (!firstColumn) sb.Append(",");
                    sb.Append($"\"{column.ColumnName}\"");
                    firstColumn = false;
                }
                sb.AppendLine();

                // الصفوف
                foreach (DataRow row in dt.Rows)
                {
                    firstColumn = true;
                    foreach (DataColumn column in dt.Columns)
                    {
                        if (!firstColumn) sb.Append(",");

                        var text = row[column]?.ToString() ?? "";
                        text = text.Replace("\"", "\"\"");
                        sb.Append($"\"{text}\"");

                        firstColumn = false;
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(saveDialog.FileName, sb.ToString(), new UTF8Encoding(true));

                MessageHelper.ShowSuccess("تم التصدير بنجاح");
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "ExportHelper.ExportToExcel(DataTable)");
                MessageHelper.ShowError($"فشل في التصدير: {ex.Message}");
                return false;
            }
        }

        // ============================================
        // تصدير CSV
        // ============================================

        /// <summary>
        /// تصدير DataGridView إلى CSV
        /// </summary>
        public static bool ExportToCSV(DataGridView grid)
        {
            try
            {
                if (grid.Rows.Count == 0)
                {
                    MessageHelper.ShowWarning("لا توجد بيانات للتصدير");
                    return false;
                }

                var saveDialog = new SaveFileDialog
                {
                    Filter = "CSV Files (*.csv)|*.csv",
                    Title = "حفظ الملف",
                    FileName = $"Export_{DateTime.Now:yyyyMMdd_HHmmss}.csv"
                };

                if (saveDialog.ShowDialog() != DialogResult.OK)
                    return false;

                var sb = new StringBuilder();

                // الأعمدة
                bool firstColumn = true;
                foreach (DataGridViewColumn column in grid.Columns)
                {
                    if (column.Visible)
                    {
                        if (!firstColumn) sb.Append(",");
                        sb.Append(column.HeaderText);
                        firstColumn = false;
                    }
                }
                sb.AppendLine();

                // الصفوف
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (!row.Visible) continue;

                    firstColumn = true;
                    foreach (DataGridViewColumn column in grid.Columns)
                    {
                        if (column.Visible)
                        {
                            if (!firstColumn) sb.Append(",");
                            sb.Append(row.Cells[column.Name].Value?.ToString() ?? "");
                            firstColumn = false;
                        }
                    }
                    sb.AppendLine();
                }

                File.WriteAllText(saveDialog.FileName, sb.ToString(), new UTF8Encoding(true));
                MessageHelper.ShowSuccess("تم التصدير بنجاح");
                return true;
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "ExportHelper.ExportToCSV");
                MessageHelper.ShowError($"فشل في التصدير: {ex.Message}");
                return false;
            }
        }

        // ============================================
        // طباعة
        // ============================================

        /// <summary>
        /// طباعة DataGridView
        /// </summary>
        public static void PrintGrid(DataGridView grid, string title = "تقرير")
        {
            try
            {
                if (grid.Rows.Count == 0)
                {
                    MessageHelper.ShowWarning("لا توجد بيانات للطباعة");
                    return;
                }

                var printDialog = new PrintDialog();
                var printDocument = new System.Drawing.Printing.PrintDocument();

                int currentRow = 0;
                int rowsPerPage = 25;

                printDocument.PrintPage += (sender, e) =>
                {
                    // الخطوط
                    var titleFont = new System.Drawing.Font("Arial", 16, System.Drawing.FontStyle.Bold);
                    var headerFont = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
                    var cellFont = new System.Drawing.Font("Arial", 10);

                    // الرأس
                    float yPos = 50;
                    e.Graphics.DrawString(title, titleFont, System.Drawing.Brushes.Black,
                        e.PageBounds.Width / 2 - 80, yPos);
                    yPos += 40;

                    // الأعمدة
                    var visibleColumns = new System.Collections.Generic.List<DataGridViewColumn>();
                    foreach (DataGridViewColumn col in grid.Columns)
                    {
                        if (col.Visible) visibleColumns.Add(col);
                    }

                    float xPos = 50;
                    float colWidth = (e.PageBounds.Width - 100) / visibleColumns.Count;

                    foreach (var col in visibleColumns)
                    {
                        e.Graphics.DrawString(col.HeaderText, headerFont,
                            System.Drawing.Brushes.Black, xPos, yPos);
                        xPos += colWidth;
                    }

                    yPos += 25;

                    // الصفوف
                    int rowCount = 0;
                    while (currentRow < grid.Rows.Count && rowCount < rowsPerPage)
                    {
                        var row = grid.Rows[currentRow];

                        if (row.Visible)
                        {
                            xPos = 50;

                            foreach (var col in visibleColumns)
                            {
                                var value = row.Cells[col.Name].Value?.ToString() ?? "";
                                e.Graphics.DrawString(value, cellFont,
                                    System.Drawing.Brushes.Black, xPos, yPos);
                                xPos += colWidth;
                            }

                            yPos += 25;
                            rowCount++;
                        }

                        currentRow++;
                    }

                    // هل هناك صفحات أخرى؟
                    e.HasMorePages = currentRow < grid.Rows.Count;
                };

                printDialog.Document = printDocument;

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                LogHelper.LogError(ex, "ExportHelper.PrintGrid");
                MessageHelper.ShowError($"فشل في الطباعة: {ex.Message}");
            }
        }
    }
}