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
            this.lblLog = new System.Windows.Forms.Label();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.txbDBName = new System.Windows.Forms.TextBox();
            this.btnSelectDB = new System.Windows.Forms.Button();
            this.lblCurrentDB = new System.Windows.Forms.Label();
            this.btnCreateTable = new System.Windows.Forms.Button();
            this.lblDatabaseInput = new System.Windows.Forms.Label();
            this.btnDeleteDB = new System.Windows.Forms.Button();
            this.btnCreateDB = new System.Windows.Forms.Button();
            this.lblCurrentTable = new System.Windows.Forms.Label();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.btnSelectTable = new System.Windows.Forms.Button();
            this.listDatabases = new System.Windows.Forms.TreeView();
            this.cbxMessages = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(219, 217);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(75, 23);
            this.btnDisconnect.TabIndex = 0;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // lblLog
            // 
            this.lblLog.AutoSize = true;
            this.lblLog.Location = new System.Drawing.Point(20, 190);
            this.lblLog.Name = "lblLog";
            this.lblLog.Size = new System.Drawing.Size(26, 13);
            this.lblLog.TabIndex = 5;
            this.lblLog.Text = "logs";
            // 
            // txbTableName
            // 
            this.txbTableName.Location = new System.Drawing.Point(25, 125);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(134, 20);
            this.txbTableName.TabIndex = 10;
            // 
            // txbDBName
            // 
            this.txbDBName.Location = new System.Drawing.Point(25, 41);
            this.txbDBName.Name = "txbDBName";
            this.txbDBName.Size = new System.Drawing.Size(136, 20);
            this.txbDBName.TabIndex = 9;
            // 
            // btnSelectDB
            // 
            this.btnSelectDB.Location = new System.Drawing.Point(672, 50);
            this.btnSelectDB.Name = "btnSelectDB";
            this.btnSelectDB.Size = new System.Drawing.Size(136, 23);
            this.btnSelectDB.TabIndex = 7;
            this.btnSelectDB.Text = "Select Database";
            this.btnSelectDB.UseVisualStyleBackColor = true;
            this.btnSelectDB.Click += new System.EventHandler(this.BtnSelectDB_Click);
            // 
            // lblCurrentDB
            // 
            this.lblCurrentDB.AutoSize = true;
            this.lblCurrentDB.Location = new System.Drawing.Point(204, 44);
            this.lblCurrentDB.Name = "lblCurrentDB";
            this.lblCurrentDB.Size = new System.Drawing.Size(109, 13);
            this.lblCurrentDB.TabIndex = 8;
            this.lblCurrentDB.Text = "Currently using : none";
            // 
            // btnCreateTable
            // 
            this.btnCreateTable.Location = new System.Drawing.Point(25, 158);
            this.btnCreateTable.Name = "btnCreateTable";
            this.btnCreateTable.Size = new System.Drawing.Size(136, 22);
            this.btnCreateTable.TabIndex = 6;
            this.btnCreateTable.Text = "Create Table";
            this.btnCreateTable.UseVisualStyleBackColor = true;
            this.btnCreateTable.Click += new System.EventHandler(this.BtnCreateTable_Click);
            // 
            // lblDatabaseInput
            // 
            this.lblDatabaseInput.AutoSize = true;
            this.lblDatabaseInput.Location = new System.Drawing.Point(22, 109);
            this.lblDatabaseInput.Name = "lblDatabaseInput";
            this.lblDatabaseInput.Size = new System.Drawing.Size(59, 13);
            this.lblDatabaseInput.TabIndex = 11;
            this.lblDatabaseInput.Text = "Database :";
            // 
            // btnDeleteDB
            // 
            this.btnDeleteDB.Location = new System.Drawing.Point(177, 74);
            this.btnDeleteDB.Name = "btnDeleteDB";
            this.btnDeleteDB.Size = new System.Drawing.Size(136, 23);
            this.btnDeleteDB.TabIndex = 13;
            this.btnDeleteDB.Text = "Delete Database";
            this.btnDeleteDB.UseVisualStyleBackColor = true;
            this.btnDeleteDB.Click += new System.EventHandler(this.BtnDeleteDB_Click);
            // 
            // btnCreateDB
            // 
            this.btnCreateDB.Location = new System.Drawing.Point(25, 74);
            this.btnCreateDB.Name = "btnCreateDB";
            this.btnCreateDB.Size = new System.Drawing.Size(136, 23);
            this.btnCreateDB.TabIndex = 14;
            this.btnCreateDB.Text = "Create Database";
            this.btnCreateDB.UseVisualStyleBackColor = true;
            this.btnCreateDB.Click += new System.EventHandler(this.BtnCreateDB_Click);
            // 
            // lblCurrentTable
            // 
            this.lblCurrentTable.AutoSize = true;
            this.lblCurrentTable.Location = new System.Drawing.Point(204, 132);
            this.lblCurrentTable.Name = "lblCurrentTable";
            this.lblCurrentTable.Size = new System.Drawing.Size(109, 13);
            this.lblCurrentTable.TabIndex = 15;
            this.lblCurrentTable.Text = "Currently using : none";
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Enabled = false;
            this.btnDeleteTable.Location = new System.Drawing.Point(178, 158);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(135, 23);
            this.btnDeleteTable.TabIndex = 16;
            this.btnDeleteTable.Text = "Delete Table";
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            this.btnDeleteTable.Click += new System.EventHandler(this.BtnDeleteTable_Click);
            // 
            // btnSelectTable
            // 
            this.btnSelectTable.Location = new System.Drawing.Point(795, 152);
            this.btnSelectTable.Name = "btnSelectTable";
            this.btnSelectTable.Size = new System.Drawing.Size(136, 23);
            this.btnSelectTable.TabIndex = 17;
            this.btnSelectTable.Text = "Select Table";
            this.btnSelectTable.UseVisualStyleBackColor = true;
            this.btnSelectTable.Click += new System.EventHandler(this.BtnSelectTable_Click);
            // 
            // listDatabases
            // 
            this.listDatabases.Location = new System.Drawing.Point(23, 297);
            this.listDatabases.Name = "listDatabases";
            this.listDatabases.Size = new System.Drawing.Size(476, 278);
            this.listDatabases.TabIndex = 20;
            this.listDatabases.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ListDatabases_Databases);
            // 
            // cbxMessages
            // 
            this.cbxMessages.AutoSize = true;
            this.cbxMessages.Checked = true;
            this.cbxMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMessages.Location = new System.Drawing.Point(419, 246);
            this.cbxMessages.Name = "cbxMessages";
            this.cbxMessages.Size = new System.Drawing.Size(75, 17);
            this.cbxMessages.TabIndex = 21;
            this.cbxMessages.Text = "Textboxes";
            this.cbxMessages.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbxMessages.UseVisualStyleBackColor = true;
            this.cbxMessages.CheckedChanged += new System.EventHandler(this.Messages_CheckedChanged);
            // 
            // ActionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 597);
            this.Controls.Add(this.cbxMessages);
            this.Controls.Add(this.listDatabases);
            this.Controls.Add(this.btnSelectTable);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.lblCurrentTable);
            this.Controls.Add(this.btnCreateDB);
            this.Controls.Add(this.btnDeleteDB);
            this.Controls.Add(this.lblDatabaseInput);
            this.Controls.Add(this.txbTableName);
            this.Controls.Add(this.txbDBName);
            this.Controls.Add(this.btnSelectDB);
            this.Controls.Add(this.lblCurrentDB);
            this.Controls.Add(this.btnCreateTable);
            this.Controls.Add(this.lblLog);
            this.Controls.Add(this.btnDisconnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionsView";
            this.Text = "Connect to MySQL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ActionsView_FormClosed);
            this.Load += new System.EventHandler(this.ActionsView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Label lblLog;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.TextBox txbDBName;
        private System.Windows.Forms.Button btnSelectDB;
        private System.Windows.Forms.Label lblCurrentDB;
        private System.Windows.Forms.Button btnCreateTable;
        private System.Windows.Forms.Label lblDatabaseInput;
        private System.Windows.Forms.Button btnDeleteDB;
        private System.Windows.Forms.Button btnCreateDB;
        private System.Windows.Forms.Label lblCurrentTable;
        private System.Windows.Forms.Button btnDeleteTable;
        private System.Windows.Forms.Button btnSelectTable;
        private System.Windows.Forms.TreeView listDatabases;
        private System.Windows.Forms.CheckBox cbxMessages;
    }
}

