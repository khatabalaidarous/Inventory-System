using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات ربط المستخدم بالأدوار
    /// </summary>
    public class UserRoleDAL
    {
        /// <summary>
        /// أدوار مستخدم معين
        /// </summary>
        public List<UserRole> GetByUser(int userId)
        {
            var list = new List<UserRole>();

            string query = @"
                SELECT ur.*, u.Username, r.Name AS RoleName
                FROM UserRoles ur
                INNER JOIN Users u ON ur.UserId = u.UserId
                INNER JOIN Roles r ON ur.RoleId = r.RoleId
                WHERE ur.UserId = @UserId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@UserId", userId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// مستخدمو دور معين
        /// </summary>
        public List<UserRole> GetByRole(int roleId)
        {
            var list = new List<UserRole>();

            string query = @"
                SELECT ur.*, u.Username, r.Name AS RoleName
                FROM UserRoles ur
                INNER JOIN Users u ON ur.UserId = u.UserId
                INNER JOIN Roles r ON ur.RoleId = r.RoleId
                WHERE ur.RoleId = @RoleId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@RoleId", roleId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// إضافة ربط
        /// </summary>
        public bool Add(int userId, int roleId)
        {
            string query = @"
                IF NOT EXISTS (SELECT 1 FROM UserRoles WHERE UserId = @UserId AND RoleId = @RoleId)
                BEGIN
                    INSERT INTO UserRoles (UserId, RoleId)
                    VALUES (@UserId, @RoleId);
                END";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@UserId", userId),
                DatabaseHelper.Param("@RoleId", roleId));

            return rows > 0;
        }

        /// <summary>
        /// حذف ربط
        /// </summary>
        public bool Delete(int userId, int roleId)
        {
            string query = @"
                DELETE FROM UserRoles
                WHERE UserId = @UserId AND RoleId = @RoleId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@UserId", userId),
                DatabaseHelper.Param("@RoleId", roleId));

            return rows > 0;
        }

        /// <summary>
        /// حذف كل أدوار مستخدم
        /// </summary>
        public bool DeleteByUser(int userId)
        {
            string query = "DELETE FROM UserRoles WHERE UserId = @UserId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@UserId", userId));

            return rows > 0;
        }

        private UserRole MapToEntity(DataRow row)
        {
            return new UserRole
            {
                UserId = DatabaseHelper.GetValue<int>(row, "UserId"),
                RoleId = DatabaseHelper.GetValue<int>(row, "RoleId"),
                Username = row.Table.Columns.Contains("Username")
                    ? DatabaseHelper.GetValue<string>(row, "Username") : null,
                RoleName = row.Table.Columns.Contains("RoleName")
                    ? DatabaseHelper.GetValue<string>(row, "RoleName") : null
            };
        }
    }
}