using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBAccess.Model;

namespace SOVD
{
    public partial class frmMain : Form
    {
        DataRow account;
        #region "Geral"
        public frmMain(DataRow account)
        {
            this.account = account;
            InitializeComponent();
            panelVibility(new Control());
        }

        private bool validateAdminAccess(Account.account_types Level)
        {
            if (account["account_type"].ToString() == Level.ToString())
                return true;
            return false;
        }

        private void panelVibility(Control ctr)
        {
            foreach (Control item in this.Controls)
            {
                if (item.Name.StartsWith("pnl"))
                {
                    item.Location = new Point(12, 27);
                    item.Visible = false;
                }
            }

            ctr.Visible = true;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDBDebug_Click(object sender, EventArgs e)
        {
            frmDBDebug frm = new frmDBDebug();
            frm.ShowDialog(this);
        }

        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            panelVibility(new Control());
        }
        #endregion

        private void btnPnl1_Click(object sender, EventArgs e)
        {
            panelVibility(pnl1);
        }

        private void btnPnl2_Click(object sender, EventArgs e)
        {
            panelVibility(pnl2);
        }
    }
}
