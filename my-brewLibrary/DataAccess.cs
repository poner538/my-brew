using Dapper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace my_brewLibrary
{
    public class DataAccess
    {   
        public static List<T> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using ( IDbConnection connection = new MySqlConnection(connectionString) )
            {
                List<T> rows = connection.Query<T>(sql, parameters).ToList();
                
                return rows;
            }
        }
    

             
        public static Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using ( IDbConnection connection = new MySqlConnection(connectionString) )
            {
               return connection.ExecuteAsync(sql, parameters);                               
            }
        }
    }
}