using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using InventorySystem.UI.Helpers;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// مساعد قاعدة البيانات
    /// يوفر دوال جاهزة لتنفيذ استعلامات SQL
    /// </summary>
    public static class DatabaseHelper
    {
        // ============================================
        // سلسلة الاتصال
        // ============================================

        /// <summary>
        /// سلسلة الاتصال (تُقرأ من App.config)
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["InventoryDbConnection"].ConnectionString;
            }
        }

        // ============================================
        // إنشاء اتصال
        // ============================================

        /// <summary>
        /// إنشاء اتصال جديد بقاعدة البيانات
        /// </summary>
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        /// <summary>
        /// اختبار الاتصال بقاعدة البيانات
        /// </summary>
        public static bool TestConnection()
        {
            try
            {
                using (var connection = CreateConnection())

                    connection.Open();
                    return true;
                
            }
            catch
            {
                return false;
            }
        }

        // ============================================
        // ExecuteNonQuery (INSERT / UPDATE / DELETE)
        // ============================================

        /// <summary>
        /// تنفيذ استعلام لا يُرجع بيانات
        /// </summary>
        /// <param name="query">استعلام SQL</param>
        /// <param name="parameters">المعاملات</param>
        /// <returns>عدد السجلات المتأثرة</returns>
        public static int ExecuteNonQuery(string query,
            params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        if (parameters != null && parameters.Length > 0)
                            command.Parameters.AddRange(parameters);

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"خطأ في تنفيذ الاستعلام: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// تنفيذ إجراء مخزن لا يُرجع بيانات
        /// </summary>
        public static int ExecuteStoredProcedure(string spName,
            params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    using (var command = new SqlCommand(spName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        if (parameters != null && parameters.Length > 0)
                            command.Parameters.AddRange(parameters);

                        connection.Open();
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"خطأ في تنفيذ الإجراء: {ex.Message}", ex);
            }
        }

        // ============================================
        // ExecuteScalar (SELECT COUNT / MAX / MIN)
        // ============================================

        /// <summary>
        /// تنفيذ استعلام يُرجع قيمة واحدة
        /// </summary>
        public static object ExecuteScalar(string query,
            params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        if (parameters != null && parameters.Length > 0)
                            command.Parameters.AddRange(parameters);

                        connection.Open();
                        return command.ExecuteScalar();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"خطأ في تنفيذ الاستعلام: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// تنفيذ استعلام يُرجع قيمة واحدة (بتحويل النوع)
        /// </summary>
        public static T ExecuteScalar<T>(string query,
            params SqlParameter[] parameters)
        {
            var result = ExecuteScalar(query, parameters);

            if (result == null || result == DBNull.Value)
                return default(T);

            return (T)Convert.ChangeType(result, typeof(T));
        }

        // ============================================
        // ExecuteDataTable (SELECT)
        // ============================================

        /// <summary>
        /// تنفيذ استعلام يُرجع جدولاً
        /// </summary>
        public static DataTable ExecuteDataTable(string query,
            params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    using (var command = new SqlCommand(query, connection))
                    {
                        if (parameters != null && parameters.Length > 0)
                            command.Parameters.AddRange(parameters);

                        connection.Open();

                        var dataTable = new DataTable();
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"خطأ في تنفيذ الاستعلام: {ex.Message}", ex);
            }
        }

        /// <summary>
        /// تنفيذ إجراء مخزن يُرجع جدولاً
        /// </summary>
        public static DataTable ExecuteStoredProcedureDataTable(string spName,
            params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = CreateConnection())
                {
                    using (var command = new SqlCommand(spName, connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        if (parameters != null && parameters.Length > 0)
                            command.Parameters.AddRange(parameters);

                        connection.Open();

                        var dataTable = new DataTable();
                        using (var adapter = new SqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }

                        return dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"خطأ في تنفيذ الإجراء: {ex.Message}", ex);
            }
        }

        // ============================================
        // دوال مساعدة
        // ============================================

        /// <summary>
        /// إنشاء معامل SQL
        /// </summary>
        public static SqlParameter Param(string name, object value)
        {
            return new SqlParameter(name, value ?? DBNull.Value);
        }

        /// <summary>
        /// إنشاء معامل SQL مع تحديد النوع
        /// </summary>
        public static SqlParameter Param(string name, SqlDbType type, object value)
        {
            return new SqlParameter(name, type)
            {
                Value = value ?? DBNull.Value
            };
        }

        /// <summary>
        /// معامل الإخراج (Output Parameter)
        /// </summary>
        public static SqlParameter OutputParam(string name, SqlDbType type)
        {
            return new SqlParameter(name, type)
            {
                Direction = ParameterDirection.Output
            };
        }

        /// <summary>
        /// تحويل قيمة من قاعدة البيانات
        /// </summary>
        public static T GetValue<T>(DataRow row, string columnName)
        {
            if (row == null || !row.Table.Columns.Contains(columnName))
                return default(T);

            var value = row[columnName];

            if (value == null || value == DBNull.Value)
                return default(T);

            return (T)Convert.ChangeType(value, typeof(T));
        }
    }
}