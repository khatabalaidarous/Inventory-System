using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات حركات المخزون
    /// </summary>
    public class StockMovementDAL
    {
        /// <summary>
        /// الحصول على كل الحركات
        /// </summary>
        public List<StockMovement> GetAll()
        {
            var list = new List<StockMovement>();

            string query = @"
                SELECT m.*, 
                       u.FullName AS UserName,
                       fw.Name AS FromWarehouseName,
                       tw.Name AS ToWarehouseName,
                       p.Name AS PartnerName
                FROM StockMovements m
                INNER JOIN Users u ON m.UserId = u.UserId
                LEFT JOIN Warehouses fw ON m.FromWarehouseId = fw.WarehouseId
                LEFT JOIN Warehouses tw ON m.ToWarehouseId = tw.WarehouseId
                LEFT JOIN Partners p ON m.PartnerId = p.PartnerId
                ORDER BY m.MovementDate DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على الحركات حسب النوع
        /// </summary>
        public List<StockMovement> GetByType(string type)
        {
            var list = new List<StockMovement>();

            string query = @"
                SELECT m.*, 
                       u.FullName AS UserName,
                       fw.Name AS FromWarehouseName,
                       tw.Name AS ToWarehouseName,
                       p.Name AS PartnerName
                FROM StockMovements m
                INNER JOIN Users u ON m.UserId = u.UserId
                LEFT JOIN Warehouses fw ON m.FromWarehouseId = fw.WarehouseId
                LEFT JOIN Warehouses tw ON m.ToWarehouseId = tw.WarehouseId
                LEFT JOIN Partners p ON m.PartnerId = p.PartnerId
                WHERE m.Type = @Type
                ORDER BY m.MovementDate DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@Type", type));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحركات في فترة زمنية
        /// </summary>
        public List<StockMovement> GetByDateRange(DateTime fromDate, DateTime toDate)
        {
            var list = new List<StockMovement>();

            string query = @"
                SELECT m.*, 
                       u.FullName AS UserName,
                       fw.Name AS FromWarehouseName,
                       tw.Name AS ToWarehouseName,
                       p.Name AS PartnerName
                FROM StockMovements m
                INNER JOIN Users u ON m.UserId = u.UserId
                LEFT JOIN Warehouses fw ON m.FromWarehouseId = fw.WarehouseId
                LEFT JOIN Warehouses tw ON m.ToWarehouseId = tw.WarehouseId
                LEFT JOIN Partners p ON m.PartnerId = p.PartnerId
                WHERE m.MovementDate >= @FromDate AND m.MovementDate <= @ToDate
                ORDER BY m.MovementDate DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@FromDate", fromDate),
                DatabaseHelper.Param("@ToDate", toDate));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على حركة بواسطة المعرف
        /// </summary>
        public StockMovement GetById(int movementId)
        {
            string query = @"
                SELECT m.*, 
                       u.FullName AS UserName,
                       fw.Name AS FromWarehouseName,
                       tw.Name AS ToWarehouseName,
                       p.Name AS PartnerName
                FROM StockMovements m
                INNER JOIN Users u ON m.UserId = u.UserId
                LEFT JOIN Warehouses fw ON m.FromWarehouseId = fw.WarehouseId
                LEFT JOIN Warehouses tw ON m.ToWarehouseId = tw.WarehouseId
                LEFT JOIN Partners p ON m.PartnerId = p.PartnerId
                WHERE m.MovementId = @MovementId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@MovementId", movementId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// إضافة حركة
        /// </summary>
        public int Add(StockMovement movement)
        {
            string query = @"
                INSERT INTO StockMovements 
                    (Type, MovementDate, UserId, FromWarehouseId, ToWarehouseId, PartnerId, Reference, Notes)
                VALUES 
                    (@Type, @MovementDate, @UserId, @FromWarehouseId, @ToWarehouseId, @PartnerId, @Reference, @Notes);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@Type", movement.Type),
                DatabaseHelper.Param("@MovementDate", movement.MovementDate),
                DatabaseHelper.Param("@UserId", movement.UserId),
                DatabaseHelper.Param("@FromWarehouseId", (object)movement.FromWarehouseId ?? DBNull.Value),
                DatabaseHelper.Param("@ToWarehouseId", (object)movement.ToWarehouseId ?? DBNull.Value),
                DatabaseHelper.Param("@PartnerId", (object)movement.PartnerId ?? DBNull.Value),
                DatabaseHelper.Param("@Reference", (object)movement.Reference ?? DBNull.Value),
                DatabaseHelper.Param("@Notes", (object)movement.Notes ?? DBNull.Value));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// حذف حركة
        /// </summary>
        public bool Delete(int movementId)
        {
            string query = "DELETE FROM StockMovements WHERE MovementId = @MovementId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@MovementId", movementId));

            return rows > 0;
        }

        /// <summary>
        /// عدد الحركات اليوم
        /// </summary>
        public int GetTodayCount()
        {
            string query = @"
                SELECT COUNT(*) FROM StockMovements
                WHERE CAST(MovementDate AS DATE) = CAST(GETDATE() AS DATE)";

            return DatabaseHelper.ExecuteScalar<int>(query);
        }

        private StockMovement MapToEntity(DataRow row)
        {
            return new StockMovement
            {
                MovementId = DatabaseHelper.GetValue<int>(row, "MovementId"),
                Type = DatabaseHelper.GetValue<string>(row, "Type"),
                MovementDate = DatabaseHelper.GetValue<DateTime>(row, "MovementDate"),
                UserId = DatabaseHelper.GetValue<int>(row, "UserId"),
                FromWarehouseId = row["FromWarehouseId"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["FromWarehouseId"]),
                ToWarehouseId = row["ToWarehouseId"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["ToWarehouseId"]),
                PartnerId = row["PartnerId"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["PartnerId"]),
                Reference = row["Reference"] == DBNull.Value ? null : row["Reference"].ToString(),
                Notes = row["Notes"] == DBNull.Value ? null : row["Notes"].ToString(),
                UserName = row.Table.Columns.Contains("UserName")
                    ? DatabaseHelper.GetValue<string>(row, "UserName") : null,
                FromWarehouseName = row.Table.Columns.Contains("FromWarehouseName")
                    ? DatabaseHelper.GetValue<string>(row, "FromWarehouseName") : null,
                ToWarehouseName = row.Table.Columns.Contains("ToWarehouseName")
                    ? DatabaseHelper.GetValue<string>(row, "ToWarehouseName") : null,
                PartnerName = row.Table.Columns.Contains("PartnerName")
                    ? DatabaseHelper.GetValue<string>(row, "PartnerName") : null
            };
        }
    }
}