using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات الأدوار
    /// </summary>
    public class RoleDAL
    {
        /// <summary>
        /// الحصول على كل الأدوار
        /// </summary>
        public List<Role> GetAll()
        {
            var list = new List<Role>();

            string query = "SELECT * FROM Roles ORDER BY Name";
            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على دور بواسطة المعرف
        /// </summary>
        public Role GetById(int roleId)
        {
            string query = "SELECT * FROM Roles WHERE RoleId = @RoleId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@RoleId", roleId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// إضافة دور
        /// </summary>
        public int Add(Role role)
        {
            string query = @"
                INSERT INTO Roles (Name, Description)
                VALUES (@Name, @Description);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@Name", role.Name),
                DatabaseHelper.Param("@Description", (object)role.Description ?? DBNull.Value));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// تعديل دور
        /// </summary>
        public bool Update(Role role)
        {
            string query = @"
                UPDATE Roles
                SET Name = @Name,
                    Description = @Description
                WHERE RoleId = @RoleId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@RoleId", role.RoleId),
                DatabaseHelper.Param("@Name", role.Name),
                DatabaseHelper.Param("@Description", (object)role.Description ?? DBNull.Value));

            return rows > 0;
        }

        /// <summary>
        /// حذف دور
        /// </summary>
        public bool Delete(int roleId)
        {
            string query = "DELETE FROM Roles WHERE RoleId = @RoleId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@RoleId", roleId));

            return rows > 0;
        }

        /// <summary>
        /// هل الاسم موجود؟
        /// </summary>
        public bool IsNameExists(string name, int excludeId = 0)
        {
            string query = @"
                SELECT COUNT(*) FROM Roles
                WHERE Name = @Name AND RoleId <> @ExcludeId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@Name", name),
                DatabaseHelper.Param("@ExcludeId", excludeId));

            return count > 0;
        }

        private Role MapToEntity(DataRow row)
        {
            return new Role
            {
                RoleId = DatabaseHelper.GetValue<int>(row, "RoleId"),
                Name = DatabaseHelper.GetValue<string>(row, "Name"),
                Description = row["Description"] == DBNull.Value ? null : row["Description"].ToString()
            };
        }
    }
}