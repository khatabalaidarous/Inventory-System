using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات ربط الأدوار بالصلاحيات
    /// </summary>
    public class RolePermissionDAL
    {
        /// <summary>
        /// صلاحيات دور معين
        /// </summary>
        public List<RolePermission> GetByRole(int roleId)
        {
            var list = new List<RolePermission>();

            string query = @"
                SELECT rp.*, r.Name AS RoleName, p.Name AS PermissionName, p.Code AS PermissionCode
                FROM RolePermissions rp
                INNER JOIN Roles r ON rp.RoleId = r.RoleId
                INNER JOIN Permissions p ON rp.PermissionId = p.PermissionId
                WHERE rp.RoleId = @RoleId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@RoleId", roleId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// أدوار صلاحية معينة
        /// </summary>
        public List<RolePermission> GetByPermission(int permissionId)
        {
            var list = new List<RolePermission>();

            string query = @"
                SELECT rp.*, r.Name AS RoleName, p.Name AS PermissionName, p.Code AS PermissionCode
                FROM RolePermissions rp
                INNER JOIN Roles r ON rp.RoleId = r.RoleId
                INNER JOIN Permissions p ON rp.PermissionId = p.PermissionId
                WHERE rp.PermissionId = @PermissionId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@PermissionId", permissionId));

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// إضافة ربط
        /// </summary>
        public bool Add(int roleId, int permissionId)
        {
            string query = @"
                IF NOT EXISTS (SELECT 1 FROM RolePermissions WHERE RoleId = @RoleId AND PermissionId = @PermissionId)
                BEGIN
                    INSERT INTO RolePermissions (RoleId, PermissionId)
                    VALUES (@RoleId, @PermissionId);
                END";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@RoleId", roleId),
                DatabaseHelper.Param("@PermissionId", permissionId));

            return rows > 0;
        }

        /// <summary>
        /// حذف ربط
        /// </summary>
        public bool Delete(int roleId, int permissionId)
        {
            string query = @"
                DELETE FROM RolePermissions
                WHERE RoleId = @RoleId AND PermissionId = @PermissionId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@RoleId", roleId),
                DatabaseHelper.Param("@PermissionId", permissionId));

            return rows > 0;
        }

        /// <summary>
        /// حذف كل صلاحيات دور
        /// </summary>
        public bool DeleteByRole(int roleId)
        {
            string query = "DELETE FROM RolePermissions WHERE RoleId = @RoleId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@RoleId", roleId));

            return rows > 0;
        }

        private RolePermission MapToEntity(DataRow row)
        {
            return new RolePermission
            {
                RoleId = DatabaseHelper.GetValue<int>(row, "RoleId"),
                PermissionId = DatabaseHelper.GetValue<int>(row, "PermissionId"),
                RoleName = row.Table.Columns.Contains("RoleName")
                    ? DatabaseHelper.GetValue<string>(row, "RoleName") : null,
                PermissionName = row.Table.Columns.Contains("PermissionName")
                    ? DatabaseHelper.GetValue<string>(row, "PermissionName") : null,
                PermissionCode = row.Table.Columns.Contains("PermissionCode")
                    ? DatabaseHelper.GetValue<string>(row, "PermissionCode") : null
            };
        }
    }
}