

using System.Collections.Generic;
using System.Configuration;
using System.Threading.Tasks;
using my_brewLibrary.Models;
using MySql.Data.MySqlClient;

namespace my_brewLibrary.Bussinesslogic
{
    public class PersonAccountProcessor : IPersonAccountProcessor
    {
        public List<PersonAccount> GetPersonAccounts(string connStr)
        {
            List<PersonAccount> accounts = new List<PersonAccount>();

            using(MySqlConnection conn = new MySqlConnection(connStr))
            {
                string query = "SELECT Firstname, Lastname FROM PersonAccount";
                using(MySqlCommand cmd = new MySqlCommand(query)) 
                {
                    cmd.Connection = conn;
                    conn.Open();
                    using(MySqlDataReader sdr = cmd.ExecuteReader())
                    {
                        while(sdr.Read())
                        {
                            accounts.Add(new PersonAccount
                            {
                                Firstname = sdr["Firstname"].ToString(),
                                Lastname = sdr["Lastname"].ToString()
                            });
                            
                        }
                    }
                }

            };
            
            
            return accounts;

            
        }
    }
}