using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mngrs.External_Classes;
using Mngrs;
using DBAccess.Model;
using DBAccess;
using System.Windows.Forms;

namespace SOVD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string msg = Connection.CreateConnection("root", "root@612", "opl");
            if (msg.ToLower() != "connected")
            {
                MessageBox.Show(msg, "Error");
                Application.Exit();
            }

            WatermarkExtension.SetWatermark(txtUsername, "username");
            WatermarkExtension.SetWatermark(txtPassword, "password");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AccountsDAO accountsDao = new AccountsDAO();
            DataTable table = accountsDao.Select_All();
            if (table.Rows.Count == 0)
            {
                accountsDao.insert(new Account()
                {
                    Username = CryptMngr.Encrypt("admin"),
                    Password = CryptMngr.Encrypt("admin"),
                    Account_type = (int)Account.account_types.admin
                });
                table = accountsDao.Select_All();
            }
            bool didFind = false;
            DataRow account = table.NewRow();

            foreach (DataRow item in table.Rows)
            {
                if (CryptMngr.Decrypt(item["username"].ToString()) == txtUsername.Text &&
                    CryptMngr.Decrypt(item["password"].ToString()) == txtPassword.Text)
                {
                    account = item;
                    didFind = true;
                    break;
                }
            }

            if (didFind)
                LogintoIt(account);
            else
            {
                MessageBox.Show("As credenciais inseridas não correspondem a nenhuma conta", "Erro de Login");
                txtPassword.Clear();
                txtUsername.Clear();
            }
        }

        private void LogintoIt(DataRow account)
        {
            frmMain frm = new frmMain(account);
            frm.Show(this);
            this.Hide();
        }
    }
}
