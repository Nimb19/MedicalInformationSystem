using MedicalCorporation.Core.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace MedicalCorporation.Core.SqlShellParts
{
    public partial class MedicalSqlShell : IDisposable
    {
        private readonly SqlConnection _connection;

        private readonly string _dbName = CoreConstants.DbName;
        private readonly int _commandTimeout = CoreConstants.CommandTimeout;

        private readonly SqlServerSettings _settings;

        public MedicalSqlShell(SqlServerSettings setiings, string[] pathsToGenerateDbScripts, bool checkVersion = true)
        {
            _settings = setiings; 

            var sqlStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = _settings.ServerName,
                InitialCatalog = "master",
                IntegratedSecurity = _settings.IntegratedSecurity ?? true,
                ConnectTimeout = _commandTimeout,
            };

            if (!sqlStringBuilder.IntegratedSecurity)
            {
                sqlStringBuilder.UserID = _settings.Login;
                sqlStringBuilder.Password = _settings.Password;
            }

            _connection = new SqlConnection(sqlStringBuilder.ConnectionString);
            _connection.Open();

            CreateDBIfItDoesNotExist(pathsToGenerateDbScripts);
            if (checkVersion)
                CheckStructVersion();
        }

        private void CreateDBIfItDoesNotExist(string[] pathsToGenerateDbScripts)
        {
            var cmdtxt = $"SELECT * FROM master.dbo.sysdatabases WHERE name = '{_dbName}'";
            if (ReadArrayOfFirstStrings(cmdtxt).Length == 0)
            {
                foreach (var path in pathsToGenerateDbScripts)
                {
                    var sqlCmds = CoreExtensions.ReadFile(path);
                    foreach (var sqlCmd in sqlCmds.Split(new[] { "GO", "go" }, StringSplitOptions.RemoveEmptyEntries))
                    {
                        ExecuteNonQueryAndCheckAffectedRows(sqlCmd);
                    }
                }
            }
        }

        private void CheckStructVersion()
        {
            var cmd = $"SELECT {nameof(Param.Value)} FROM {_dbName}.{Param.TableName} WHERE Id = {(int)ParamElements.StructVersion}";
            var structVersion = (ExecuteScalar(cmd) as string)
                ?? throw new ArgumentException("Версия структуры отсутствовала в БД или имела некорректный тип данных");

            if (string.Equals(structVersion, CoreConstants.StructVersion, StringComparison.InvariantCultureIgnoreCase))
                throw new Exception("Версия структуры отличается от версии библиотеки типов");
        }

        public string[] ReadArrayOfFirstStrings(string cmdText)
        {
            var list = new List<string>();
            using (var reader = ExecuteReader(cmdText))
            {
                while (reader.Read())
                {
                    var value = reader.GetString(0);
                    list.Add(value);
                }
            }
            return list.ToArray();
        }

        public SqlDataReader ExecuteReader(string command, CommandType commandType = CommandType.Text)
        {
            using (var cmd = CreateCommand(command, commandType))
                return cmd.ExecuteReader();
        }

        public object ExecuteScalar(string command, CommandType commandType = CommandType.Text)
        {
            using (var cmd = CreateCommand(command, commandType))
                return cmd.ExecuteScalar();
        }

        private void ExecuteNonQueryAndCheckAffectedRows(string sqlCmd)
        {
            if (ExecuteNonQuery(sqlCmd) == 0)
                throw new Exception("Affected 0 rows");
        }

        public int ExecuteNonQuery(string command, CommandType commandType = CommandType.Text)
        {
            using (var cmd = CreateCommand(command, commandType))
                return cmd.ExecuteNonQuery();
        }

        public SqlCommand CreateCommand(string command, CommandType commandType = CommandType.Text)
        {
            var cmd = _connection.CreateCommand();
            cmd.CommandTimeout = _commandTimeout;
            cmd.CommandType = commandType;
            cmd.CommandText = command;

            return cmd;
        }

        public void Dispose()
        {
            try
            {
                _connection?.Dispose();
            }
            catch { }
        }
    }

    public class SqlServerSettings
    {
        public string ServerName { get; set; }
        public bool? IntegratedSecurity { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public static SqlServerSettings GetDefaultSettings()
        {
            return new SqlServerSettings()
            {
                ServerName = "localhost",
                IntegratedSecurity = true,
                Login = null,
                Password = null,
            };
        }
    }
}
