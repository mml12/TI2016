using DBAccess.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBAccess
{
    public class ClienteDAO : DAO
    {
        public DataTable Select_All()
        {
            return loadTable("SELECT id_cliente, id_accounts, email FROM clientes");
        }

        public void insert(Cliente cli)
        {
            loadTable("INSERT INTO clientes(id_accounts, email) "
                + "VALUES('" + cli.IdAccount + "','" + cli.Email + "')");
        }
    }
}
