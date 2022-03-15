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
                listTable.Rows.Add(r.ToArray());
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
            _controller.AddColumnView.Open();
        }

        private void ListTable_MouseClick(object sender, MouseEventArgs e)
        {
            ///SRC https://stackoverflow.com/questions/1718389/right-click-context-menu-for-datagridview
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu deleteMenu = new ContextMenu();
                string currentMouseOverRow = null;
                string currentMouseOverColumn = null;
                bool noRows = false;
                bool noColumns = false;
                try
                {
                    currentMouseOverRow = listTable[0, listTable.HitTest(e.X, e.Y).RowIndex].Value.ToString();
                }
                catch
                {
                    noRows = true;
                }

                try
                { 
                    currentMouseOverColumn = listTable.Columns[listTable.HitTest(e.X, e.Y).ColumnIndex].Name;
                }
                catch
                {
                    noColumns = true;
                }

                if (!noRows)
                {
                    MenuItem deleteRow = new MenuItem($"Delete Row {currentMouseOverRow}");
                    deleteRow.Click += DeleteRow_Click;
                    deleteMenu.MenuItems.Add(deleteRow);
                }

                if (!noColumns)
                {
                    MenuItem deleteColumn = new MenuItem($"Delete Column {currentMouseOverColumn}");
                    deleteColumn.Click += DeleteColumn_Click;
                    deleteMenu.MenuItems.Add(deleteColumn);
                }

                if (!(noRows && noColumns))
                {
                    deleteMenu.Show(listTable, new Point(e.X, e.Y));
                }   
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            MenuItem obj = (MenuItem)sender;

            ///ALT 255
            string[] row = obj.Text.Split(' ');

            Controller.DeleteRow(row[1]);

            WriteMessage();

            Open();
        }

        private void DeleteColumn_Click(object sender, EventArgs e)
        {
            MenuItem obj = (MenuItem)sender;

            ///ALT 255
            string[] column = obj.Text.Split(' ');

            Controller.DeleteColumn(column[1]);

            WriteMessage();

            Open();
        }

        private void BtnAddData_Click(object sender, EventArgs e)
        {
            _controller.AddRowView.Open();
        }
    }
}
