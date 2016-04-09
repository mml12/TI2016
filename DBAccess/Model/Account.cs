using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess.Model
{
    public class Account
    {
        int id_accounts;
        string username, password, accrount_type;

        public enum account_types
        {
            admin, grent, func, client
        }

        public string Accrount_type
        {
            get { return accrount_type; }
            set { accrount_type = value; }
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
