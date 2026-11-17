using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات تفاصيل الحركات
    /// </summary>
    public class StockMovementDetailDAL
    {
        /// <summary>
        /// الحصول على تفاصيل حركة معينة
        /// </summary>
        public List<StockMovementDetail> GetByMovement(int movementId)
        {
            var list = new List<StockMovementDetail>();

            string query = @"
                SELECT d.*, p.Name AS ProductName, p.Code AS ProductCode, b.BatchNumber
                FROM StockMovementDetails d
                INNER JOIN Products p ON d.ProductId = p.ProductId
                LEFT JOIN Batches b ON d.BatchId = b.BatchId
                WHERE d.MovementId = @MovementId
                ORDER BY d.DetailId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@MovementId", movementId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// إضافة تفصيل حركة
        /// </summary>
        public int Add(StockMovementDetail detail)
        {
            string query = @"
                INSERT INTO StockMovementDetails (MovementId, ProductId, BatchId, Quantity, UnitPrice)
                VALUES (@MovementId, @ProductId, @BatchId, @Quantity, @UnitPrice);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@MovementId", detail.MovementId),
                DatabaseHelper.Param("@ProductId", detail.ProductId),
                DatabaseHelper.Param("@BatchId", (object)detail.BatchId ?? DBNull.Value),
                DatabaseHelper.Param("@Quantity", detail.Quantity),
                DatabaseHelper.Param("@UnitPrice", (object)detail.UnitPrice ?? DBNull.Value));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// حذف تفاصيل حركة
        /// </summary>
        public bool DeleteByMovement(int movementId)
        {
            string query = "DELETE FROM StockMovementDetails WHERE MovementId = @MovementId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@MovementId", movementId));

            return rows > 0;
        }

        /// <summary>
        /// حذف تفصيل واحد
        /// </summary>
        public bool Delete(int detailId)
        {
            string query = "DELETE FROM StockMovementDetails WHERE DetailId = @DetailId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@DetailId", detailId));

            return rows > 0;
        }

        private StockMovementDetail MapToEntity(DataRow row)
        {
            return new StockMovementDetail
            {
                DetailId = DatabaseHelper.GetValue<int>(row, "DetailId"),
                MovementId = DatabaseHelper.GetValue<int>(row, "MovementId"),
                ProductId = DatabaseHelper.GetValue<int>(row, "ProductId"),
                BatchId = row["BatchId"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["BatchId"]),
                Quantity = DatabaseHelper.GetValue<decimal>(row, "Quantity"),
                UnitPrice = row["UnitPrice"] == DBNull.Value ? (decimal?)null : Convert.ToDecimal(row["UnitPrice"]),
                ProductName = row.Table.Columns.Contains("ProductName")
                    ? DatabaseHelper.GetValue<string>(row, "ProductName") : null,
                ProductCode = row.Table.Columns.Contains("ProductCode")
                    ? DatabaseHelper.GetValue<string>(row, "ProductCode") : null,
                BatchNumber = row.Table.Columns.Contains("BatchNumber") && row["BatchNumber"] != DBNull.Value
                    ? row["BatchNumber"].ToString() : null
            };
        }
    }
}