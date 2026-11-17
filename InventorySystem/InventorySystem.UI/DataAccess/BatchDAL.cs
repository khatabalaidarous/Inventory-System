using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات الدفعات
    /// </summary>
    public class BatchDAL
    {
        /// <summary>
        /// الحصول على كل الدفعات
        /// </summary>
        public List<Batch> GetAll()
        {
            var list = new List<Batch>();

            string query = @"
                SELECT b.*, p.Name AS ProductName
                FROM Batches b
                INNER JOIN Products p ON b.ProductId = p.ProductId
                ORDER BY b.CreatedAt DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على دفعات منتج معين
        /// </summary>
        public List<Batch> GetByProduct(int productId)
        {
            var list = new List<Batch>();

            string query = @"
                SELECT b.*, p.Name AS ProductName
                FROM Batches b
                INNER JOIN Products p ON b.ProductId = p.ProductId
                WHERE b.ProductId = @ProductId
                ORDER BY b.ExpiryDate";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@ProductId", productId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الدفعات القريبة من الانتهاء
        /// </summary>
        public List<Batch> GetExpiringSoon(int days = 30)
        {
            var list = new List<Batch>();

            string query = @"
                SELECT b.*, p.Name AS ProductName
                FROM Batches b
                INNER JOIN Products p ON b.ProductId = p.ProductId
                WHERE b.ExpiryDate IS NOT NULL
                  AND b.ExpiryDate >= GETDATE()
                  AND b.ExpiryDate <= DATEADD(DAY, @Days, GETDATE())
                ORDER BY b.ExpiryDate";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@Days", days));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الدفعات المنتهية
        /// </summary>
        public List<Batch> GetExpired()
        {
            var list = new List<Batch>();

            string query = @"
                SELECT b.*, p.Name AS ProductName
                FROM Batches b
                INNER JOIN Products p ON b.ProductId = p.ProductId
                WHERE b.ExpiryDate IS NOT NULL
                  AND b.ExpiryDate < GETDATE()
                ORDER BY b.ExpiryDate DESC";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على دفعة بواسطة المعرف
        /// </summary>
        public Batch GetById(int batchId)
        {
            string query = @"
                SELECT b.*, p.Name AS ProductName
                FROM Batches b
                INNER JOIN Products p ON b.ProductId = p.ProductId
                WHERE b.BatchId = @BatchId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@BatchId", batchId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// إضافة دفعة
        /// </summary>
        public int Add(Batch batch)
        {
            string query = @"
                INSERT INTO Batches (ProductId, BatchNumber, ProductionDate, ExpiryDate, CreatedAt)
                VALUES (@ProductId, @BatchNumber, @ProductionDate, @ExpiryDate, @CreatedAt);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@ProductId", batch.ProductId),
                DatabaseHelper.Param("@BatchNumber", batch.BatchNumber),
                DatabaseHelper.Param("@ProductionDate", (object)batch.ProductionDate ?? DBNull.Value),
                DatabaseHelper.Param("@ExpiryDate", (object)batch.ExpiryDate ?? DBNull.Value),
                DatabaseHelper.Param("@CreatedAt", batch.CreatedAt));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// تعديل دفعة
        /// </summary>
        public bool Update(Batch batch)
        {
            string query = @"
                UPDATE Batches
                SET BatchNumber = @BatchNumber,
                    ProductionDate = @ProductionDate,
                    ExpiryDate = @ExpiryDate
                WHERE BatchId = @BatchId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@BatchId", batch.BatchId),
                DatabaseHelper.Param("@BatchNumber", batch.BatchNumber),
                DatabaseHelper.Param("@ProductionDate", (object)batch.ProductionDate ?? DBNull.Value),
                DatabaseHelper.Param("@ExpiryDate", (object)batch.ExpiryDate ?? DBNull.Value));

            return rows > 0;
        }

        /// <summary>
        /// حذف دفعة
        /// </summary>
        public bool Delete(int batchId)
        {
            string query = "DELETE FROM Batches WHERE BatchId = @BatchId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@BatchId", batchId));

            return rows > 0;
        }

        /// <summary>
        /// هل رقم الدفعة موجود لنفس المنتج؟
        /// </summary>
        public bool IsBatchNumberExists(int productId, string batchNumber, int excludeId = 0)
        {
            string query = @"
                SELECT COUNT(*) FROM Batches
                WHERE ProductId = @ProductId 
                  AND BatchNumber = @BatchNumber 
                  AND BatchId <> @ExcludeId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@ProductId", productId),
                DatabaseHelper.Param("@BatchNumber", batchNumber),
                DatabaseHelper.Param("@ExcludeId", excludeId));

            return count > 0;
        }

        /// <summary>
        /// هل الدفعة لها كمية في المخزون؟
        /// </summary>
        public bool HasQuantity(int batchId)
        {
            string query = @"
                SELECT COUNT(*) FROM InventoryBatches
                WHERE BatchId = @BatchId AND Quantity > 0";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@BatchId", batchId));

            return count > 0;
        }

        private Batch MapToEntity(DataRow row)
        {
            return new Batch
            {
                BatchId = DatabaseHelper.GetValue<int>(row, "BatchId"),
                ProductId = DatabaseHelper.GetValue<int>(row, "ProductId"),
                BatchNumber = DatabaseHelper.GetValue<string>(row, "BatchNumber"),
                ProductionDate = row["ProductionDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ProductionDate"]),
                ExpiryDate = row["ExpiryDate"] == DBNull.Value ? (DateTime?)null : Convert.ToDateTime(row["ExpiryDate"]),
                CreatedAt = DatabaseHelper.GetValue<DateTime>(row, "CreatedAt"),
                ProductName = row.Table.Columns.Contains("ProductName")
                    ? DatabaseHelper.GetValue<string>(row, "ProductName") : null
            };
        }
    }
}