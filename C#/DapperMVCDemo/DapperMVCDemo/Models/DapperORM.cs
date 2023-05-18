using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace DapperMVCDemo.Models
{
    public static class DapperORM
    {
        private static string _connectionString = @"Data Source=DESKTOP-Q41LQOG\SQLEXPRESS;Initial Catalog=EventSystem;Trusted_Connection=True;";

        public static void ExecuteWithoutReturn(string procedureName,DynamicParameters param = null)
        {
            using(IDbConnection sqlCon = new SqlConnection(_connectionString))
            {
                sqlCon.Open();
                sqlCon.Execute(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }

        //DapperORM.ExecureScalar<int>(_,_)
        public static T ExecuteScalar<T>(string procedureName,DynamicParameters param = null)
        {
            using(IDbConnection sqlCon = new SqlConnection(_connectionString))
            {
                sqlCon.Open();
                return sqlCon.ExecuteScalar<T>(procedureName,param,commandType: CommandType.StoredProcedure);
            }
        }

        //DapperORM.ReturnList<EventModel>
        public static IEnumerable<T> ReturnList<T>(string procedureName, DynamicParameters param = null)
        {
            using (IDbConnection sqlCon = new SqlConnection(_connectionString))
            {
                sqlCon.Open();
                return sqlCon.Query<T>(procedureName, param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}