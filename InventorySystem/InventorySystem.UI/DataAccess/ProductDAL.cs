using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات المنتجات
    /// </summary>
    public class ProductDAL
    {
        /// <summary>
        /// الحصول على كل المنتجات
        /// </summary>
        public List<Product> GetAll()
        {
            var list = new List<Product>();

            string query = @"
                SELECT p.*, c.Name AS CategoryName, u.Name AS UnitName,
                       ISNULL((SELECT SUM(Quantity) FROM Inventory WHERE ProductId = p.ProductId), 0) AS CurrentStock
                FROM Products p
                INNER JOIN Categories c ON p.CategoryId = c.CategoryId
                INNER JOIN Units u ON p.UnitId = u.UnitId
                ORDER BY p.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على المنتجات المفعّلة فقط
        /// </summary>
        public List<Product> GetActive()
        {
            var list = new List<Product>();

            string query = @"
                SELECT p.*, c.Name AS CategoryName, u.Name AS UnitName,
                       ISNULL((SELECT SUM(Quantity) FROM Inventory WHERE ProductId = p.ProductId), 0) AS CurrentStock
                FROM Products p
                INNER JOIN Categories c ON p.CategoryId = c.CategoryId
                INNER JOIN Units u ON p.UnitId = u.UnitId
                WHERE p.IsActive = 1
                ORDER BY p.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// البحث في المنتجات
        /// </summary>
        public List<Product> Search(string keyword)
        {
            var list = new List<Product>();

            string query = @"
                SELECT p.*, c.Name AS CategoryName, u.Name AS UnitName,
                       ISNULL((SELECT SUM(Quantity) FROM Inventory WHERE ProductId = p.ProductId), 0) AS CurrentStock
                FROM Products p
                INNER JOIN Categories c ON p.CategoryId = c.CategoryId
                INNER JOIN Units u ON p.UnitId = u.UnitId
                WHERE p.Name LIKE @Keyword OR p.Code LIKE @Keyword
                ORDER BY p.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@Keyword", $"%{keyword}%"));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// المنتجات تحت الحد الأدنى
        /// </summary>
        public List<Product> GetBelowMinStock()
        {
            var list = new List<Product>();

            string query = @"
                SELECT p.*, c.Name AS CategoryName, u.Name AS UnitName,
                       ISNULL((SELECT SUM(Quantity) FROM Inventory WHERE ProductId = p.ProductId), 0) AS CurrentStock
                FROM Products p
                INNER JOIN Categories c ON p.CategoryId = c.CategoryId
                INNER JOIN Units u ON p.UnitId = u.UnitId
                WHERE p.IsActive = 1
                  AND ISNULL((SELECT SUM(Quantity) FROM Inventory WHERE ProductId = p.ProductId), 0) < p.MinStock
                ORDER BY p.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على منتج بواسطة المعرف
        /// </summary>
        public Product GetById(int productId)
        {
            string query = @"
                SELECT p.*, c.Name AS CategoryName, u.Name AS UnitName,
                       ISNULL((SELECT SUM(Quantity) FROM Inventory WHERE ProductId = p.ProductId), 0) AS CurrentStock
                FROM Products p
                INNER JOIN Categories c ON p.CategoryId = c.CategoryId
                INNER JOIN Units u ON p.UnitId = u.UnitId
                WHERE p.ProductId = @ProductId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@ProductId", productId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// إضافة منتج جديد
        /// </summary>
        public int Add(Product product)
        {
            string query = @"
                INSERT INTO Products (Code, Name, CategoryId, UnitId, MinStock, MaxStock, IsActive, CreatedAt)
                VALUES (@Code, @Name, @CategoryId, @UnitId, @MinStock, @MaxStock, @IsActive, @CreatedAt);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@Code", product.Code),
                DatabaseHelper.Param("@Name", product.Name),
                DatabaseHelper.Param("@CategoryId", product.CategoryId),
                DatabaseHelper.Param("@UnitId", product.UnitId),
                DatabaseHelper.Param("@MinStock", product.MinStock),
                DatabaseHelper.Param("@MaxStock", product.MaxStock),
                DatabaseHelper.Param("@IsActive", product.IsActive),
                DatabaseHelper.Param("@CreatedAt", product.CreatedAt));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// تعديل منتج
        /// </summary>
        public bool Update(Product product)
        {
            string query = @"
                UPDATE Products
                SET Code = @Code,
                    Name = @Name,
                    CategoryId = @CategoryId,
                    UnitId = @UnitId,
                    MinStock = @MinStock,
                    MaxStock = @MaxStock,
                    IsActive = @IsActive
                WHERE ProductId = @ProductId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@ProductId", product.ProductId),
                DatabaseHelper.Param("@Code", product.Code),
                DatabaseHelper.Param("@Name", product.Name),
                DatabaseHelper.Param("@CategoryId", product.CategoryId),
                DatabaseHelper.Param("@UnitId", product.UnitId),
                DatabaseHelper.Param("@MinStock", product.MinStock),
                DatabaseHelper.Param("@MaxStock", product.MaxStock),
                DatabaseHelper.Param("@IsActive", product.IsActive));

            return rows > 0;
        }

        /// <summary>
        /// حذف منتج
        /// </summary>
        public bool Delete(int productId)
        {
            string query = "DELETE FROM Products WHERE ProductId = @ProductId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@ProductId", productId));

            return rows > 0;
        }

        /// <summary>
        /// هل الكود موجود؟
        /// </summary>
        public bool IsCodeExists(string code, int excludeId = 0)
        {
            string query = @"
                SELECT COUNT(*) FROM Products
                WHERE Code = @Code AND ProductId <> @ExcludeId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@Code", code),
                DatabaseHelper.Param("@ExcludeId", excludeId));

            return count > 0;
        }

        /// <summary>
        /// هل المنتج له مخزون؟
        /// </summary>
        public bool HasStock(int productId)
        {
            string query = @"
                SELECT COUNT(*) FROM Inventory
                WHERE ProductId = @ProductId AND Quantity > 0";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@ProductId", productId));

            return count > 0;
        }

        /// <summary>
        /// عدد المنتجات
        /// </summary>
        public int GetCount()
        {
            string query = "SELECT COUNT(*) FROM Products WHERE IsActive = 1";
            return DatabaseHelper.ExecuteScalar<int>(query);
        }

        private Product MapToEntity(DataRow row)
        {
            return new Product
            {
                ProductId = DatabaseHelper.GetValue<int>(row, "ProductId"),
                Code = DatabaseHelper.GetValue<string>(row, "Code"),
                Name = DatabaseHelper.GetValue<string>(row, "Name"),
                CategoryId = DatabaseHelper.GetValue<int>(row, "CategoryId"),
                UnitId = DatabaseHelper.GetValue<int>(row, "UnitId"),
                MinStock = DatabaseHelper.GetValue<decimal>(row, "MinStock"),
                MaxStock = DatabaseHelper.GetValue<decimal>(row, "MaxStock"),
                IsActive = DatabaseHelper.GetValue<bool>(row, "IsActive"),
                CreatedAt = DatabaseHelper.GetValue<DateTime>(row, "CreatedAt"),
                CategoryName = row.Table.Columns.Contains("CategoryName")
                    ? DatabaseHelper.GetValue<string>(row, "CategoryName") : null,
                UnitName = row.Table.Columns.Contains("UnitName")
                    ? DatabaseHelper.GetValue<string>(row, "UnitName") : null,
                CurrentStock = row.Table.Columns.Contains("CurrentStock")
                    ? DatabaseHelper.GetValue<decimal>(row, "CurrentStock") : 0
            };
        }
    }
}