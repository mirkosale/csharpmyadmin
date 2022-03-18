///ETML
///Author : Mirko Sale
///Date : 18.03.2022
///Description : Lets the user add information to a table depending of the columns it has

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MirkoSale_MySQL
{
    public partial class AddRowView : Form
    {
        private MainController _controller;
        public string Title { get; set; }
        public string Message { get; set; }
        const MessageBoxButtons Button = MessageBoxButtons.OK;
        public MessageBoxIcon Icon;

        List<string> fields;

        public MainController Controller { get => _controller; set => _controller = value; }

        public AddRowView()
        {
            InitializeComponent();
        }

        public void Open(bool autoIncrementedId)
        {
            //Remove already existing options on the View if not done when closing the Form
            foreach (Control c in Controls)
            {
                if (c.Name.Contains("column") || c.Name.Contains("label"))
                {
                    c.Enabled = false;
                    c.Hide();
                }
            }

            if (_controller.MessageBoxes)
                cbxMessages.Checked = true;
            else
                cbxMessages.Checked = false;

            fields = _controller.GetTableFields();
            if (autoIncrementedId)
            {
                fields.RemoveAt(0);
            }
            this.Size = new System.Drawing.Size(400, 100 + 30 * fields.Count());
            btnAddRow.Location = new System.Drawing.Point(140, 25 + 30 * fields.Count());
            cbxMessages.Location = new System.Drawing.Point(298, 33 + 30 * fields.Count());


            for (byte x = 0; x < fields.Count(); x++)
            {
                Label lblColumn = new Label();
                lblColumn.Location = new System.Drawing.Point(12, 20 + 30 * x);
                lblColumn.Name = "label" + fields[x];
                lblColumn.RightToLeft = System.Windows.Forms.RightToLeft.No;
                lblColumn.Size = new System.Drawing.Size(120, 13);
                lblColumn.Text = fields[x];
                lblColumn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                lblColumn.Enabled = true;

                TextBox txbColumnInput = new TextBox();
                txbColumnInput.Name = "column" + x;
                txbColumnInput.Location = new System.Drawing.Point(140, 17 + 30 * x);
                txbColumnInput.Size = new System.Drawing.Size(225, 13);
                Controls.Add(lblColumn);
                Controls.Add(txbColumnInput);
            }
            

            _controller.AddRowView.Show();
        }

        public void WriteMessage()
        {
            if (_controller.MessageBoxes)
                MessageBox.Show(Message, Title, Button, Icon);
        }


        private void AddRowView_Load(object sender, EventArgs e)
        {
            _controller.MessageCheckboxes.Add(cbxMessages);
        }

        private void BtnAddRow_Click(object sender, EventArgs e)
        {
            List<string> values = new List<string>();

            foreach (Control c in Controls)
            {
                if (c.Name.Contains("column"))
                {
                    if (!(c.Text == ""))
                    {
                        values.Add(c.Text.Trim());
                    }
                    else
                    {
                        values.Add("NULL");
                    }
                }
            }


            if (_controller.AddRow(fields, values))
            {
                foreach (Control c in Controls)
                {
                    if (c.Name.Contains("column"))
                    {
                        c.Text = "";
                    }
                }
            }

            WriteMessage();

            _controller.TableView.Open();
        }

        private void AddTableDataView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.AddColumnView = new AddColumnView();
            _controller.AddColumnView.Controller = _controller;
        }


        private void AddRowView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.AddRowView = new AddRowView();
            _controller.AddRowView.Controller = _controller;
        }

        private void CbxMessages_CheckedChanged(object sender, EventArgs e)
        {
            _controller.ChangeCheckboxState(cbxMessages);
        }
    }
}
