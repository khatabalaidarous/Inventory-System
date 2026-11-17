using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات كميات الدفعات
    /// </summary>
    public class InventoryBatchDAL
    {
        /// <summary>
        /// الحصول على كميات دفعة معينة
        /// </summary>
        public List<InventoryBatch> GetByBatch(int batchId)
        {
            var list = new List<InventoryBatch>();

            string query = @"
                SELECT ib.*, b.BatchNumber, w.Name AS WarehouseName
                FROM InventoryBatches ib
                INNER JOIN Batches b ON ib.BatchId = b.BatchId
                INNER JOIN Warehouses w ON ib.WarehouseId = w.WarehouseId
                WHERE ib.BatchId = @BatchId
                ORDER BY w.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@BatchId", batchId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على دفعات مستودع معين
        /// </summary>
        public List<InventoryBatch> GetByWarehouse(int warehouseId)
        {
            var list = new List<InventoryBatch>();

            string query = @"
                SELECT ib.*, b.BatchNumber, w.Name AS WarehouseName
                FROM InventoryBatches ib
                INNER JOIN Batches b ON ib.BatchId = b.BatchId
                INNER JOIN Warehouses w ON ib.WarehouseId = w.WarehouseId
                WHERE ib.WarehouseId = @WarehouseId AND ib.Quantity > 0
                ORDER BY b.BatchNumber";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@WarehouseId", warehouseId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// كمية دفعة في مستودع
        /// </summary>
        public decimal GetQuantity(int batchId, int warehouseId)
        {
            string query = @"
                SELECT ISNULL(Quantity, 0) FROM InventoryBatches
                WHERE BatchId = @BatchId AND WarehouseId = @WarehouseId";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@BatchId", batchId),
                DatabaseHelper.Param("@WarehouseId", warehouseId));

            if (result == null || result == DBNull.Value)
                return 0;

            return Convert.ToDecimal(result);
        }

        /// <summary>
        /// إضافة أو تعديل كمية دفعة
        /// </summary>
        public void AddOrUpdateQuantity(int batchId, int warehouseId, decimal quantity)
        {
            string query = @"
                IF EXISTS (SELECT 1 FROM InventoryBatches WHERE BatchId = @BatchId AND WarehouseId = @WarehouseId)
                BEGIN
                    UPDATE InventoryBatches
                    SET Quantity = Quantity + @Quantity
                    WHERE BatchId = @BatchId AND WarehouseId = @WarehouseId;
                END
                ELSE
                BEGIN
                    INSERT INTO InventoryBatches (BatchId, WarehouseId, Quantity)
                    VALUES (@BatchId, @WarehouseId, @Quantity);
                END";

            DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@BatchId", batchId),
                DatabaseHelper.Param("@WarehouseId", warehouseId),
                DatabaseHelper.Param("@Quantity", quantity));
        }

        /// <summary>
        /// خصم من كمية دفعة
        /// </summary>
        public bool DeductQuantity(int batchId, int warehouseId, decimal quantity)
        {
            string query = @"
                UPDATE InventoryBatches
                SET Quantity = Quantity - @Quantity
                WHERE BatchId = @BatchId 
                  AND WarehouseId = @WarehouseId
                  AND Quantity >= @Quantity";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@BatchId", batchId),
                DatabaseHelper.Param("@WarehouseId", warehouseId),
                DatabaseHelper.Param("@Quantity", quantity));

            return rows > 0;
        }

        /// <summary>
        /// حذف كمية دفعة
        /// </summary>
        public bool Delete(int batchId, int warehouseId)
        {
            string query = @"
                DELETE FROM InventoryBatches
                WHERE BatchId = @BatchId AND WarehouseId = @WarehouseId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@BatchId", batchId),
                DatabaseHelper.Param("@WarehouseId", warehouseId));

            return rows > 0;
        }

        private InventoryBatch MapToEntity(DataRow row)
        {
            return new InventoryBatch
            {
                Id = DatabaseHelper.GetValue<int>(row, "Id"),
                BatchId = DatabaseHelper.GetValue<int>(row, "BatchId"),
                WarehouseId = DatabaseHelper.GetValue<int>(row, "WarehouseId"),
                Quantity = DatabaseHelper.GetValue<decimal>(row, "Quantity"),
                BatchNumber = row.Table.Columns.Contains("BatchNumber")
                    ? DatabaseHelper.GetValue<string>(row, "BatchNumber") : null,
                WarehouseName = row.Table.Columns.Contains("WarehouseName")
                    ? DatabaseHelper.GetValue<string>(row, "WarehouseName") : null
            };
        }
    }
}