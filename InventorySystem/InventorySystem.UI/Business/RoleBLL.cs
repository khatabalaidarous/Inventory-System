using InventorySystem.UI.DataAccess;
using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;

namespace InventorySystem.UI.Business
{
    /// <summary>
    /// منطق عمل الأدوار
    /// </summary>
    public class RoleBLL
    {
        private readonly RoleDAL _dal;
        private readonly RolePermissionDAL _rolePermissionDal;

        public RoleBLL()
        {
            _dal = new RoleDAL();
            _rolePermissionDal = new RolePermissionDAL();
        }

        // ============================================
        // القراءة
        // ============================================

        /// <summary>
        /// الحصول على كل الأدوار
        /// </summary>
        public List<Role> GetAll(out string error)
        {
            error = null;
            try
            {
                return _dal.GetAll();
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الأدوار: {ex.Message}";
                return new List<Role>();
            }
        }

        /// <summary>
        /// الحصول على دور
        /// </summary>
        public Role GetById(int roleId, out string error)
        {
            error = null;
            try
            {
                return _dal.GetById(roleId);
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الدور: {ex.Message}";
                return null;
            }
        }

        // ============================================
        // الإضافة
        // ============================================

        /// <summary>
        /// إضافة دور
        /// </summary>
        public bool Add(Role role, out string error)
        {
            error = null;

            if (!Validate(role, out error))
                return false;

            if (_dal.IsNameExists(role.Name))
            {
                error = "اسم الدور موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Add(role);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في إضافة الدور: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التعديل
        // ============================================

        /// <summary>
        /// تعديل دور
        /// </summary>
        public bool Update(Role role, out string error)
        {
            error = null;

            if (!Validate(role, out error))
                return false;

            if (_dal.IsNameExists(role.Name, role.RoleId))
            {
                error = "اسم الدور موجود مسبقاً";
                return false;
            }

            try
            {
                _dal.Update(role);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعديل الدور: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // الحذف
        // ============================================

        /// <summary>
        /// حذف دور
        /// </summary>
        public bool Delete(int roleId, out string error)
        {
            error = null;

            try
            {
                // حذف الصلاحيات المرتبطة
                _rolePermissionDal.DeleteByRole(roleId);

                // حذف الدور
                _dal.Delete(roleId);
                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في حذف الدور: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // إدارة الصلاحيات
        // ============================================

        /// <summary>
        /// الحصول على صلاحيات دور
        /// </summary>
        public List<Permission> GetRolePermissions(int roleId, out string error)
        {
            error = null;
            try
            {
                var rolePermissions = _rolePermissionDal.GetByRole(roleId);
                var permissions = new List<Permission>();
                var permissionDal = new PermissionDAL();

                foreach (var rp in rolePermissions)
                {
                    var permission = permissionDal.GetById(rp.PermissionId);
                    if (permission != null) permissions.Add(permission);
                }

                return permissions;
            }
            catch (Exception ex)
            {
                error = $"فشل في تحميل الصلاحيات: {ex.Message}";
                return new List<Permission>();
            }
        }

        /// <summary>
        /// تعيين صلاحيات للدور
        /// </summary>
        public bool SetRolePermissions(int roleId, List<int> permissionIds, out string error)
        {
            error = null;

            try
            {
                // حذف الصلاحيات الحالية
                _rolePermissionDal.DeleteByRole(roleId);

                // إضافة الصلاحيات الجديدة
                foreach (var permissionId in permissionIds)
                {
                    _rolePermissionDal.Add(roleId, permissionId);
                }

                return true;
            }
            catch (Exception ex)
            {
                error = $"فشل في تعيين الصلاحيات: {ex.Message}";
                return false;
            }
        }

        // ============================================
        // التحقق
        // ============================================

        private bool Validate(Role role, out string error)
        {
            error = null;

            if (role == null)
            {
                error = "البيانات فارغة";
                return false;
            }

            if (string.IsNullOrWhiteSpace(role.Name))
            {
                error = "اسم الدور مطلوب";
                return false;
            }

            if (role.Name.Length > 50)
            {
                error = "اسم الدور طويل جداً (الحد الأقصى 50 حرف)";
                return false;
            }

            if (!string.IsNullOrWhiteSpace(role.Description) && role.Description.Length > 200)
            {
                error = "وصف الدور طويل جداً (الحد الأقصى 200 حرف)";
                return false;
            }

            return true;
        }
    }
}