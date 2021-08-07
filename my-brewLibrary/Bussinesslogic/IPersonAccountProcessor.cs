using System.Collections.Generic;
using my_brewLibrary.Models;

namespace my_brewLibrary.Bussinesslogic
{
    public interface IPersonAccountProcessor
    {
         public List<PersonAccount> GetPersonAccounts(string connStr);
    }
}