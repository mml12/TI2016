using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOVD
{
    public partial class frmDBDebug : Form
    {
        public frmDBDebug()
        {
            InitializeComponent();
        }

        DBAccess.DAO dao = new DBAccess.DAO();
        private void frmDBDebug_Load(object sender, EventArgs e)
        {
            DataTable table = dao.loadTable("show tables");
            foreach (DataRow item in table.Rows)
            {
                cmbTables.Items.Add(item[0].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTables.SelectedIndex == -1)
                return;

            gvTable.DataSource = dao.loadTable("Select * from " + cmbTables.Text);
        }
    }
}
