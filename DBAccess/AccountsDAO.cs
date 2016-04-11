using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    public class AccountsDAO : DAO
    {
        public DataTable Select_All()
        {
            return loadTable("SELECT id_accounts, username, password, account_type FROM accounts;");
        }

        public void insert(Model.Account account)
        {
            loadTable("Insert into accounts(username, password, account_type) "
                + "values('" + account.Username + "','" + account.Password + "','" + account.Account_type + "')");
        }
    }
}
