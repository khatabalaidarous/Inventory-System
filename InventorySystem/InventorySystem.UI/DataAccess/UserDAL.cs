using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات المستخدمين
    /// </summary>
    public class UserDAL
    {
        /// <summary>
        /// الحصول على كل المستخدمين
        /// </summary>
        public List<User> GetAll()
        {
            var list = new List<User>();

            string query = "SELECT * FROM Users ORDER BY FullName";
            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على مستخدم بواسطة المعرف
        /// </summary>
        public User GetById(int userId)
        {
            string query = "SELECT * FROM Users WHERE UserId = @UserId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@UserId", userId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// الحصول على مستخدم بواسطة اسم الدخول
        /// </summary>
        public User GetByUsername(string username)
        {
            string query = "SELECT * FROM Users WHERE Username = @Username";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@Username", username));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// التحقق من تسجيل الدخول
        /// </summary>
        public User Login(string username, string passwordHash)
        {
            string query = @"
                SELECT * FROM Users
                WHERE Username = @Username 
                  AND PasswordHash = @PasswordHash
                  AND IsActive = 1";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@Username", username),
                DatabaseHelper.Param("@PasswordHash", passwordHash));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// إضافة مستخدم
        /// </summary>
        public int Add(User user)
        {
            string query = @"
                INSERT INTO Users (Username, PasswordHash, FullName, IsActive, CreatedAt)
                VALUES (@Username, @PasswordHash, @FullName, @IsActive, @CreatedAt);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@Username", user.Username),
                DatabaseHelper.Param("@PasswordHash", user.PasswordHash),
                DatabaseHelper.Param("@FullName", user.FullName),
                DatabaseHelper.Param("@IsActive", user.IsActive),
                DatabaseHelper.Param("@CreatedAt", user.CreatedAt));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// تعديل مستخدم
        /// </summary>
        public bool Update(User user)
        {
            string query = @"
                UPDATE Users
                SET Username = @Username,
                    FullName = @FullName,
                    IsActive = @IsActive
                WHERE UserId = @UserId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@UserId", user.UserId),
                DatabaseHelper.Param("@Username", user.Username),
                DatabaseHelper.Param("@FullName", user.FullName),
                DatabaseHelper.Param("@IsActive", user.IsActive));

            return rows > 0;
        }

        /// <summary>
        /// تغيير كلمة المرور
        /// </summary>
        public bool ChangePassword(int userId, string newPasswordHash)
        {
            string query = @"
                UPDATE Users
                SET PasswordHash = @PasswordHash
                WHERE UserId = @UserId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@UserId", userId),
                DatabaseHelper.Param("@PasswordHash", newPasswordHash));

            return rows > 0;
        }

        /// <summary>
        /// حذف مستخدم
        /// </summary>
        public bool Delete(int userId)
        {
            string query = "DELETE FROM Users WHERE UserId = @UserId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@UserId", userId));

            return rows > 0;
        }

        /// <summary>
        /// هل اسم الدخول موجود؟
        /// </summary>
        public bool IsUsernameExists(string username, int excludeId = 0)
        {
            string query = @"
                SELECT COUNT(*) FROM Users
                WHERE Username = @Username AND UserId <> @ExcludeId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@Username", username),
                DatabaseHelper.Param("@ExcludeId", excludeId));

            return count > 0;
        }

        private User MapToEntity(DataRow row)
        {
            return new User
            {
                UserId = DatabaseHelper.GetValue<int>(row, "UserId"),
                Username = DatabaseHelper.GetValue<string>(row, "Username"),
                PasswordHash = DatabaseHelper.GetValue<string>(row, "PasswordHash"),
                FullName = DatabaseHelper.GetValue<string>(row, "FullName"),
                IsActive = DatabaseHelper.GetValue<bool>(row, "IsActive"),
                CreatedAt = DatabaseHelper.GetValue<DateTime>(row, "CreatedAt")
            };
        }
    }
}