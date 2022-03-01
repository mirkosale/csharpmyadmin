using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirkoSale_MySQL
{
    public partial class TableView : Form
    {
        private MainController _controller;
        public string Title { get; set; }
        public string Message { get; set; }
        const MessageBoxButtons Button = MessageBoxButtons.OK;
        public MessageBoxIcon Icon;

        public MainController Controller { get => _controller; set => _controller = value; }

        public TableView()
        {
            InitializeComponent();
        }

        private void BtnCr_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Message, Title, Button, Icon);
        }

        public void WriteMessage()
        {
            if (_controller.MessageBoxes)
                MessageBox.Show(Message, Title, Button, Icon);
        }

        public void Open()
        {
            listTable.Rows.Clear();
            listTable.Columns.Clear();
            byte rowNbr = UpdateFields();
            UpdateRows(rowNbr);
			if (_controller.MessageBoxes)
				cbxMessages.Checked = true;
			else
				cbxMessages.Checked = false;
            _controller.TableView.Show();
			
        }

        public byte UpdateFields()
        {
            List<string> fields = _controller.GetTableFields();

            listTable.ColumnCount = fields.Count();

            byte x = 0;
            foreach (string f in fields)
            {
                listTable.Columns[x].Name = f;
                ++x;
            }
            return x;
        }

        public void UpdateRows(byte rowNbr)
        {
            List<List<string>> rows = _controller.GetTableRows(rowNbr);

            foreach (List<string> r in rows)
            {
                string row = "{";

                foreach (string s in r)
                {
                    row+= $"{s};";
                }

                row += "}";
                listTable.Rows.Add(row);

            }
        }

        private void CbxMessages_CheckedChanged(object sender, EventArgs e)
        {
            _controller.ChangeCheckboxState(cbxMessages);
        }

        private void TableView_Load(object sender, EventArgs e)
        {
            _controller.MessageCheckboxes.Add(cbxMessages);
        }


        private void TableView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.TableView = new TableView();
            _controller.TableView.Controller = _controller;
        }

        private void BtnAddColumn_Click(object sender, EventArgs e)
        {

        }
    }
}
