using InventorySystem.UI.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data;

namespace InventorySystem.UI.DataAccess
{
    /// <summary>
    /// الوصول لبيانات الوحدات
    /// </summary>
    public class UnitDAL
    {
        /// <summary>
        /// الحصول على كل الوحدات
        /// </summary>
        public List<Unit> GetAll()
        {
            var list = new List<Unit>();

            string query = "SELECT * FROM Units ORDER BY Name";
            var dt = DatabaseHelper.ExecuteDataTable(query);

            foreach (DataRow row in dt.Rows)
                list.Add(MapToEntity(row));

            return list;
        }

        /// <summary>
        /// الحصول على وحدة بواسطة المعرف
        /// </summary>
        public Unit GetById(int unitId)
        {
            string query = "SELECT * FROM Units WHERE UnitId = @UnitId";

            var dt = DatabaseHelper.ExecuteDataTable(query,
                DatabaseHelper.Param("@UnitId", unitId));

            if (dt.Rows.Count == 0)
                return null;

            return MapToEntity(dt.Rows[0]);
        }

        /// <summary>
        /// إضافة وحدة جديدة
        /// </summary>
        public int Add(Unit unit)
        {
            string query = @"
                INSERT INTO Units (Name, Symbol)
                VALUES (@Name, @Symbol);
                SELECT SCOPE_IDENTITY();";

            var result = DatabaseHelper.ExecuteScalar(query,
                DatabaseHelper.Param("@Name", unit.Name),
                DatabaseHelper.Param("@Symbol", (object)unit.Symbol ?? DBNull.Value));

            return Convert.ToInt32(result);
        }

        /// <summary>
        /// تعديل وحدة
        /// </summary>
        public bool Update(Unit unit)
        {
            string query = @"
                UPDATE Units
                SET Name = @Name,
                    Symbol = @Symbol
                WHERE UnitId = @UnitId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@UnitId", unit.UnitId),
                DatabaseHelper.Param("@Name", unit.Name),
                DatabaseHelper.Param("@Symbol", (object)unit.Symbol ?? DBNull.Value));

            return rows > 0;
        }

        /// <summary>
        /// حذف وحدة
        /// </summary>
        public bool Delete(int unitId)
        {
            string query = "DELETE FROM Units WHERE UnitId = @UnitId";

            int rows = DatabaseHelper.ExecuteNonQuery(query,
                DatabaseHelper.Param("@UnitId", unitId));

            return rows > 0;
        }

        /// <summary>
        /// هل الاسم موجود؟
        /// </summary>
        public bool IsNameExists(string name, int excludeId = 0)
        {
            string query = @"
                SELECT COUNT(*) FROM Units
                WHERE Name = @Name AND UnitId <> @ExcludeId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@Name", name),
                DatabaseHelper.Param("@ExcludeId", excludeId));

            return count > 0;
        }

        /// <summary>
        /// هل الوحدة مستخدمة في منتجات؟
        /// </summary>
        public bool IsUsedInProducts(int unitId)
        {
            string query = "SELECT COUNT(*) FROM Products WHERE UnitId = @UnitId";

            int count = DatabaseHelper.ExecuteScalar<int>(query,
                DatabaseHelper.Param("@UnitId", unitId));

            return count > 0;
        }

        private Unit MapToEntity(DataRow row)
        {
            return new Unit
            {
                UnitId = DatabaseHelper.GetValue<int>(row, "UnitId"),
                Name = DatabaseHelper.GetValue<string>(row, "Name"),
                Symbol = row["Symbol"] == DBNull.Value ? null : row["Symbol"].ToString()
            };
        }
    }
}