namespace MirkoSale_MySQL
{
    partial class ActionsView
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.txbDBName = new System.Windows.Forms.TextBox();
            this.lblCurrentDB = new System.Windows.Forms.Label();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.lblDatabaseInput = new System.Windows.Forms.Label();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.lblCurrentTable = new System.Windows.Forms.Label();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.listDatabases = new System.Windows.Forms.TreeView();
            this.cbxMessages = new System.Windows.Forms.CheckBox();
            this.btnEditTable = new System.Windows.Forms.Button();
            this.lblTableInput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(59, 228);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 7;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // txbTableName
            // 
            this.txbTableName.Location = new System.Drawing.Point(25, 118);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(134, 20);
            this.txbTableName.TabIndex = 3;
            // 
            // txbDBName
            // 
            this.txbDBName.Location = new System.Drawing.Point(25, 34);
            this.txbDBName.Name = "txbDBName";
            this.txbDBName.Size = new System.Drawing.Size(136, 20);
            this.txbDBName.TabIndex = 0;
            // 
            // lblCurrentDB
            // 
            this.lblCurrentDB.AutoSize = true;
            this.lblCurrentDB.Location = new System.Drawing.Point(204, 37);
            this.lblCurrentDB.Name = "lblCurrentDB";
            this.lblCurrentDB.Size = new System.Drawing.Size(109, 13);
            this.lblCurrentDB.TabIndex = 8;
            this.lblCurrentDB.Text = "Currently using : none";
            this.lblCurrentDB.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(25, 151);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(136, 22);
            this.btnCreateTable.TabIndex = 4;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.BtnCreateTable_Click);
            // 
            // lblDatabaseInput
            // 
            this.lblDatabaseInput.AutoSize = true;
            this.lblDatabaseInput.Location = new System.Drawing.Point(22, 17);
            this.lblDatabaseInput.Name = "lblDatabaseInput";
            this.lblDatabaseInput.Size = new System.Drawing.Size(59, 13);
            this.lblDatabaseInput.TabIndex = 11;
            this.lblDatabaseInput.Text = "Database :";
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.Location = new System.Drawing.Point(177, 67);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteDB.TabIndex = 2;
            this.btnDeleteDB.Text = "Delete Database";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.BtnDeleteDB_Click);
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(25, 67);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(136, 23);
            this.btnCreateDB.TabIndex = 1;
            this.btnCreateDB.Text = "Create Database";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.BtnCreateDB_Click);
            // 
            // lblCurrentTable
            // 
            this.lblCurrentTable.AutoSize = true;
            this.lblCurrentTable.Location = new System.Drawing.Point(204, 125);
            this.lblCurrentTable.Name = "lblCurrentTable";
            this.lblCurrentTable.Size = new System.Drawing.Size(109, 13);
            this.lblCurrentTable.TabIndex = 15;
            this.lblCurrentTable.Text = "Currently using : none";
            this.lblCurrentTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Enabled = false;
            this.btnDeleteTable.Location = new System.Drawing.Point(178, 151);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(135, 23);
            this.btnDeleteTable.TabIndex = 5;
            this.btnDeleteTable.Text = "Delete Table";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.BtnDeleteTable_Click);
            // 
            // listDatabases
            // 
            this.listDatabases.Location = new System.Drawing.Point(23, 269);
            this.listDatabases.Name = "listDatabases";
            this.listDatabases.Size = new System.Drawing.Size(290, 306);
            this.listDatabases.TabIndex = 9;
            this.listDatabases.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ListDatabases_Click);
            this.listDatabases.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ListDatabases_NodeMouseDoubleClick);
            // 
            // cbxMessages
            // 
            this.cbxMessages.AutoSize = true;
            this.cbxMessages.Checked = true;
            this.cbxMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMessages.Location = new System.Drawing.Point(207, 234);
            this.cbxMessages.Name = "cbxMessages";
            this.cbxMessages.Size = new System.Drawing.Size(74, 17);
            this.cbxMessages.TabIndex = 8;
            this.cbxMessages.Text = "Messages";
            this.cbxMessages.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbxMessages.UseVisualStyleBackColor = true;
            this.cbxMessages.CheckedChanged += new System.EventHandler(this.Messages_CheckedChanged);
            // 
            // btnEditTable
            // 
            this.btnEditTable.Enabled = false;
            this.btnEditTable.Location = new System.Drawing.Point(25, 189);
            this.btnEditTable.Name = "btnEditTable";
            this.btnEditTable.Size = new System.Drawing.Size(136, 22);
            this.btnEditTable.TabIndex = 6;
            this.btnEditTable.Text = "Modify Table";
            this.btnEditTable.UseVisualStyleBackColor = true;
            this.btnEditTable.Click += new System.EventHandler(this.BtnEditTable_Click);
            // 
            // lblTableInput
            // 
            this.lblTableInput.AutoSize = true;
            this.lblTableInput.Location = new System.Drawing.Point(22, 102);
            this.lblTableInput.Name = "lblTableInput";
            this.lblTableInput.Size = new System.Drawing.Size(40, 13);
            this.lblTableInput.TabIndex = 16;
            this.lblTableInput.Text = "Table :";
            // 
            // ActionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 597);
            this.Controls.Add(this.lblTableInput);
            this.Controls.Add(this.btnEditTable);
            this.Controls.Add(this.cbxMessages);
            this.Controls.Add(this.listDatabases);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.lblCurrentTable);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.lblDatabaseInput);
            this.Controls.Add(this.txbTableName);
            this.Controls.Add(this.txbDBName);
            this.Controls.Add(this.lblCurrentDB);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.btnDisconnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionsView";
            this.Text = "CSharpMyAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActionsView_FormClosed);
            this.Load += new System.EventHandler(this.ActionsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.TextBox txbDBName;
        private System.Windows.Forms.Label lblCurrentDB;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Label lblDatabaseInput;
        private System.Windows.Forms.Button btnDeleteDB;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Label lblCurrentTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.TreeView listDatabases;
        private System.Windows.Forms.CheckBox cbxMessages;
        private System.Windows.Forms.Button btnEditTable;
        private System.Windows.Forms.Label lblTableInput;
    }
}

