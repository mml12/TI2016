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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Arraste um arquivo aqui");
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiAccountName = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.trocarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDBDebug = new System.Windows.Forms.Button();
            this.btnPnl1 = new System.Windows.Forms.Button();
            this.btnPnl2 = new System.Windows.Forms.Button();
            this.pnlCadNewUser = new System.Windows.Forms.Panel();
            this.grpCadAdmin = new System.Windows.Forms.GroupBox();
            this.grpCadGrent = new System.Windows.Forms.GroupBox();
            this.grpCadFunc = new System.Windows.Forms.GroupBox();
            this.grpCadCliente = new System.Windows.Forms.GroupBox();
            this.txtCadCliEmail = new System.Windows.Forms.TextBox();
            this.cmbCadAccType = new System.Windows.Forms.ComboBox();
            this.txtCadPassword = new System.Windows.Forms.TextBox();
            this.txtCadUsername = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnCadNewUser = new System.Windows.Forms.Button();
            this.pnlCadProd = new System.Windows.Forms.Panel();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.picCover = new System.Windows.Forms.PictureBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubT = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAutors = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSinopse = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lstDragDropFile = new System.Windows.Forms.ListView();
            this.btnCancel2 = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCadProd = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.pnlCadNewUser.SuspendLayout();
            this.grpCadCliente.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlCadProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAccountName});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(766, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAccountName
            // 
            this.tsmiAccountName.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.trocarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.tsmiAccountName.Name = "tsmiAccountName";
            this.tsmiAccountName.Size = new System.Drawing.Size(96, 20);
            this.tsmiAccountName.Text = "AccountName";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(146, 6);
            // 
            // trocarToolStripMenuItem
            // 
            this.trocarToolStripMenuItem.Name = "trocarToolStripMenuItem";
            this.trocarToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.trocarToolStripMenuItem.Text = "Trocar usuario";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.sairToolStripMenuItem.Text = "Sair";
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
            this.btnPnl2.Text = "btnPnlCadProd";
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
            this.pnlCadNewUser.Location = new System.Drawing.Point(763, 27);
            this.pnlCadNewUser.Name = "pnlCadNewUser";
            this.pnlCadNewUser.Size = new System.Drawing.Size(742, 412);
            this.pnlCadNewUser.TabIndex = 4;
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
            // txtCadCliEmail
            // 
            this.txtCadCliEmail.Location = new System.Drawing.Point(6, 19);
            this.txtCadCliEmail.Name = "txtCadCliEmail";
            this.txtCadCliEmail.Size = new System.Drawing.Size(153, 20);
            this.txtCadCliEmail.TabIndex = 4;
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
            // pnlCadProd
            // 
            this.pnlCadProd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCadProd.BackColor = System.Drawing.SystemColors.Control;
            this.pnlCadProd.Controls.Add(this.btnCadProd);
            this.pnlCadProd.Controls.Add(this.label11);
            this.pnlCadProd.Controls.Add(this.cmbType);
            this.pnlCadProd.Controls.Add(this.txtEdition);
            this.pnlCadProd.Controls.Add(this.label10);
            this.pnlCadProd.Controls.Add(this.txtGenero);
            this.pnlCadProd.Controls.Add(this.label9);
            this.pnlCadProd.Controls.Add(this.picCover);
            this.pnlCadProd.Controls.Add(this.txtYear);
            this.pnlCadProd.Controls.Add(this.label8);
            this.pnlCadProd.Controls.Add(this.label7);
            this.pnlCadProd.Controls.Add(this.txtSubT);
            this.pnlCadProd.Controls.Add(this.txtEditora);
            this.pnlCadProd.Controls.Add(this.label6);
            this.pnlCadProd.Controls.Add(this.txtAutors);
            this.pnlCadProd.Controls.Add(this.label5);
            this.pnlCadProd.Controls.Add(this.txtSinopse);
            this.pnlCadProd.Controls.Add(this.label4);
            this.pnlCadProd.Controls.Add(this.txtPrice);
            this.pnlCadProd.Controls.Add(this.label3);
            this.pnlCadProd.Controls.Add(this.label2);
            this.pnlCadProd.Controls.Add(this.txtTitle);
            this.pnlCadProd.Controls.Add(this.label1);
            this.pnlCadProd.Controls.Add(this.txtFile);
            this.pnlCadProd.Controls.Add(this.button1);
            this.pnlCadProd.Controls.Add(this.lstDragDropFile);
            this.pnlCadProd.Controls.Add(this.btnCancel2);
            this.pnlCadProd.Location = new System.Drawing.Point(12, 27);
            this.pnlCadProd.Name = "pnlCadProd";
            this.pnlCadProd.Size = new System.Drawing.Size(742, 415);
            this.pnlCadProd.TabIndex = 5;
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(446, 136);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(115, 20);
            this.txtEdition.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(397, 139);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Edição:";
            // 
            // txtGenero
            // 
            this.txtGenero.Location = new System.Drawing.Point(97, 204);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(294, 20);
            this.txtGenero.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Genero(s):";
            // 
            // picCover
            // 
            this.picCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCover.Location = new System.Drawing.Point(567, 32);
            this.picCover.Name = "picCover";
            this.picCover.Size = new System.Drawing.Size(172, 217);
            this.picCover.TabIndex = 21;
            this.picCover.TabStop = false;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(446, 102);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(115, 20);
            this.txtYear.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(397, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Ano:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Subtitulo:";
            // 
            // txtSubT
            // 
            this.txtSubT.Location = new System.Drawing.Point(97, 102);
            this.txtSubT.Name = "txtSubT";
            this.txtSubT.Size = new System.Drawing.Size(294, 20);
            this.txtSubT.TabIndex = 17;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(97, 170);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(294, 20);
            this.txtEditora.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Editora:";
            // 
            // txtAutors
            // 
            this.txtAutors.Location = new System.Drawing.Point(97, 136);
            this.txtAutors.Name = "txtAutors";
            this.txtAutors.Size = new System.Drawing.Size(294, 20);
            this.txtAutors.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Autor(es):";
            // 
            // txtSinopse
            // 
            this.txtSinopse.Location = new System.Drawing.Point(42, 257);
            this.txtSinopse.Multiline = true;
            this.txtSinopse.Name = "txtSinopse";
            this.txtSinopse.Size = new System.Drawing.Size(519, 144);
            this.txtSinopse.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sinopse:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(446, 68);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(115, 20);
            this.txtPrice.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Titulo:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(97, 68);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(294, 20);
            this.txtTitle.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Arquivo:";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(97, 34);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(383, 20);
            this.txtFile.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Procurar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lstDragDropFile
            // 
            this.lstDragDropFile.BackColor = System.Drawing.SystemColors.Control;
            this.lstDragDropFile.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstDragDropFile.LabelWrap = false;
            this.lstDragDropFile.Location = new System.Drawing.Point(612, 255);
            this.lstDragDropFile.MultiSelect = false;
            this.lstDragDropFile.Name = "lstDragDropFile";
            this.lstDragDropFile.Size = new System.Drawing.Size(127, 128);
            this.lstDragDropFile.TabIndex = 3;
            this.lstDragDropFile.UseCompatibleStateImageBehavior = false;
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
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.Items.AddRange(new object[] {
            "Revista",
            "Livro",
            "Quadrinhos"});
            this.cmbType.Location = new System.Drawing.Point(446, 168);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(115, 21);
            this.cmbType.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(397, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Tipo:";
            // 
            // btnCadProd
            // 
            this.btnCadProd.Location = new System.Drawing.Point(583, 389);
            this.btnCadProd.Name = "btnCadProd";
            this.btnCadProd.Size = new System.Drawing.Size(75, 23);
            this.btnCadProd.TabIndex = 27;
            this.btnCadProd.Text = "Cadastrar";
            this.btnCadProd.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 467);
            this.Controls.Add(this.pnlCadProd);
            this.Controls.Add(this.pnlCadNewUser);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.flpMenu);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flpMenu.ResumeLayout(false);
            this.pnlCadNewUser.ResumeLayout(false);
            this.pnlCadNewUser.PerformLayout();
            this.grpCadCliente.ResumeLayout(false);
            this.grpCadCliente.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlCadProd.ResumeLayout(false);
            this.pnlCadProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Button btnDBDebug;
        private System.Windows.Forms.Panel pnlCadNewUser;
        private System.Windows.Forms.Panel pnlCadProd;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiAccountName;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem trocarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ListView lstDragDropFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picCover;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubT;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAutors;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSinopse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnCadProd;
    }
}