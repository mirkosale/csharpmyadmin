///ETML
///Author : Mirko Sale
///Date : 18.03.2022
///Description : Lets the user a column to the table

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MirkoSale_MySQL
{
    public partial class AddColumnView : Form
    {
        private MainController _controller;
        public string Title { get; set; }
        public string Message { get; set; }
        const MessageBoxButtons Button = MessageBoxButtons.OK;
        public MessageBoxIcon Icon;

        public MainController Controller { get => _controller; set => _controller = value; }

        public AddColumnView()
        {
            InitializeComponent();
        }

        public void Open()
        {
            List<string> fields = _controller.GetTableFields();

            if (_controller.MessageBoxes)
                cbxMessages.Checked = true;
            else
                cbxMessages.Checked = false;

            _controller.AddColumnView.Show();
        }

        public void WriteMessage()
        {
            if (_controller.MessageBoxes)
                MessageBox.Show(Message, Title, Button, Icon);
        }


        private void AddTableDataView_Load(object sender, EventArgs e)
        {
            _controller.MessageCheckboxes.Add(cbxMessages);
        }

        private void BtnAddColumn_Click(object sender, EventArgs e)
        {
            string name = txbColumnName.Text.Trim();
            string type = cbxListTypes.Text;
            int length;
            Int32.TryParse(txbLength.Text.Trim(), out length);


            if (_controller.AddColumn(name, type, length))
            {
                _controller.TableView.Open();
                txbColumnName.Clear();
                txbLength.Clear();
            }
            WriteMessage();
        }

        private void AddTableDataView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.AddColumnView = new AddColumnView();
            _controller.AddColumnView.Controller = _controller;
        }

        private void CbxMessages_CheckedChanged(object sender, EventArgs e)
        {
            _controller.ChangeCheckboxState(cbxMessages);
        }
    }
}
