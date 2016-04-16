using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DBAccess;
using DBAccess.Model;
using Mngrs.External_Classes;
using Mngrs;

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

        private void frmMain_Load(object sender, EventArgs e)
        {
            tsmiAccountName.Text = CryptMngr.Decrypt(account["username"].ToString());
        }

        /// <summary>
        /// Analisa se a conta logada tem o nivel de acesso que vc esta pedindo
        /// </summary>
        /// <param name="Level"></param>
        /// <returns></returns>
        private bool validateLevelAccess(Account.account_types Level)
        {
            Account.account_types current = 0; //cliente
            current = (Account.account_types)int.Parse(account["account_type"].ToString());

            if (current >= Level)
                return true;
            return false;
        }

        /// <summary>
        /// Esconde todos os paineis ao mesmo tempo que muda sua localização para 12,27. depois torna o controle escolhido visivel
        /// </summary>
        /// <param name="ctr"></param>
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
        /// <summary>
        /// fecha a aplicação
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDBDebug_Click(object sender, EventArgs e)
        {
            if (validateLevelAccess(Account.account_types.gerente))
            {
                frmDBDebug frm = new frmDBDebug();
                frm.ShowDialog(this);
            }
            else
                //melhorar essa mensagem, pelamor
                MessageBox.Show("A conta atual não atinge os requisitos minimos para acessar essa funcionalidade");
        }

        /// <summary>
        /// methodo comum entre os botoes cancelar, serve pra esconder todos os paineis
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowMenu_Click(object sender, EventArgs e)
        {
            panelVibility(new Control());
        }
        #endregion

        #region "btnCalls"
        private void btnPnl1_Click(object sender, EventArgs e)
        {
            pcnuCall();
        }

        private void btnPnl2_Click(object sender, EventArgs e)
        {
            pcpCall();
        }
        #endregion

        #region "pnlCadNewUser"
        /// <summary>
        /// Construtor do painel de cadastro
        /// </summary>
        private void pcnuCall()
        {
            panelVibility(pnlCadNewUser);
            WatermarkExtension.SetWatermark(txtCadUsername, "Username");
            WatermarkExtension.SetWatermark(txtCadPassword, "Password");
            WatermarkExtension.SetWatermark(txtCadCliEmail, "Email");
        }

        /// <summary>
        /// Cadastra as informações dadas no banco de dados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCadNewUser_Click(object sender, EventArgs e)
        {
            AccountsDAO accounts = new AccountsDAO();
            accounts.insert(new Account()
            {
                Username = CryptMngr.Encrypt(txtCadUsername.Text),
                Password = CryptMngr.Encrypt(txtCadPassword.Text),
                Account_type = cmbCadAccType.SelectedIndex
            });
            //cadastra a parte do cliente
            if (cmbCadAccType.SelectedIndex == 0)
            {
                ClienteDAO cliente = new ClienteDAO();
                cliente.insert(new Cliente()
                {
                    IdAccount = int.Parse(
                        accounts.loadTable("Select id_accounts from accounts where username = '"
                        + CryptMngr.Encrypt(txtCadUsername.Text) + "'").Rows[0]["id_accounts"].ToString()),
                    Email = CryptMngr.Encrypt(txtCadCliEmail.Text)
                }); 
            }
        }

        /// <summary>
        /// muda a visibilidade dos grpbox conforme o tipo da conta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCadAccType_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control item in pnlCadNewUser.Controls)
            {
                if (item.Name.StartsWith("grpCad"))
                    item.Enabled = false;
            }
            switch (cmbCadAccType.SelectedIndex)
            {
                case 0:
                    grpCadCliente.Enabled = true;
                    break;
                case 1:
                    grpCadFunc.Enabled = true;
                    break;
                case 2:
                    grpCadGrent.Enabled = true;
                    break;
                case 3:
                    grpCadAdmin.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        #endregion

        #region "pnlCadProd"
        private void pcpCall()
        {
            panelVibility(pnlCadProd);
        }
        #endregion
    }
}
