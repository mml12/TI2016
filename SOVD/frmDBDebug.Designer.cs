namespace SOVD
{
    partial class frmDBDebug
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
            this.cmbTables = new System.Windows.Forms.ComboBox();
            this.gvTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbTables
            // 
            this.cmbTables.FormattingEnabled = true;
            this.cmbTables.Location = new System.Drawing.Point(12, 12);
            this.cmbTables.Name = "cmbTables";
            this.cmbTables.Size = new System.Drawing.Size(242, 21);
            this.cmbTables.TabIndex = 0;
            this.cmbTables.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // gvTable
            // 
            this.gvTable.AllowUserToAddRows = false;
            this.gvTable.AllowUserToDeleteRows = false;
            this.gvTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gvTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvTable.Location = new System.Drawing.Point(12, 39);
            this.gvTable.Name = "gvTable";
            this.gvTable.ReadOnly = true;
            this.gvTable.Size = new System.Drawing.Size(951, 483);
            this.gvTable.TabIndex = 1;
            // 
            // frmDBDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 534);
            this.Controls.Add(this.gvTable);
            this.Controls.Add(this.cmbTables);
            this.Name = "frmDBDebug";
            this.Text = "frmDBDebug";
            this.Load += new System.EventHandler(this.frmDBDebug_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTables;
        private System.Windows.Forms.DataGridView gvTable;
    }
}