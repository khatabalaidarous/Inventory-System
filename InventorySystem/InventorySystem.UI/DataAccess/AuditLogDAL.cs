using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات سجل التدقيق
    /// </summary>
    public class AuditLogDAL
    {
        /// <summary>
        /// الحصول على كل السجلات
        /// </summary>
        public List<AuditLog> GetAll(int top = 500)
        {
            var list = new List<AuditLog>();

            string query = $@"
                SELECT TOP {top} a.*, u.FullName AS UserName
                FROM AuditLog a
                LEFT JOIN Users u ON a.UserId = u.UserId
                ORDER BY a.LogDate DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// سجلات مستخدم معين
        /// </summary>
        public List<AuditLog> GetByUser(int userId)
        {
            var list = new List<AuditLog>();

            string query = @"
                SELECT a.*, u.FullName AS UserName
                FROM AuditLog a
                LEFT JOIN Users u ON a.UserId = u.UserId
                WHERE a.UserId = @UserId
                ORDER BY a.LogDate DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@UserId", userId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// سجلات جدول معين
        /// </summary>
        public List<AuditLog> GetByTable(string tableName)
        {
            var list = new List<AuditLog>();

            string query = @"
                SELECT a.*, u.FullName AS UserName
                FROM AuditLog a
                LEFT JOIN Users u ON a.UserId = u.UserId
                WHERE a.TableName = @TableName
                ORDER BY a.LogDate DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@TableName", tableName));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// سجلات فترة زمنية
        /// </summary>
        public List<AuditLog> GetByDateRange(DateTime fromDate, DateTime toDate)
        {
            var list = new List<AuditLog>();

            string query = @"
                SELECT a.*, u.FullName AS UserName
                FROM AuditLog a
                LEFT JOIN Users u ON a.UserId = u.UserId
                WHERE a.LogDate >= @FromDate AND a.LogDate <= @ToDate
                ORDER BY a.LogDate DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@FromDate", fromDate),
                DatabaseHelper.Param("@ToDate", toDate));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// إضافة سجل
        /// </summary>
        public long Add(AuditLog log)
        {
            string query = @"
                INSERT INTO AuditLog (UserId, Action, TableName, RecordId, OldValue, NewValue, LogDate)
                VALUES (@UserId, @Action, @TableName, @RecordId, @OldValue, @NewValue, @LogDate);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@UserId", (object)log.UserId ?? DBNull.Value),
                DatabaseHelper.Param("@Action", log.Action),
                DatabaseHelper.Param("@TableName", log.TableName),
                DatabaseHelper.Param("@RecordId", (object)log.RecordId ?? DBNull.Value),
                DatabaseHelper.Param("@OldValue", (object)log.OldValue ?? DBNull.Value),
                DatabaseHelper.Param("@NewValue", (object)log.NewValue ?? DBNull.Value),
                DatabaseHelper.Param("@LogDate", log.LogDate));

            return Convert.ToInt64(result);
        }

        /// <summary>
        /// حذف سجلات قديمة
        /// </summary>
        public int DeleteOldLogs(int daysOld = 90)
        {
            string query = @"
                DELETE FROM AuditLog
                WHERE LogDate < DATEADD(DAY, -@DaysOld, GETDATE())";

            return DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@DaysOld", daysOld));
        }

        private AuditLog MapToEntity(DataRow row)
        {
            return new AuditLog
            {
                LogId = DatabaseHelper.GetValue<long>(row, "LogId"),
                UserId = row["UserId"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["UserId"]),
                Action = DatabaseHelper.GetValue<string>(row, "Action"),
                TableName = DatabaseHelper.GetValue<string>(row, "TableName"),
                RecordId = row["RecordId"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["RecordId"]),
                OldValue = row["OldValue"] == DBNull.Value ? null : row["OldValue"].ToString(),
                NewValue = row["NewValue"] == DBNull.Value ? null : row["NewValue"].ToString(),
                LogDate = DatabaseHelper.GetValue<DateTime>(row, "LogDate"),
                UserName = row.Table.Columns.Contains("UserName") && row["UserName"] != DBNull.Value
                    ? row["UserName"].ToString() : null
            };
        }
    }
}