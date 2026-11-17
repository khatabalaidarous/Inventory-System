using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات تفاصيل الجرد
    /// </summary>
    public class StocktakeDetailDAL
    {
        /// <summary>
        /// تفاصيل جرد معين
        /// </summary>
        public List<StocktakeDetail> GetByStocktake(int stocktakeId)
        {
            var list = new List<StocktakeDetail>();

            string query = @"
                SELECT d.*, p.Name AS ProductName, p.Code AS ProductCode, b.BatchNumber
                FROM StocktakeDetails d
                INNER JOIN Products p ON d.ProductId = p.ProductId
                LEFT JOIN Batches b ON d.BatchId = b.BatchId
                WHERE d.StocktakeId = @StocktakeId
                ORDER BY p.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@StocktakeId", stocktakeId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// إضافة تفصيل جرد
        /// </summary>
        public int Add(StocktakeDetail detail)
        {
            string query = @"
                INSERT INTO StocktakeDetails (StocktakeId, ProductId, BatchId, SystemQty, CountedQty)
                VALUES (@StocktakeId, @ProductId, @BatchId, @SystemQty, @CountedQty);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@StocktakeId", detail.StocktakeId),
                DatabaseHelper.Param("@ProductId", detail.ProductId),
                DatabaseHelper.Param("@BatchId", (object)detail.BatchId ?? DBNull.Value),
                DatabaseHelper.Param("@SystemQty", detail.SystemQty),
                DatabaseHelper.Param("@CountedQty", detail.CountedQty));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// حذف تفاصيل جرد
        /// </summary>
        public bool DeleteByStocktake(int stocktakeId)
        {
            string query = "DELETE FROM StocktakeDetails WHERE StocktakeId = @StocktakeId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@StocktakeId", stocktakeId));

            return rows > 0;
        }

        private StocktakeDetail MapToEntity(DataRow row)
        {
            return new StocktakeDetail
            {
                Id = DatabaseHelper.GetValue<int>(row, "Id"),
                StocktakeId = DatabaseHelper.GetValue<int>(row, "StocktakeId"),
                ProductId = DatabaseHelper.GetValue<int>(row, "ProductId"),
                BatchId = row["BatchId"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["BatchId"]),
                SystemQty = DatabaseHelper.GetValue<decimal>(row, "SystemQty"),
                CountedQty = DatabaseHelper.GetValue<decimal>(row, "CountedQty"),
                Difference = DatabaseHelper.GetValue<decimal>(row, "Difference"),
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