using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات الصلاحيات
    /// </summary>
    public class PermissionDAL
    {
        /// <summary>
        /// الحصول على كل الصلاحيات
        /// </summary>
        public List<Permission> GetAll()
        {
            var list = new List<Permission>();

            string query = "SELECT * FROM Permissions ORDER BY Code";
            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على صلاحية بواسطة المعرف
        /// </summary>
        public Permission GetById(int permissionId)
        {
            string query = "SELECT * FROM Permissions WHERE PermissionId = @PermissionId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@PermissionId", permissionId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// إضافة صلاحية
        /// </summary>
        public int Add(Permission permission)
        {
            string query = @"
                INSERT INTO Permissions (Code, Name)
                VALUES (@Code, @Name);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@Code", permission.Code),
                DatabaseHelper.Param("@Name", permission.Name));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// تعديل صلاحية
        /// </summary>
        public bool Update(Permission permission)
        {
            string query = @"
                UPDATE Permissions
                SET Code = @Code,
                    Name = @Name
                WHERE PermissionId = @PermissionId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@PermissionId", permission.PermissionId),
                DatabaseHelper.Param("@Code", permission.Code),
                DatabaseHelper.Param("@Name", permission.Name));

            return rows > 0;
        }

        /// <summary>
        /// حذف صلاحية
        /// </summary>
        public bool Delete(int permissionId)
        {
            string query = "DELETE FROM Permissions WHERE PermissionId = @PermissionId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@PermissionId", permissionId));

            return rows > 0;
        }

        /// <summary>
        /// هل الكود موجود؟
        /// </summary>
        public bool IsCodeExists(string code, int excludeId = 0)
        {
            string query = @"
                SELECT COUNT(*) FROM Permissions
                WHERE Code = @Code AND PermissionId <> @ExcludeId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@Code", code),
                DatabaseHelper.Param("@ExcludeId", excludeId));

            return count > 0;
        }

        private Permission MapToEntity(DataRow row)
        {
            return new Permission
            {
                PermissionId = DatabaseHelper.GetValue<int>(row, "PermissionId"),
                Code = DatabaseHelper.GetValue<string>(row, "Code"),
                Name = DatabaseHelper.GetValue<string>(row, "Name")
            };
        }
    }
}