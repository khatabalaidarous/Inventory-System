using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات المستودعات
    /// </summary>
    public class WarehouseDAL
    {
        /// <summary>
        /// الحصول على كل المستودعات
        /// </summary>
        public List<Warehouse> GetAll()
        {
            var list = new List<Warehouse>();

            string query = @"
                SELECT w.*, u.FullName AS ManagerName
                FROM Warehouses w
                LEFT JOIN Users u ON w.ManagerId = u.UserId
                ORDER BY w.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// المستودعات المفعّلة فقط
        /// </summary>
        public List<Warehouse> GetActive()
        {
            var list = new List<Warehouse>();

            string query = @"
                SELECT w.*, u.FullName AS ManagerName
                FROM Warehouses w
                LEFT JOIN Users u ON w.ManagerId = u.UserId
                WHERE w.IsActive = 1
                ORDER BY w.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على مستودع بواسطة المعرف
        /// </summary>
        public Warehouse GetById(int warehouseId)
        {
            string query = @"
                SELECT w.*, u.FullName AS ManagerName
                FROM Warehouses w
                LEFT JOIN Users u ON w.ManagerId = u.UserId
                WHERE w.WarehouseId = @WarehouseId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@WarehouseId", warehouseId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// إضافة مستودع
        /// </summary>
        public int Add(Warehouse warehouse)
        {
            string query = @"
                INSERT INTO Warehouses (Name, Location, ManagerId, IsActive)
                VALUES (@Name, @Location, @ManagerId, @IsActive);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@Name", warehouse.Name),
                DatabaseHelper.Param("@Location", (object)warehouse.Location ?? DBNull.Value),
                DatabaseHelper.Param("@ManagerId", (object)warehouse.ManagerId ?? DBNull.Value),
                DatabaseHelper.Param("@IsActive", warehouse.IsActive));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// تعديل مستودع
        /// </summary>
        public bool Update(Warehouse warehouse)
        {
            string query = @"
                UPDATE Warehouses
                SET Name = @Name,
                    Location = @Location,
                    ManagerId = @ManagerId,
                    IsActive = @IsActive
                WHERE WarehouseId = @WarehouseId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@WarehouseId", warehouse.WarehouseId),
                DatabaseHelper.Param("@Name", warehouse.Name),
                DatabaseHelper.Param("@Location", (object)warehouse.Location ?? DBNull.Value),
                DatabaseHelper.Param("@ManagerId", (object)warehouse.ManagerId ?? DBNull.Value),
                DatabaseHelper.Param("@IsActive", warehouse.IsActive));

            return rows > 0;
        }

        /// <summary>
        /// حذف مستودع
        /// </summary>
        public bool Delete(int warehouseId)
        {
            string query = "DELETE FROM Warehouses WHERE WarehouseId = @WarehouseId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@WarehouseId", warehouseId));

            return rows > 0;
        }

        /// <summary>
        /// هل الاسم موجود؟
        /// </summary>
        public bool IsNameExists(string name, int excludeId = 0)
        {
            string query = @"
                SELECT COUNT(*) FROM Warehouses
                WHERE Name = @Name AND WarehouseId <> @ExcludeId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@Name", name),
                DatabaseHelper.Param("@ExcludeId", excludeId));

            return count > 0;
        }

        /// <summary>
        /// هل المستودع يحتوي على مخزون؟
        /// </summary>
        public bool HasInventory(int warehouseId)
        {
            string query = @"
                SELECT COUNT(*) FROM Inventory
                WHERE WarehouseId = @WarehouseId AND Quantity > 0";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@WarehouseId", warehouseId));

            return count > 0;
        }

        /// <summary>
        /// عدد المستودعات
        /// </summary>
        public int GetCount()
        {
            string query = "SELECT COUNT(*) FROM Warehouses WHERE IsActive = 1";
            return DatabaseHelper.ExecuteScalar<int>(query);
        }

        private Warehouse MapToEntity(DataRow row)
        {
            return new Warehouse
            {
                WarehouseId = DatabaseHelper.GetValue<int>(row, "WarehouseId"),
                Name = DatabaseHelper.GetValue<string>(row, "Name"),
                Location = row["Location"] == DBNull.Value ? null : row["Location"].ToString(),
                ManagerId = row["ManagerId"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["ManagerId"]),
                IsActive = DatabaseHelper.GetValue<bool>(row, "IsActive"),
                ManagerName = row.Table.Columns.Contains("ManagerName") && row["ManagerName"] != DBNull.Value
                    ? row["ManagerName"].ToString()
                    : null
            };
        }
    }
}