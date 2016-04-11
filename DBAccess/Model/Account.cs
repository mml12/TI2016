using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Model
{
    public class Account
    {
        int id_accounts, account_type;
        string username, password;

        public enum account_types
        {
            admin = 3, gerente = 2, funcionario = 1, cliente = 0
        }

        public int Account_type
        {
            get { return account_type; }
            set { account_type = value; }
        }

        public int Id_accounts
        {
            get { return id_accounts; }
            set { id_accounts = value; }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }
    }
}
