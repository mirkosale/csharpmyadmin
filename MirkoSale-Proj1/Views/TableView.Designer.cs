namespace MirkoSale_MySQL
{
    partial class TableView
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
            this.cbxMessages = new System.Windows.Forms.CheckBox();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.listTable = new System.Windows.Forms.DataGridView();
            this.btnAddData = new System.Windows.Forms.Button();
            this.btnAddRowWithAutoIncID = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listTable)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxMessages
            // 
            this.cbxMessages.AutoSize = true;
            this.cbxMessages.Checked = true;
            this.cbxMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMessages.Location = new System.Drawing.Point(530, 440);
            this.cbxMessages.Name = "cbxMessages";
            this.cbxMessages.Size = new System.Drawing.Size(74, 17);
            this.cbxMessages.TabIndex = 23;
            this.cbxMessages.Text = "Messages";
            this.cbxMessages.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbxMessages.UseVisualStyleBackColor = true;
            this.cbxMessages.CheckedChanged += new System.EventHandler(this.CbxMessages_CheckedChanged);
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(78, 436);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(96, 23);
            this.btnAddColumn.TabIndex = 26;
            this.btnAddColumn.Text = "Add column";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.BtnAddColumn_Click);
            // 
            // listTable
            // 
            this.listTable.AllowUserToAddRows = false;
            this.listTable.AllowUserToDeleteRows = false;
            this.listTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listTable.Location = new System.Drawing.Point(12, 12);
            this.listTable.Name = "listTable";
            this.listTable.ReadOnly = true;
            this.listTable.Size = new System.Drawing.Size(615, 400);
            this.listTable.TabIndex = 27;
            this.listTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListTable_MouseClick);
            // 
            // btnAddData
            // 
            this.btnAddData.Location = new System.Drawing.Point(196, 436);
            this.btnAddData.Name = "btnAddData";
            this.btnAddData.Size = new System.Drawing.Size(146, 23);
            this.btnAddData.TabIndex = 28;
            this.btnAddData.Text = "Add rows of data";
            this.btnAddData.UseVisualStyleBackColor = true;
            this.btnAddData.Click += new System.EventHandler(this.BtnAddData_Click);
            // 
            // btnAddRowWithAutoIncID
            // 
            this.btnAddRowWithAutoIncID.Location = new System.Drawing.Point(359, 436);
            this.btnAddRowWithAutoIncID.Name = "btnAddRowWithAutoIncID";
            this.btnAddRowWithAutoIncID.Size = new System.Drawing.Size(143, 23);
            this.btnAddRowWithAutoIncID.TabIndex = 29;
            this.btnAddRowWithAutoIncID.Text = "Add rows with auto inc. ID";
            this.btnAddRowWithAutoIncID.UseVisualStyleBackColor = true;
            this.btnAddRowWithAutoIncID.Click += new System.EventHandler(this.BtnAddRowWithAutoIncID_Click);
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 502);
            this.Controls.Add(this.btnAddRowWithAutoIncID);
            this.Controls.Add(this.btnAddData);
            this.Controls.Add(this.listTable);
            this.Controls.Add(this.btnAddColumn);
            this.Controls.Add(this.cbxMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableView";
            this.Text = "CSharpMyAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TableView_FormClosed);
            this.Load += new System.EventHandler(this.TableView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox cbxMessages;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.DataGridView listTable;
        private System.Windows.Forms.Button btnAddData;
        private System.Windows.Forms.Button btnAddRowWithAutoIncID;
    }
}