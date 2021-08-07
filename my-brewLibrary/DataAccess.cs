using Dapper;
using my_brewLibrary.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace my_brewLibrary
{
    public class DataAccess : IDataAccess

    {   
        public async Task<List<T>> LoadData<T, U>(string sql, U parameters, string connectionString)
        {
            using ( IDbConnection connection = new MySqlConnection(connectionString) )
            {
                var rows = await connection.QueryAsync<T>(sql, parameters);
                
                return rows.ToList();
            }
        }

        internal static List<PersonAccount> LoadData()
        {
            throw new NotImplementedException();
        }

        public Task SaveData<T>(string sql, T parameters, string connectionString)
        {
            using ( IDbConnection connection = new MySqlConnection(connectionString) )
            {
               return connection.ExecuteAsync(sql, parameters);                               
            }
        }
    }
}