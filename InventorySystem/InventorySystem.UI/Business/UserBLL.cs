using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using InventorySystem.UI.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل المستخدمين
    /// </summary>
    public class UserBLL
    {
        private readonly UserDAL _dal;
        private readonly UserRoleDAL _userRoleDal;
        private readonly RoleDAL _roleDal;
        private readonly RolePermissionDAL _rolePermissionDal;

        public UserBLL()
        {
            _dal = new UserDAL();
            _userRoleDal = new UserRoleDAL();
            _roleDal = new RoleDAL();
            _rolePermissionDal = new RolePermissionDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل المستخدمين
        /// </summary>
        public List<User> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المستخدمين: {ex.Message}";
                return new List<User>();
            }
        }

        /// <summary>
        /// الحصول على مستخدم
        /// </summary>
        public User GetById(int userId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetById(userId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل المستخدم: {ex.Message}";
                return null;
            }
        }

        // ============================================
        // تسجيل الدخول
        // ============================================

        /// <summary>
        /// تسجيل الدخول والتحقق من الصلاحيات
        /// </summary>
        public User Login(string username, string password, out string error)
        {
            error = null;

            if (string.IsNullOrWhiteSpace(username))
            {
                error = "اسم المستخدم مطلوب";
                return null;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                error = "كلمة المرور مطلوبة";
                return null;
            }

            try
            {
                // تشفير كلمة المرور
                string passwordHash = PasswordHelper.HashPassword(password);

                // البحث عن المستخدم
                var user = _dal.Login(username, passwordHash);

                if (user == null)
                {
                    error = "اسم المستخدم أو كلمة المرور غير صحيحة";
                    return null;
                }

                // تحميل الأدوار والصلاحيات
                LoadUserRolesAndPermissions(user);

                return user;
            }
            catch (Exception ex)
            {
                error = $"فشل في تسجيل الدخول: {ex.Message}";
                return null;
            }
        }

        /// <summary>
        /// تحميل أدوار وصلاحيات المستخدم
        /// </summary>
        private void LoadUserRolesAndPermissions(User user)
        {
            var userRoles = _userRoleDal.GetByUser(user.UserId);
            var roles = new List<string>();
            var permissions = new List<string>();

            foreach (var ur in userRoles)
            {
                roles.Add(ur.RoleName);

                var rolePermissions = _rolePermissionDal.GetByRole(ur.RoleId);
                foreach (var rp in rolePermissions)
                {
                    if (!permissions.Contains(rp.PermissionCode))
                        permissions.Add(rp.PermissionCode);
                }
            }

            SessionManager.Initialize(user, roles, permissions);
        }

        // ============================================
        // الإضافة
        // ============================================

        /// <summary>
        /// إضافة مستخدم
        /// </summary>
        public bool Add(User user, string password, out string error)
        {
            error = null;

            if (!Validate(user, out error))
                return false;

            if (string.IsNullOrWhiteSpace(password))
            {
                error = "كلمة المرور مطلوبة";
                return false;
            }

            if (password.Length < 4)
            {
                error = "كلمة المرور يجب أن تكون 4 أحرف على الأقل";
                return false;
            }

            if (_dal.IsUsernameExists(user.Username))
            {
                error = "اسم المستخدم موجود مسبقاً";
                return false;
            }

            try
            {
                // تشفير كلمة المرور
                user.PasswordHash = PasswordHelper.HashPassword(password);

                _dal.Add(user);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إضافة المستخدم: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التعديل
        // ============================================

        /// <summary>
        /// تعديل مستخدم
        /// </summary>
        public bool Update(User user, out string error)
        {
            error = null;

            if (!Validate(user, out error))
                return false;

            if (_dal.IsUsernameExists(user.Username, user.UserId))
            {
                error = "اسم المستخدم موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Update(user);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعديل المستخدم: {ex.Message}";
                return false;
            }
        }

        /// <summary>
        /// تغيير كلمة المرور
        /// </summary>
        public bool ChangePassword(int userId, string newPassword, out string error)
        {
            error = null;

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                error = "كلمة المرور مطلوبة";
                return false;
            }

            if (newPassword.Length < 4)
            {
                error = "كلمة المرور يجب أن تكون 4 أحرف على الأقل";
                return false;
            }

            try
            {
                string passwordHash = PasswordHelper.HashPassword(newPassword);
                _dal.ChangePassword(userId, passwordHash);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تغيير كلمة المرور: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف مستخدم
        /// </summary>
        public bool Delete(int userId, out string error)
        {
            error = null;

            if (userId == SessionManager.UserId)
            {
                error = "لا يمكن حذف المستخدم الحالي";
                return false;
            }

            try
            {
                // حذف الأدوار أولاً
                _userRoleDal.DeleteByUser(userId);

                // حذف المستخدم
                _dal.Delete(userId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف المستخدم: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // إدارة الأدوار
        // ============================================

        /// <summary>
        /// الحصول على أدوار المستخدم
        /// </summary>
        public List<Role> GetUserRoles(int userId, out string error)
        {
            error = null;
            try
            {
                var userRoles = _userRoleDal.GetByUser(userId);
                var roles = new List<Role>();

                foreach (var ur in userRoles)
                {
                    var role = _roleDal.GetById(ur.RoleId);
                    if (role != null) roles.Add(role);
                }

                return roles;
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الأدوار: {ex.Message}";
                return new List<Role>();
            }
        }

        /// <summary>
        /// تعيين أدوار للمستخدم
        /// </summary>
        public bool SetUserRoles(int userId, List<int> roleIds, out string error)
        {
            error = null;

            try
            {
                // حذف الأدوار الحالية
                _userRoleDal.DeleteByUser(userId);

                // إضافة الأدوار الجديدة
                foreach (var roleId in roleIds)
                {
                    _userRoleDal.Add(userId, roleId);
                }

                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعيين الأدوار: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التحقق
        // ============================================

        private bool Validate(User user, out string error)
        {
            error = null;

            if (user == null)
            {
                error = "البيانات فارغة";
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.Username))
            {
                error = "اسم المستخدم مطلوب";
                return false;
            }

            if (user.Username.Length > 50)
            {
                error = "اسم المستخدم طويل جداً (الحد الأقصى 50 حرف)";
                return false;
            }

            if (string.IsNullOrWhiteSpace(user.FullName))
            {
                error = "الاسم الكامل مطلوب";
                return false;
            }

            if (user.FullName.Length > 100)
            {
                error = "الاسم الكامل طويل جداً (الحد الأقصى 100 حرف)";
                return false;
            }

            return true;
        }
    }
}