using FastMember;
using MedicalCorporation.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MedicalCorporation.Core.SqlShellParts
{
    public partial class MedicalSqlShell
    {
        public void Update<T>(T entity, T etalonEntity) where T : IHaveIdentifier
        {
            string tableName = GetTableName<T>();
            GetSerializedType(entity, out var columnNamesResult, out var columnsValuesResult);
            GetSerializedType(etalonEntity, out var columnNamesResultEtalon, out var columnsValuesResultEtalon);

            var columnNamesArray = columnNamesResult.Split(',').Select(x => x.Trim())
                .Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            var columnsValuesArray = columnsValuesResult.Split(',').Select(x => x.Trim())
                .Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
            var columnsValuesArrayEtalon = columnsValuesResultEtalon.Split(',').Select(x => x.Trim())
                .Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();

            var start = true;
            var setBuilder = new StringBuilder();
            for (int i = 0; i < columnNamesArray.Length; i++)
            {
                if (columnsValuesArray[i] != columnsValuesArrayEtalon[i])
                {
                    if (!start)
                        setBuilder.Append(", ");

                    setBuilder.Append($"{columnNamesArray[i]} = {columnsValuesArray[i]}");

                    if (start)
                        start = false;
                }
            }

            var cmdTxt = $"UPDATE [{_dbName}].dbo.{tableName} SET {setBuilder} WHERE Id = {entity.Id}";

            if (ExecuteNonQuery(cmdTxt) == 0)
                throw new Exception("Affected 0 rows");
        }

        public void DeleteWhere<T>(string whereCondition) where T : IHaveIdentifier
        {
            string tableName = GetTableName<T>();
            var cmdTxt = $"DELETE FROM [{_dbName}].dbo.{tableName} WHERE {whereCondition}";

            if (ExecuteNonQuery(cmdTxt) == 0)
                throw new Exception("Affected 0 rows");
        }

        public T[] GetWhere<T>(string whereCondition) where T : class, IHaveIdentifier, new()
        {
            string tableName = GetTableName<T>();
            var cmdTxt = $"SELECT * FROM [{_dbName}].[dbo].[{tableName}] WHERE {whereCondition}";
            return GetArrayOf<T>(cmdTxt);
        }

        public T GetById<T>(int id) where T : class, IHaveIdentifier, new()
        {
            string tableName = GetTableName<T>();
            var cmdTxt = $"SELECT * FROM [{_dbName}].[dbo].[{tableName}] WHERE Id = {id}";
            return ReadAs<T>(cmdTxt);
        }

        private string GetTableName<T>() where T : IHaveIdentifier
        {
            var type = typeof(T);

            var propTableName = type.GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Single(x => x.Name == "TableName");

            return (string)propTableName.GetValue(null);
        }

        public T[] GetArrayOf<T>() where T : class, IHaveIdentifier, new()
        {
            string tableName = GetTableName<T>();
            var getTableValuesCmd = $"select * from [{_dbName}].[dbo].[{tableName}]";
            return GetArrayOf<T>(getTableValuesCmd);
        }

        public void Insert<T>(T client) where T : IHaveIdentifier
        {
            if (client == null)
                throw new ArgumentNullException(nameof(client));

            var insertCmd = ConvertTypeInstanceToInsertCmd(client);

            if (ExecuteNonQuery(insertCmd) == 0)
                throw new Exception("Affected 0 rows");
        }

        public T ReadAs<T>(string getCmd) where T : class, new()
        {
            return GetArrayOf<T>(getCmd).FirstOrDefault();
        }

        public T[] GetArrayOf<T>(string getCmd) where T : class, new()
        {
            var list = new List<T>();
            using (var reader = ExecuteReader(getCmd))
            {
                while (reader.Read())
                {
                    var typeimplementation = ConvertRowToType<T>(reader);
                    list.Add(typeimplementation);
                }
            }
            return list.ToArray();
        }

        public static T ConvertRowToType<T>(SqlDataReader rd) where T : class, new()
        {
            Type type = typeof(T);
            var accessor = TypeAccessor.Create(type);
            var members = type.GetProperties
                (BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
            var t = new T();

            for (int i = 0; i < rd.FieldCount; i++)
            {
                if (!rd.IsDBNull(i))
                {
                    string fieldName = rd.GetName(i);

                    if (members.Any(m => string.Equals(m.Name, fieldName
                        , StringComparison.InvariantCultureIgnoreCase)))
                    {
                        var value = rd.GetValue(i);
                        if (value != null)
                            accessor[t, fieldName] = value;
                    }
                }
            }

            return t;
        }

        public string ConvertTypeInstanceToInsertCmd<T>(T obj) where T : IHaveIdentifier
        {
            const string ColumnNamesConst = "@@TYPENAMES@@";
            const string ColumnValuesConst = "@@TYPEVALUE@@";

            string tableName = GetTableName<T>();
            GetSerializedType(obj, out var columnNamesResult, out var columnsValuesResult);

            var etaloncmd = $"INSERT INTO [{_dbName}].dbo.{tableName} ({ColumnNamesConst}) " +
                $"VALUES ({ColumnValuesConst})";

            var result = etaloncmd.Replace(ColumnNamesConst, columnNamesResult);
            result = result.Replace(ColumnValuesConst, columnsValuesResult);

            return result;
        }

        public void GetSerializedType<T>(T obj, out string columnNamesResult, out string columnsValuesResult)
            where T : IHaveIdentifier
        {
            string tableName = GetTableName<T>();
            var columnNames = ReadColumnNames(tableName);

            var type = typeof(T);
            var properties = type.GetProperties();

            var list = new List<(string ColumnName, object ColumnValue)>();
            foreach (var columnName in columnNames)
            {
                if (columnName.ToLower() == "id")
                    continue;

                var matchedProp = properties
                    .FirstOrDefault(x => x.Name.ToLower() == columnName.ToLower());
                if (matchedProp != null)
                {
                    var value = matchedProp.GetValue(obj);
                    if (value != null)
                        list.Add((columnName, value));
                }
            }

            columnNamesResult = string.Join(","
                , list.Select(x => x.ColumnName).ToArray());
            columnsValuesResult = string.Join(", "
                , list.Select(x => ObjectToStringValue(x.ColumnValue)).ToArray());
        }

        public string ObjectToStringValue(object obj)
        {
            var type = obj?.GetType();
            if (type == null)
                return "NULL";
            else if (type.Name == nameof(String))
                return $"N'{(string)obj}'";
            else if (type.IsEnum)
                return Convert.ToString((int)obj);
            else if (DateTime.TryParse(obj.ToString(), out var dt))
                return $"'{dt.FormatToDate(true)}'";
            else
                return obj.ToString();
        }

        public string[] ReadColumnNames(string tableName)
        {
            var cmdtxt = $"SELECT COLUMN_NAME " +
                $"FROM[{_dbName}].INFORMATION_SCHEMA.COLUMNS " +
                $"WHERE TABLE_NAME = N'{tableName}'";
            return ReadArrayOfFirstStrings(cmdtxt);
        }
    }
}
