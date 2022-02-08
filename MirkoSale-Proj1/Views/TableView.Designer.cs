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
            this.btnCr = new System.Windows.Forms.Button();
            this.cbxMessages = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCr
            // 
            this.btnCr.Location = new System.Drawing.Point(103, 139);
            this.btnCr.Name = "btnCr";
            this.btnCr.Size = new System.Drawing.Size(75, 23);
            this.btnCr.TabIndex = 1;
            this.btnCr.Text = "Connect";
            this.btnCr.UseVisualStyleBackColor = true;
            this.btnCr.Click += new System.EventHandler(this.BtnCr_Click);
            // 
            // cbxMessages
            // 
            this.cbxMessages.AutoSize = true;
            this.cbxMessages.Location = new System.Drawing.Point(233, 145);
            this.cbxMessages.Name = "cbxMessages";
            this.cbxMessages.Size = new System.Drawing.Size(74, 17);
            this.cbxMessages.TabIndex = 23;
            this.cbxMessages.Text = "Messages";
            this.cbxMessages.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.cbxMessages.UseVisualStyleBackColor = true;
            this.cbxMessages.CheckedChanged += new System.EventHandler(this.CbxMessages_CheckedChanged);
            // 
            // TableView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 420);
            this.Controls.Add(this.cbxMessages);
            this.Controls.Add(this.btnCr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TableView";
            this.Text = "CSharpMyAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCr;
        private System.Windows.Forms.CheckBox cbxMessages;
    }
}