using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات الجرد
    /// </summary>
    public class StocktakeDAL
    {
        /// <summary>
        /// الحصول على كل عمليات الجرد
        /// </summary>
        public List<Stocktake> GetAll()
        {
            var list = new List<Stocktake>();

            string query = @"
                SELECT s.*, w.Name AS WarehouseName, u.FullName AS CreatorName
                FROM Stocktakes s
                INNER JOIN Warehouses w ON s.WarehouseId = w.WarehouseId
                INNER JOIN Users u ON s.CreatedBy = u.UserId
                ORDER BY s.StocktakeDate DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// جرد مستودع معين
        /// </summary>
        public List<Stocktake> GetByWarehouse(int warehouseId)
        {
            var list = new List<Stocktake>();

            string query = @"
                SELECT s.*, w.Name AS WarehouseName, u.FullName AS CreatorName
                FROM Stocktakes s
                INNER JOIN Warehouses w ON s.WarehouseId = w.WarehouseId
                INNER JOIN Users u ON s.CreatedBy = u.UserId
                WHERE s.WarehouseId = @WarehouseId
                ORDER BY s.StocktakeDate DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@WarehouseId", warehouseId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على جرد بواسطة المعرف
        /// </summary>
        public Stocktake GetById(int stocktakeId)
        {
            string query = @"
                SELECT s.*, w.Name AS WarehouseName, u.FullName AS CreatorName
                FROM Stocktakes s
                INNER JOIN Warehouses w ON s.WarehouseId = w.WarehouseId
                INNER JOIN Users u ON s.CreatedBy = u.UserId
                WHERE s.StocktakeId = @StocktakeId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@StocktakeId", stocktakeId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// إضافة جرد
        /// </summary>
        public int Add(Stocktake stocktake)
        {
            string query = @"
                INSERT INTO Stocktakes (WarehouseId, StocktakeDate, Status, CreatedBy, Notes)
                VALUES (@WarehouseId, @StocktakeDate, @Status, @CreatedBy, @Notes);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@WarehouseId", stocktake.WarehouseId),
                DatabaseHelper.Param("@StocktakeDate", stocktake.StocktakeDate),
                DatabaseHelper.Param("@Status", stocktake.Status),
                DatabaseHelper.Param("@CreatedBy", stocktake.CreatedBy),
                DatabaseHelper.Param("@Notes", (object)stocktake.Notes ?? DBNull.Value));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// تعديل حالة الجرد
        /// </summary>
        public bool UpdateStatus(int stocktakeId, string status)
        {
            string query = @"
                UPDATE Stocktakes
                SET Status = @Status
                WHERE StocktakeId = @StocktakeId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@StocktakeId", stocktakeId),
                DatabaseHelper.Param("@Status", status));

            return rows > 0;
        }

        /// <summary>
        /// حذف جرد
        /// </summary>
        public bool Delete(int stocktakeId)
        {
            string query = "DELETE FROM Stocktakes WHERE StocktakeId = @StocktakeId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@StocktakeId", stocktakeId));

            return rows > 0;
        }

        private Stocktake MapToEntity(DataRow row)
        {
            return new Stocktake
            {
                StocktakeId = DatabaseHelper.GetValue<int>(row, "StocktakeId"),
                WarehouseId = DatabaseHelper.GetValue<int>(row, "WarehouseId"),
                StocktakeDate = DatabaseHelper.GetValue<DateTime>(row, "StocktakeDate"),
                Status = DatabaseHelper.GetValue<string>(row, "Status"),
                CreatedBy = DatabaseHelper.GetValue<int>(row, "CreatedBy"),
                Notes = row["Notes"] == DBNull.Value ? null : row["Notes"].ToString(),
                WarehouseName = row.Table.Columns.Contains("WarehouseName")
                    ? DatabaseHelper.GetValue<string>(row, "WarehouseName") : null,
                CreatorName = row.Table.Columns.Contains("CreatorName")
                    ? DatabaseHelper.GetValue<string>(row, "CreatorName") : null
            };
        }
    }
}