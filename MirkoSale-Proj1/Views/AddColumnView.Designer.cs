namespace MirkoSale_MySQL
{
    partial class AddColumnView
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
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.cbxListTypes = new System.Windows.Forms.ComboBox();
            this.cbxMessages = new System.Windows.Forms.CheckBox();
            this.txbColumnName = new System.Windows.Forms.TextBox();
            this.txbLength = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(130, 86);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(75, 23);
            this.btnAddColumn.TabIndex = 29;
            this.btnAddColumn.Text = "Add column";
            this.btnAddColumn.UseVisualStyleBackColor = true;
            this.btnAddColumn.Click += new System.EventHandler(this.BtnAddColumn_Click);
            // 
            // cbxListTypes
            // 
            this.cbxListTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxListTypes.FormattingEnabled = true;
            this.cbxListTypes.Items.AddRange(new object[] {
            "Varchar",
            "Int",
            "Float"});
            this.cbxListTypes.Location = new System.Drawing.Point(12, 88);
            this.cbxListTypes.Name = "cbxListTypes";
            this.cbxListTypes.Size = new System.Drawing.Size(100, 21);
            this.cbxListTypes.TabIndex = 28;
            // 
            // cbxMessages
            // 
            this.cbxMessages.AutoSize = true;
            this.cbxMessages.Checked = true;
            this.cbxMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMessages.Location = new System.Drawing.Point(131, 133);
            this.cbxMessages.Name = "cbxMessages";
            this.cbxMessages.Size = new System.Drawing.Size(74, 17);
            this.cbxMessages.TabIndex = 27;
            this.cbxMessages.Text = "Messages";
            this.cbxMessages.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbxMessages.UseVisualStyleBackColor = true;
            this.cbxMessages.CheckedChanged += new System.EventHandler(this.CbxMessages_CheckedChanged);
            // 
            // txbColumnName
            // 
            this.txbColumnName.Location = new System.Drawing.Point(12, 38);
            this.txbColumnName.Name = "txbColumnName";
            this.txbColumnName.Size = new System.Drawing.Size(100, 20);
            this.txbColumnName.TabIndex = 30;
            // 
            // txbLength
            // 
            this.txbLength.Location = new System.Drawing.Point(130, 38);
            this.txbLength.Name = "txbLength";
            this.txbLength.Size = new System.Drawing.Size(75, 20);
            this.txbLength.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Length";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Type";
            // 
            // AddTableDataView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 162);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbLength);
            this.Controls.Add(this.txbColumnName);
            this.Controls.Add(this.btnAddColumn);
            this.Controls.Add(this.cbxListTypes);
            this.Controls.Add(this.cbxMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddTableDataView";
            this.Text = "CSharpMyAdmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTableDataView_FormClosed);
            this.Load += new System.EventHandler(this.AddTableDataView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.ComboBox cbxListTypes;
        private System.Windows.Forms.CheckBox cbxMessages;
        private System.Windows.Forms.TextBox txbColumnName;
        private System.Windows.Forms.TextBox txbLength;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}