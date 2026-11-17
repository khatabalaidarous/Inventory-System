using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات الشركاء (موردين وعملاء)
    /// </summary>
    public class PartnerDAL
    {
        /// <summary>
        /// الحصول على كل الشركاء
        /// </summary>
        public List<Partner> GetAll()
        {
            var list = new List<Partner>();

            string query = "SELECT * FROM Partners ORDER BY Name";
            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على الموردين
        /// </summary>
        public List<Partner> GetSuppliers()
        {
            var list = new List<Partner>();

            string query = @"
                SELECT * FROM Partners
                WHERE Type IN ('Supplier', 'Both') AND IsActive = 1
                ORDER BY Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على العملاء
        /// </summary>
        public List<Partner> GetCustomers()
        {
            var list = new List<Partner>();

            string query = @"
                SELECT * FROM Partners
                WHERE Type IN ('Customer', 'Both') AND IsActive = 1
                ORDER BY Name";

            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// البحث في الشركاء
        /// </summary>
        public List<Partner> Search(string keyword)
        {
            var list = new List<Partner>();

            string query = @"
                SELECT * FROM Partners
                WHERE Name LIKE @Keyword OR Phone LIKE @Keyword
                ORDER BY Name";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@Keyword", $"%{keyword}%"));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على شريك بواسطة المعرف
        /// </summary>
        public Partner GetById(int partnerId)
        {
            string query = "SELECT * FROM Partners WHERE PartnerId = @PartnerId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@PartnerId", partnerId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// إضافة شريك
        /// </summary>
        public int Add(Partner partner)
        {
            string query = @"
                INSERT INTO Partners (Name, Type, Phone, Email, Address, TaxNumber, IsActive, CreatedAt)
                VALUES (@Name, @Type, @Phone, @Email, @Address, @TaxNumber, @IsActive, @CreatedAt);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@Name", partner.Name),
                DatabaseHelper.Param("@Type", partner.Type),
                DatabaseHelper.Param("@Phone", (object)partner.Phone ?? DBNull.Value),
                DatabaseHelper.Param("@Email", (object)partner.Email ?? DBNull.Value),
                DatabaseHelper.Param("@Address", (object)partner.Address ?? DBNull.Value),
                DatabaseHelper.Param("@TaxNumber", (object)partner.TaxNumber ?? DBNull.Value),
                DatabaseHelper.Param("@IsActive", partner.IsActive),
                DatabaseHelper.Param("@CreatedAt", partner.CreatedAt));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// تعديل شريك
        /// </summary>
        public bool Update(Partner partner)
        {
            string query = @"
                UPDATE Partners
                SET Name = @Name,
                    Type = @Type,
                    Phone = @Phone,
                    Email = @Email,
                    Address = @Address,
                    TaxNumber = @TaxNumber,
                    IsActive = @IsActive
                WHERE PartnerId = @PartnerId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@PartnerId", partner.PartnerId),
                DatabaseHelper.Param("@Name", partner.Name),
                DatabaseHelper.Param("@Type", partner.Type),
                DatabaseHelper.Param("@Phone", (object)partner.Phone ?? DBNull.Value),
                DatabaseHelper.Param("@Email", (object)partner.Email ?? DBNull.Value),
                DatabaseHelper.Param("@Address", (object)partner.Address ?? DBNull.Value),
                DatabaseHelper.Param("@TaxNumber", (object)partner.TaxNumber ?? DBNull.Value),
                DatabaseHelper.Param("@IsActive", partner.IsActive));

            return rows > 0;
        }

        /// <summary>
        /// حذف شريك
        /// </summary>
        public bool Delete(int partnerId)
        {
            string query = "DELETE FROM Partners WHERE PartnerId = @PartnerId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@PartnerId", partnerId));

            return rows > 0;
        }

        /// <summary>
        /// هل الاسم موجود؟
        /// </summary>
        public bool IsNameExists(string name, int excludeId = 0)
        {
            string query = @"
                SELECT COUNT(*) FROM Partners
                WHERE Name = @Name AND PartnerId <> @ExcludeId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@Name", name),
                DatabaseHelper.Param("@ExcludeId", excludeId));

            return count > 0;
        }

        /// <summary>
        /// هل الشريك مرتبط بحركات؟
        /// </summary>
        public bool HasMovements(int partnerId)
        {
            string query = "SELECT COUNT(*) FROM StockMovements WHERE PartnerId = @PartnerId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@PartnerId", partnerId));

            return count > 0;
        }

        private Partner MapToEntity(DataRow row)
        {
            return new Partner
            {
                PartnerId = DatabaseHelper.GetValue<int>(row, "PartnerId"),
                Name = DatabaseHelper.GetValue<string>(row, "Name"),
                Type = DatabaseHelper.GetValue<string>(row, "Type"),
                Phone = row["Phone"] == DBNull.Value ? null : row["Phone"].ToString(),
                Email = row["Email"] == DBNull.Value ? null : row["Email"].ToString(),
                Address = row["Address"] == DBNull.Value ? null : row["Address"].ToString(),
                TaxNumber = row["TaxNumber"] == DBNull.Value ? null : row["TaxNumber"].ToString(),
                IsActive = DatabaseHelper.GetValue<bool>(row, "IsActive"),
                CreatedAt = DatabaseHelper.GetValue<DateTime>(row, "CreatedAt")
            };
        }
    }
}