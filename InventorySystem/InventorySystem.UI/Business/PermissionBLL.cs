using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل الصلاحيات
    /// </summary>
    public class PermissionBLL
    {
        private readonly PermissionDAL _dal;
        private readonly UserRoleDAL _userRoleDal;
        private readonly RolePermissionDAL _rolePermissionDal;

        public PermissionBLL()
        {
            _dal = new PermissionDAL();
            _userRoleDal = new UserRoleDAL();
            _rolePermissionDal = new RolePermissionDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل الصلاحيات
        /// </summary>
        public List<Permission> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الصلاحيات: {ex.Message}";
                return new List<Permission>();
            }
        }

        /// <summary>
        /// الحصول على صلاحية
        /// </summary>
        public Permission GetById(int permissionId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetById(permissionId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الصلاحية: {ex.Message}";
                return null;
            }
        }

        // ============================================
        // الإضافة
        // ============================================

        /// <summary>
        /// إضافة صلاحية
        /// </summary>
        public bool Add(Permission permission, out string error)
        {
            error = null;

            if (!Validate(permission, out error))
                return false;

            if (_dal.IsCodeExists(permission.Code))
            {
                error = "كود الصلاحية موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Add(permission);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إضافة الصلاحية: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التعديل
        // ============================================

        /// <summary>
        /// تعديل صلاحية
        /// </summary>
        public bool Update(Permission permission, out string error)
        {
            error = null;

            if (!Validate(permission, out error))
                return false;

            if (_dal.IsCodeExists(permission.Code, permission.PermissionId))
            {
                error = "كود الصلاحية موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Update(permission);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعديل الصلاحية: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف صلاحية
        /// </summary>
        public bool Delete(int permissionId, out string error)
        {
            error = null;

            try
            {
                _dal.Delete(permissionId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف الصلاحية: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التحقق من صلاحيات المستخدم
        // ============================================

        /// <summary>
        /// هل المستخدم لديه صلاحية معينة؟
        /// </summary>
        public bool HasPermission(int userId, string permissionCode, out string error)
        {
            error = null;
            try
            {
                var userRoles = _userRoleDal.GetByUser(userId);

                foreach (var ur in userRoles)
                {
                    var rolePermissions = _rolePermissionDal.GetByRole(ur.RoleId);

                    foreach (var rp in rolePermissions)
                    {
                        if (rp.PermissionCode == permissionCode)
                            return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                error = $"فشل في التحقق من الصلاحية: {ex.Message}";
                return false;
            }
        }

        /// <summary>
        /// الحصول على كل صلاحيات المستخدم
        /// </summary>
        public List<string> GetUserPermissions(int userId, out string error)
        {
            error = null;
            try
            {
                var permissions = new List<string>();
                var userRoles = _userRoleDal.GetByUser(userId);

                foreach (var ur in userRoles)
                {
                    var rolePermissions = _rolePermissionDal.GetByRole(ur.RoleId);

                    foreach (var rp in rolePermissions)
                    {
                        if (!permissions.Contains(rp.PermissionCode))
                            permissions.Add(rp.PermissionCode);
                    }
                }

                return permissions;
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الصلاحيات: {ex.Message}";
                return new List<string>();
            }
        }

        // ============================================
        // التحقق
        // ============================================

        private bool Validate(Permission permission, out string error)
        {
            error = null;

            if (permission == null)
            {
                error = "البيانات فارغة";
                return false;
            }

            if (string.IsNullOrWhiteSpace(permission.Code))
            {
                error = "كود الصلاحية مطلوب";
                return false;
            }

            if (permission.Code.Length > 50)
            {
                error = "كود الصلاحية طويل جداً (الحد الأقصى 50 حرف)";
                return false;
            }

            if (string.IsNullOrWhiteSpace(permission.Name))
            {
                error = "اسم الصلاحية مطلوب";
                return false;
            }

            if (permission.Name.Length > 100)
            {
                error = "اسم الصلاحية طويل جداً (الحد الأقصى 100 حرف)";
                return false;
            }

            return true;
        }
    }
}