///ETML
///Author : Mirko Sale
///Date : 18.03.2022
///Description : Main View of the program, lets the user view and edit information about his databases and tables
///              Uses a TreeView as it's main source of information and control.++++++++++++++++++++

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MirkoSale_MySQL
{
    public partial class ActionsView : Form
    {
        private MainController _controller;
        public string Title;
        public string Message;
        const MessageBoxButtons Button = MessageBoxButtons.OK;
        public MessageBoxIcon Icon;

        public MainController Controller { get => _controller; set => _controller = value; }

        public ActionsView()
        {
            InitializeComponent();
        }

        public void WriteMessage()
        {
            if (_controller.MessageBoxes)
                MessageBox.Show(Message, Title, Button, Icon);
        }

        /// <summary>
        /// Updates the currently used database label 
        /// </summary>
        /// <param name="deleted">If there was a database that has been deleted => set to "none"</param>
        public void UpdateCurrentDB(bool deleted = false)
        {
            if (!deleted)
            {
                lblCurrentDB.Text = $"Currently using : {_controller.Model.CurrentDB}";
                txbDBName.Clear();
                btnDeleteDB.Enabled = true;
                btnCreateTable.Enabled = true;
            }
            else
            {
                lblCurrentDB.Text = $"Currently using : none";
                txbDBName.Clear();
                btnDeleteDB.Enabled = false;
                btnCreateTable.Enabled = false;
            }

        }

        /// <summary>
        /// Updates the currently used table label and refreshes the TreeView
        /// </summary>
        /// <param name="deleted">If there was a table that has been deleted => set to "none"</param>
        /// <param name="updateList">If on => updates the treeview</param>
        public void UpdateCurrentTable(bool deleted = false, bool updateList = false)
        {
            if (!deleted && _controller.Model.CurrentTable != null)
            {
                txbTableName.Clear();
                lblCurrentTable.Text = $"Currently using : {_controller.Model.CurrentTable}";
                btnDeleteTable.Enabled = true;
                btnEditTable.Enabled = true;
            }
            else
            {
                lblCurrentTable.Text = $"Currently using : none";
                btnDeleteTable.Enabled = false;
                btnEditTable.Enabled = false;
            }
            if (updateList)
                UpdateList();
        }

        /// <summary>
        /// Gets all of the databases and tables and list them in the TreeView
        /// </summary>
        public void UpdateList()
        {
            //Clear TreeView
            listDatabases.Nodes.Clear();

            //Get the databases
            List<string> databases = _controller.UpdateDatabases();

            byte databasecnt = 0;

            //Get the tables for each database
            foreach (string d in databases)
            {
                //Get the tables for a specific database
                List<string> tables = _controller.UpdateTables(d);
                listDatabases.Nodes.Add(d);

                foreach (string t in tables)
                {
                    listDatabases.Nodes[databasecnt].Nodes.Add(t);
                }
                databasecnt++;
            }
        }

        private void ActionsView_Load(object sender, EventArgs e)
        {
            _controller.MessageCheckboxes.Add(cbxMessages);
        }

        private void ActionsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.LoginView.Close();
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            _controller.Disconnect();
            _controller.TableView.Hide();
            _controller.AddColumnView.Hide();
            _controller.AddRowView.Hide();
            this.Hide();
            _controller.LoginView.Show();
        }

        private void BtnCreateDB_Click(object sender, EventArgs e)
        {
            if (_controller.CreateDatabase(txbDBName.Text))
            {
                UpdateCurrentDB(false);
                UpdateList();
            }
            WriteMessage();
        }

        private void BtnDeleteDB_Click(object sender, EventArgs e)
        {
            if (_controller.DeleteDatabase())
            {
                UpdateCurrentDB(true);
                UpdateCurrentTable(true, true);
            }
            WriteMessage();
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            if (_controller.CreateTable(txbTableName.Text))
            {
                UpdateCurrentTable(false, true);

            }
            WriteMessage();
        }

        private void BtnDeleteTable_Click(object sender, EventArgs e)
        {
            if (_controller.DeleteTable())
            {
                UpdateCurrentTable(true, true);
            }

            WriteMessage();
        }

        /// <summary>
        /// Updates the currently used and database labels depending on what part of the TreeView was clicked
        /// </summary>
        /// <param name="sender">Obj</param>
        /// <param name="e">Check for click event</param>
        private void ListDatabases_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Check if the clicked part Node was a table or a database
            if (e.Node.Parent == null)
            {
                _controller.Model.CurrentDB = e.Node.Text;
                _controller.Model.CurrentTable = null;
            }
            else
            {
                _controller.Model.CurrentDB = e.Node.Parent.Text;
                _controller.Model.CurrentTable = e.Node.Text;
                
            }

            //Update the two labels
            UpdateCurrentDB();
            UpdateCurrentTable();
        }


        private void ListDatabases_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            //Check if a table that was double clicked and not a database
            if (e.Node.Parent != null && Controller.Model.CurrentTable != null)
            {
                _controller.TableView.Open();
            }
        }

        private void Messages_CheckedChanged(object sender, EventArgs e)
        {
            _controller.ChangeCheckboxState(cbxMessages);
        }

        private void BtnEditTable_Click(object sender, EventArgs e)
        {
            _controller.TableView.Open();
        }

        public void Open()
        {
            //Updates the labels
            UpdateCurrentDB(true);
            UpdateCurrentTable(true, true);
            _controller.ActionsView.Show();
        }
    }
}
