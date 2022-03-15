namespace MirkoSale_MySQL
{
    partial class AddRowView
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
            this.btnAddRow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxMessages
            // 
            this.cbxMessages.AutoSize = true;
            this.cbxMessages.Checked = true;
            this.cbxMessages.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxMessages.Location = new System.Drawing.Point(298, 108);
            this.cbxMessages.Name = "cbxMessages";
            this.cbxMessages.Size = new System.Drawing.Size(74, 17);
            this.cbxMessages.TabIndex = 28;
            this.cbxMessages.Text = "Messages";
            this.cbxMessages.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbxMessages.UseVisualStyleBackColor = true;
            this.cbxMessages.CheckedChanged += new System.EventHandler(this.CbxMessages_CheckedChanged);
            // 
            // btnAddRow
            // 
            this.btnAddRow.Location = new System.Drawing.Point(140, 100);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(120, 25);
            this.btnAddRow.TabIndex = 41;
            this.btnAddRow.Text = "Add Row";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.BtnAddRow_Click);
            // 
            // AddRowView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 143);
            this.Controls.Add(this.btnAddRow);
            this.Controls.Add(this.cbxMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddRowView";
            this.Text = "AddRowView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddRowView_FormClosed);
            this.Load += new System.EventHandler(this.AddRowView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxMessages;
        private System.Windows.Forms.Button btnAddRow;
    }
}