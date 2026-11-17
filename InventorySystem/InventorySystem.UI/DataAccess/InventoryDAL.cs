using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات المخزون
    /// </summary>
    public class InventoryDAL
    {
        /// <summary>
        /// الحصول على كل رصيد المخزون
        /// </summary>
        public List<Inventory> GetAll()
        {
            var list = new List<Inventory>();

            string query = @"
                SELECT i.*, p.Name AS ProductName, p.Code AS ProductCode, w.Name AS WarehouseName
                FROM Inventory i
                INNER JOIN Products p ON i.ProductId = p.ProductId
                INNER JOIN Warehouses w ON i.WarehouseId = w.WarehouseId
                ORDER BY p.Name, w.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على مخزون مستودع معين
        /// </summary>
        public List<Inventory> GetByWarehouse(int warehouseId)
        {
            var list = new List<Inventory>();

            string query = @"
                SELECT i.*, p.Name AS ProductName, p.Code AS ProductCode, w.Name AS WarehouseName
                FROM Inventory i
                INNER JOIN Products p ON i.ProductId = p.ProductId
                INNER JOIN Warehouses w ON i.WarehouseId = w.WarehouseId
                WHERE i.WarehouseId = @WarehouseId
                ORDER BY p.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@WarehouseId", warehouseId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على مخزون منتج معين
        /// </summary>
        public List<Inventory> GetByProduct(int productId)
        {
            var list = new List<Inventory>();

            string query = @"
                SELECT i.*, p.Name AS ProductName, p.Code AS ProductCode, w.Name AS WarehouseName
                FROM Inventory i
                INNER JOIN Products p ON i.ProductId = p.ProductId
                INNER JOIN Warehouses w ON i.WarehouseId = w.WarehouseId
                WHERE i.ProductId = @ProductId
                ORDER BY w.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@ProductId", productId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على كمية منتج في مستودع
        /// </summary>
        public decimal GetQuantity(int productId, int warehouseId)
        {
            string query = @"
                SELECT ISNULL(Quantity, 0) FROM Inventory
                WHERE ProductId = @ProductId AND WarehouseId = @WarehouseId";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@ProductId", productId),
                DatabaseHelper.Param("@WarehouseId", warehouseId));

            if (result == null || result == DBNull.Value)
                return 0;

            return Convert.ToDecimal(result);
        }

        /// <summary>
        /// إضافة أو تعديل رصيد المخزون
        /// </summary>
        public void AddOrUpdateQuantity(int productId, int warehouseId, decimal quantity)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM Inventory WHERE ProductId = @ProductId AND WarehouseId = @WarehouseId)
                BEGIN
                    UPDATE Inventory
                    SET Quantity = Quantity + @Quantity,
                        LastUpdated = GETDATE()
                    WHERE ProductId = @ProductId AND WarehouseId = @WarehouseId;
                END
                ELSE
                BEGIN
                    INSERT INTO Inventory (ProductId, WarehouseId, Quantity, ReservedQty, LastUpdated)
                    VALUES (@ProductId, @WarehouseId, @Quantity, 0, GETDATE());
                END";

            DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@ProductId", productId),
                DatabaseHelper.Param("@WarehouseId", warehouseId),
                DatabaseHelper.Param("@Quantity", quantity));
        }

        /// <summary>
        /// خصم من المخزون
        /// </summary>
        public bool DeductQuantity(int productId, int warehouseId, decimal quantity)
        {
            string query = @"
                UPDATE Inventory
                SET Quantity = Quantity - @Quantity,
                    LastUpdated = GETDATE()
                WHERE ProductId = @ProductId 
                  AND WarehouseId = @WarehouseId
                  AND Quantity >= @Quantity";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@ProductId", productId),
                DatabaseHelper.Param("@WarehouseId", warehouseId),
                DatabaseHelper.Param("@Quantity", quantity));

            return rows > 0;
        }

        /// <summary>
        /// عدد سجلات المخزون
        /// </summary>
        public int GetCount()
        {
            string query = "SELECT COUNT(*) FROM Inventory WHERE Quantity > 0";
            return DatabaseHelper.ExecuteScalar<int>(query);
        }

        /// <summary>
        /// إجمالي قيمة المخزون
        /// </summary>
        public decimal GetTotalValue()
        {
            string query = @"
                SELECT ISNULL(SUM(i.Quantity * p.MinStock), 0)
                FROM Inventory i
                INNER JOIN Products p ON i.ProductId = p.ProductId";

            return DatabaseHelper.ExecuteScalar<decimal>(query);
        }

        /// <summary>
        /// حذف رصيد منتج
        /// </summary>
        public bool Delete(int productId, int warehouseId)
        {
            string query = @"
                DELETE FROM Inventory
                WHERE ProductId = @ProductId AND WarehouseId = @WarehouseId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@ProductId", productId),
                DatabaseHelper.Param("@WarehouseId", warehouseId));

            return rows > 0;
        }

        private Inventory MapToEntity(DataRow row)
        {
            return new Inventory
            {
                InventoryId = DatabaseHelper.GetValue<int>(row, "InventoryId"),
                ProductId = DatabaseHelper.GetValue<int>(row, "ProductId"),
                WarehouseId = DatabaseHelper.GetValue<int>(row, "WarehouseId"),
                Quantity = DatabaseHelper.GetValue<decimal>(row, "Quantity"),
                ReservedQty = DatabaseHelper.GetValue<decimal>(row, "ReservedQty"),
                LastUpdated = DatabaseHelper.GetValue<DateTime>(row, "LastUpdated"),
                ProductName = row.Table.Columns.Contains("ProductName")
                    ? DatabaseHelper.GetValue<string>(row, "ProductName") : null,
                ProductCode = row.Table.Columns.Contains("ProductCode")
                    ? DatabaseHelper.GetValue<string>(row, "ProductCode") : null,
                WarehouseName = row.Table.Columns.Contains("WarehouseName")
                    ? DatabaseHelper.GetValue<string>(row, "WarehouseName") : null
            };
        }
    }
}