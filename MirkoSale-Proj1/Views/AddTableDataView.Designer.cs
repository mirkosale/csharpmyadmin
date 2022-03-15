namespace MirkoSale_MySQL
{
    partial class AddTableDataView
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
            this.SuspendLayout();
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.Location = new System.Drawing.Point(655, 72);
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
            this.cbxListTypes.Location = new System.Drawing.Point(655, 45);
            this.cbxListTypes.Name = "cbxListTypes";
            this.cbxListTypes.Size = new System.Drawing.Size(75, 21);
            this.cbxListTypes.TabIndex = 28;
            // 
            // cbxMessages
            // 
            this.cbxMessages.AutoSize = true;
            this.cbxMessages.Checked = true;
            this.cbxMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMessages.Location = new System.Drawing.Point(442, 439);
            this.cbxMessages.Name = "cbxMessages";
            this.cbxMessages.Size = new System.Drawing.Size(74, 17);
            this.cbxMessages.TabIndex = 27;
            this.cbxMessages.Text = "Messages";
            this.cbxMessages.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbxMessages.UseVisualStyleBackColor = true;
            this.cbxMessages.CheckedChanged += new System.EventHandler(this.CbxMessages_CheckedChanged);
            // 
            // AddTableDataView
            // 
            this.ClientSize = new System.Drawing.Size(957, 498);
            this.Controls.Add(this.btnAddColumn);
            this.Controls.Add(this.cbxListTypes);
            this.Controls.Add(this.cbxMessages);
            this.Name = "AddTableDataView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTableDataView_FormClosed);
            this.Load += new System.EventHandler(this.AddTableDataView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.ComboBox cbxListTypes;
        private System.Windows.Forms.CheckBox cbxMessages;
    }
}