namespace SOVD
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDBDebug = new System.Windows.Forms.Button();
            this.btnPnl1 = new System.Windows.Forms.Button();
            this.btnPnl2 = new System.Windows.Forms.Button();
            this.pnlCadNewUser = new System.Windows.Forms.Panel();
            this.cmbCadAccType = new System.Windows.Forms.ComboBox();
            this.txtCadPassword = new System.Windows.Forms.TextBox();
            this.txtCadUsername = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnCadNewUser = new System.Windows.Forms.Button();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grpCadCliente = new System.Windows.Forms.GroupBox();
            this.grpCadFunc = new System.Windows.Forms.GroupBox();
            this.grpCadGrent = new System.Windows.Forms.GroupBox();
            this.grpCadAdmin = new System.Windows.Forms.GroupBox();
            this.txtCadCliEmail = new System.Windows.Forms.TextBox();
            this.flpMenu.SuspendLayout();
            this.pnlCadNewUser.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnl2.SuspendLayout();
            this.grpCadCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 445);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(766, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // flpMenu
            // 
            this.flpMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpMenu.Controls.Add(this.btnDBDebug);
            this.flpMenu.Controls.Add(this.btnPnl1);
            this.flpMenu.Controls.Add(this.btnPnl2);
            this.flpMenu.Location = new System.Drawing.Point(12, 27);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(742, 415);
            this.flpMenu.TabIndex = 2;
            // 
            // btnDBDebug
            // 
            this.btnDBDebug.Location = new System.Drawing.Point(3, 3);
            this.btnDBDebug.Name = "btnDBDebug";
            this.btnDBDebug.Size = new System.Drawing.Size(108, 23);
            this.btnDBDebug.TabIndex = 0;
            this.btnDBDebug.Text = "frmDBDebug";
            this.btnDBDebug.UseVisualStyleBackColor = true;
            this.btnDBDebug.Click += new System.EventHandler(this.btnDBDebug_Click);
            // 
            // btnPnl1
            // 
            this.btnPnl1.Location = new System.Drawing.Point(117, 3);
            this.btnPnl1.Name = "btnPnl1";
            this.btnPnl1.Size = new System.Drawing.Size(108, 23);
            this.btnPnl1.TabIndex = 1;
            this.btnPnl1.Text = "btnPnlCadUser";
            this.btnPnl1.UseVisualStyleBackColor = true;
            this.btnPnl1.Click += new System.EventHandler(this.btnPnl1_Click);
            // 
            // btnPnl2
            // 
            this.btnPnl2.Location = new System.Drawing.Point(231, 3);
            this.btnPnl2.Name = "btnPnl2";
            this.btnPnl2.Size = new System.Drawing.Size(108, 23);
            this.btnPnl2.TabIndex = 2;
            this.btnPnl2.Text = "btnPnl2";
            this.btnPnl2.UseVisualStyleBackColor = true;
            this.btnPnl2.Click += new System.EventHandler(this.btnPnl2_Click);
            // 
            // pnlCadNewUser
            // 
            this.pnlCadNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCadNewUser.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCadNewUser.Controls.Add(this.grpCadAdmin);
            this.pnlCadNewUser.Controls.Add(this.grpCadGrent);
            this.pnlCadNewUser.Controls.Add(this.grpCadFunc);
            this.pnlCadNewUser.Controls.Add(this.grpCadCliente);
            this.pnlCadNewUser.Controls.Add(this.cmbCadAccType);
            this.pnlCadNewUser.Controls.Add(this.txtCadPassword);
            this.pnlCadNewUser.Controls.Add(this.txtCadUsername);
            this.pnlCadNewUser.Controls.Add(this.flowLayoutPanel1);
            this.pnlCadNewUser.Location = new System.Drawing.Point(12, 27);
            this.pnlCadNewUser.Name = "pnlCadNewUser";
            this.pnlCadNewUser.Size = new System.Drawing.Size(742, 412);
            this.pnlCadNewUser.TabIndex = 4;
            // 
            // cmbCadAccType
            // 
            this.cmbCadAccType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCadAccType.FormattingEnabled = true;
            this.cmbCadAccType.Items.AddRange(new object[] {
            "Cliente",
            "Funcionario",
            "Gerente",
            "Admin"});
            this.cmbCadAccType.Location = new System.Drawing.Point(37, 85);
            this.cmbCadAccType.Name = "cmbCadAccType";
            this.cmbCadAccType.Size = new System.Drawing.Size(121, 21);
            this.cmbCadAccType.TabIndex = 5;
            this.cmbCadAccType.SelectedIndexChanged += new System.EventHandler(this.cmbCadAccType_SelectedIndexChanged);
            // 
            // txtCadPassword
            // 
            this.txtCadPassword.Location = new System.Drawing.Point(37, 58);
            this.txtCadPassword.Name = "txtCadPassword";
            this.txtCadPassword.Size = new System.Drawing.Size(100, 20);
            this.txtCadPassword.TabIndex = 4;
            // 
            // txtCadUsername
            // 
            this.txtCadUsername.Location = new System.Drawing.Point(37, 32);
            this.txtCadUsername.Name = "txtCadUsername";
            this.txtCadUsername.Size = new System.Drawing.Size(100, 20);
            this.txtCadUsername.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnCancel1);
            this.flowLayoutPanel1.Controls.Add(this.btnCadNewUser);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 369);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(742, 43);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(664, 9);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 1;
            this.btnCancel1.Text = "Cancelar";
            this.btnCancel1.UseVisualStyleBackColor = true;
            this.btnCancel1.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // btnCadNewUser
            // 
            this.btnCadNewUser.Location = new System.Drawing.Point(583, 9);
            this.btnCadNewUser.Name = "btnCadNewUser";
            this.btnCadNewUser.Size = new System.Drawing.Size(75, 23);
            this.btnCadNewUser.TabIndex = 2;
            this.btnCadNewUser.Text = "Cadastrar";
            this.btnCadNewUser.UseVisualStyleBackColor = true;
            this.btnCadNewUser.Click += new System.EventHandler(this.btnCadNewUser_Click);
            // 
            // pnl2
            // 
            this.pnl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl2.BackColor = System.Drawing.SystemColors.Control;
            this.pnl2.Controls.Add(this.btnCancel2);
            this.pnl2.Controls.Add(this.label2);
            this.pnl2.Location = new System.Drawing.Point(763, 27);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(742, 415);
            this.pnl2.TabIndex = 5;
            // 
            // btnCancel2
            // 
            this.btnCancel2.Location = new System.Drawing.Point(664, 389);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(75, 23);
            this.btnCancel2.TabIndex = 2;
            this.btnCancel2.Text = "Cancelar";
            this.btnCancel2.UseVisualStyleBackColor = true;
            this.btnCancel2.Click += new System.EventHandler(this.btnShowMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "tudo bem?";
            // 
            // grpCadCliente
            // 
            this.grpCadCliente.Controls.Add(this.txtCadCliEmail);
            this.grpCadCliente.Enabled = false;
            this.grpCadCliente.Location = new System.Drawing.Point(37, 113);
            this.grpCadCliente.Name = "grpCadCliente";
            this.grpCadCliente.Size = new System.Drawing.Size(165, 250);
            this.grpCadCliente.TabIndex = 6;
            this.grpCadCliente.TabStop = false;
            this.grpCadCliente.Text = "grpCliente";
            // 
            // grpCadFunc
            // 
            this.grpCadFunc.Enabled = false;
            this.grpCadFunc.Location = new System.Drawing.Point(206, 113);
            this.grpCadFunc.Name = "grpCadFunc";
            this.grpCadFunc.Size = new System.Drawing.Size(165, 250);
            this.grpCadFunc.TabIndex = 7;
            this.grpCadFunc.TabStop = false;
            this.grpCadFunc.Text = "grpFunc";
            // 
            // grpCadGrent
            // 
            this.grpCadGrent.Enabled = false;
            this.grpCadGrent.Location = new System.Drawing.Point(376, 113);
            this.grpCadGrent.Name = "grpCadGrent";
            this.grpCadGrent.Size = new System.Drawing.Size(165, 250);
            this.grpCadGrent.TabIndex = 7;
            this.grpCadGrent.TabStop = false;
            this.grpCadGrent.Text = "grpGrent";
            // 
            // grpCadAdmin
            // 
            this.grpCadAdmin.Enabled = false;
            this.grpCadAdmin.Location = new System.Drawing.Point(546, 113);
            this.grpCadAdmin.Name = "grpCadAdmin";
            this.grpCadAdmin.Size = new System.Drawing.Size(165, 250);
            this.grpCadAdmin.TabIndex = 8;
            this.grpCadAdmin.TabStop = false;
            this.grpCadAdmin.Text = "grpAdmin";
            // 
            // txtCadCliEmail
            // 
            this.txtCadCliEmail.Location = new System.Drawing.Point(6, 19);
            this.txtCadCliEmail.Name = "txtCadCliEmail";
            this.txtCadCliEmail.Size = new System.Drawing.Size(153, 20);
            this.txtCadCliEmail.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 467);
            this.Controls.Add(this.pnl2);
            this.Controls.Add(this.pnlCadNewUser);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flpMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.flpMenu.ResumeLayout(false);
            this.pnlCadNewUser.ResumeLayout(false);
            this.pnlCadNewUser.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnl2.ResumeLayout(false);
            this.pnl2.PerformLayout();
            this.grpCadCliente.ResumeLayout(false);
            this.grpCadCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnDBDebug;
        private System.Windows.Forms.Panel pnlCadNewUser;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPnl1;
        private System.Windows.Forms.Button btnPnl2;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnCancel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnCadNewUser;
        private System.Windows.Forms.TextBox txtCadUsername;
        private System.Windows.Forms.ComboBox cmbCadAccType;
        private System.Windows.Forms.TextBox txtCadPassword;
        private System.Windows.Forms.GroupBox grpCadAdmin;
        private System.Windows.Forms.GroupBox grpCadGrent;
        private System.Windows.Forms.GroupBox grpCadFunc;
        private System.Windows.Forms.GroupBox grpCadCliente;
        private System.Windows.Forms.TextBox txtCadCliEmail;
    }
}