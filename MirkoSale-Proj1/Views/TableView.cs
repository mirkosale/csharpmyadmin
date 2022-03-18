///ETML
///Author : Mirko Sale
///Date : 18.03.2022
///Description : Lets the user view all of the information about a table

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        /// <summary>
        /// Method that executes when the Program is started, when the Modify button is pressed but also when the Form is closed.
        /// This is to make sure that this Form is opened at all times (for the messages check) and cleared when it's not in use.
        /// This applies to all of the other forms that are opened when buttons on this Form are pressed.
        /// </summary>
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


        /// <summary>
        /// Gets the fields / columns of the table and sets them
        /// </summary>
        /// <returns>The number of columns of the table</returns>
        public byte UpdateFields()
        {
            List<string> fields = _controller.GetTableFields();

            //Set the amount of columns before giving them properties (otherwise it crashes)
            listTable.ColumnCount = fields.Count();

            byte x = 0;
            foreach (string f in fields)
            {
                //Set the name of the column in the DataGridView
                listTable.Columns[x].Name = f;
                ++x;
            }
            return x;
        }

        /// <summary>
        /// Gets all of the rows of the table and insert them into the DataGridView
        /// </summary>
        /// <param name="colNbr">The number of the column</param>
        public void UpdateRows(byte colNbr)
        {
            //Get all of the rows in one list of rows
            List<List<string>> rows = _controller.GetTableRows(colNbr);

            //Add all of the rows to the DataGridView
            foreach (List<string> r in rows)
            {
                //Change the row to a form of an array
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


        /// <summary>
        /// Check for a Right mouse click and make a context menu appear allowing the user to delete either the row or the column
        /// </summary>
        /// <param name="sender">Obj</param>
        /// <param name="e">The click on the DataGridView</param>
        private void ListTable_MouseClick(object sender, MouseEventArgs e)
        {
            //SRC https://stackoverflow.com/questions/1718389/right-click-context-menu-for-datagridview
            
            //Check if a right click was pressed or a left click
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu deleteMenu = new ContextMenu();
                string currentMouseOverRow = null;
                string currentMouseOverColumn = null;
                bool noRows = false;
                bool noColumns = false;

                //Check if a row exists where the user has clicked on 
                try
                {
                    currentMouseOverRow = listTable[0, listTable.HitTest(e.X, e.Y).RowIndex].Value.ToString();
                }
                catch
                {
                    noRows = true;
                }

                //Check if a column exists where the user has clicked (useful if empty table but columns exist)
                try
                { 
                    currentMouseOverColumn = listTable.Columns[listTable.HitTest(e.X, e.Y).ColumnIndex].Name;
                }
                catch
                {
                    noColumns = true;
                }

                //Adding the Delete Row option to the context menu
                if (!noRows)
                {
                    //ALT 255 after "Delete Row" => to Split and get the Row's ID more easily
                    MenuItem deleteRow = new MenuItem($"Delete Row {currentMouseOverRow}");
                    deleteRow.Click += DeleteRow_Click;
                    deleteMenu.MenuItems.Add(deleteRow);
                }

                //Adding the Delete Colunn option to the context menu
                if (!noColumns)
                {
                    //ALT 255 after "Delete Column" => to Split and get the Colunn's name more easily
                    MenuItem deleteColumn = new MenuItem($"Delete Column {currentMouseOverColumn}");
                    deleteColumn.Click += DeleteColumn_Click;
                    deleteMenu.MenuItems.Add(deleteColumn);
                }

                //Make the Context Menu appear
                if (!(noRows && noColumns))
                {
                    deleteMenu.Show(listTable, new Point(e.X, e.Y));
                }   
            }
        }

        private void DeleteRow_Click(object sender, EventArgs e)
        {
            MenuItem obj = (MenuItem)sender;

            //ALT 255
            string[] row = obj.Text.Split(' ');

            Controller.DeleteRow(row[1]);

            WriteMessage();

            Open();
        }

        private void DeleteColumn_Click(object sender, EventArgs e)
        {
            MenuItem obj = (MenuItem)sender;

            //ALT 255
            string[] column = obj.Text.Split(' ');

            Controller.DeleteColumn(column[1]);

            WriteMessage();

            Open();
        }

        private void BtnAddData_Click(object sender, EventArgs e)
        {
            _controller.AddRowView.Open(false);
        }

        private void BtnAddRowWithAutoIncID_Click(object sender, EventArgs e)
        {
            _controller.AddRowView.Open(true);

        }
    }
}
