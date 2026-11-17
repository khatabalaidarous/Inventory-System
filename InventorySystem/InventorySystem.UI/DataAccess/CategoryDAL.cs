using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات التصنيفات
    /// </summary>
    public class CategoryDAL
    {
        // ============================================
        // قراءة كل التصنيفات
        // ============================================

        /// <summary>
        /// الحصول على كل التصنيفات
        /// </summary>
        public List<Category> GetAll()
        {
            var list = new List<Category>();

            string query = @"
                SELECT c.*, p.Name AS ParentName
                FROM Categories c
                LEFT JOIN Categories p ON c.ParentId = p.CategoryId
                ORDER BY c.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapToEntity(row));
            }

            return list;
        }

        /// <summary>
        /// الحصول على التصنيفات المفعّلة فقط
        /// </summary>
        public List<Category> GetActive()
        {
            var list = new List<Category>();

            string query = @"
                SELECT c.*, p.Name AS ParentName
                FROM Categories c
                LEFT JOIN Categories p ON c.ParentId = p.CategoryId
                WHERE c.IsActive = 1
                ORDER BY c.Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapToEntity(row));
            }

            return list;
        }

        /// <summary>
        /// الحصول على التصنيفات الرئيسية فقط
        /// </summary>
        public List<Category> GetMainCategories()
        {
            var list = new List<Category>();

            string query = @"
                SELECT * FROM Categories
                WHERE ParentId IS NULL AND IsActive = 1
                ORDER BY Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(MapToEntity(row));
            }

            return list;
        }

        // ============================================
        // قراءة تصنيف واحد
        // ============================================

        /// <summary>
        /// الحصول على تصنيف بواسطة المعرف
        /// </summary>
        public Category GetById(int categoryId)
        {
            string query = @"
                SELECT c.*, p.Name AS ParentName
                FROM Categories c
                LEFT JOIN Categories p ON c.ParentId = p.CategoryId
                WHERE c.CategoryId = @CategoryId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@CategoryId", categoryId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        // ============================================
        // إضافة
        // ============================================

        /// <summary>
        /// إضافة تصنيف جديد
        /// </summary>
        /// <returns>معرف التصنيف الجديد</returns>
        public int Add(Category category)
        {
            string query = @"
                INSERT INTO Categories (Name, ParentId, IsActive, CreatedAt)
                VALUES (@Name, @ParentId, @IsActive, @CreatedAt);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@Name", category.Name),
                DatabaseHelper.Param("@ParentId", (object)category.ParentId ?? DBNull.Value),
                DatabaseHelper.Param("@IsActive", category.IsActive),
                DatabaseHelper.Param("@CreatedAt", category.CreatedAt));

            return Convert.ToInt32(result);
        }

        // ============================================
        // تعديل
        // ============================================

        /// <summary>
        /// تعديل تصنيف
        /// </summary>
        public bool Update(Category category)
        {
            string query = @"
                UPDATE Categories
                SET Name = @Name,
                    ParentId = @ParentId,
                    IsActive = @IsActive
                WHERE CategoryId = @CategoryId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@CategoryId", category.CategoryId),
                DatabaseHelper.Param("@Name", category.Name),
                DatabaseHelper.Param("@ParentId", (object)category.ParentId ?? DBNull.Value),
                DatabaseHelper.Param("@IsActive", category.IsActive));

            return rows > 0;
        }

        // ============================================
        // حذف
        // ============================================

        /// <summary>
        /// حذف تصنيف
        /// </summary>
        public bool Delete(int categoryId)
        {
            string query = "DELETE FROM Categories WHERE CategoryId = @CategoryId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@CategoryId", categoryId));

            return rows > 0;
        }

        // ============================================
        // التحقق
        // ============================================

        /// <summary>
        /// هل الاسم موجود؟
        /// </summary>
        public bool IsNameExists(string name, int excludeId = 0)
        {
            string query = @"
                SELECT COUNT(*) FROM Categories
                WHERE Name = @Name AND CategoryId <> @ExcludeId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@Name", name),
                DatabaseHelper.Param("@ExcludeId", excludeId));

            return count > 0;
        }

        /// <summary>
        /// هل التصنيف مستخدم في منتجات؟
        /// </summary>
        public bool IsUsedInProducts(int categoryId)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE CategoryId = @CategoryId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@CategoryId", categoryId));

            return count > 0;
        }

        /// <summary>
        /// هل التصنيف له تصنيفات فرعية؟
        /// </summary>
        public bool HasChildren(int categoryId)
        {
            string query = "SELECT COUNT(*) FROM Categories WHERE ParentId = @CategoryId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@CategoryId", categoryId));

            return count > 0;
        }

        // ============================================
        // التحويل من DataRow إلى Entity
        // ============================================

        private Category MapToEntity(DataRow row)
        {
            return new Category
            {
                CategoryId = DatabaseHelper.GetValue<int>(row, "CategoryId"),
                Name = DatabaseHelper.GetValue<string>(row, "Name"),
                ParentId = row["ParentId"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["ParentId"]),
                IsActive = DatabaseHelper.GetValue<bool>(row, "IsActive"),
                CreatedAt = DatabaseHelper.GetValue<DateTime>(row, "CreatedAt"),
                ParentName = row.Table.Columns.Contains("ParentName") && row["ParentName"] != DBNull.Value
                    ? row["ParentName"].ToString()
                    : null
            };
        }
    }
}