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
            if (Controller.MessageBoxes)
                MessageBox.Show(Message, Title, Button, Icon);
        }

        public void UpdateCurrentDB(bool deleted = false, bool updateList = false)
        {
            if (!deleted)
            {
                lblCurrentDB.Text = $"Currently using : {Controller.Model.CurrentDB}";
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
                btnDeleteTable.Enabled = false;
            }

            if (updateList)
                UpdateList();
        }

        public void UpdateCurrentTable(bool deleted = false, bool updateList = false)
        {
            if (!deleted)
            {
                txbTableName.Clear();
                lblCurrentTable.Text = $"Currently using : {Controller.Model.CurrentTable}";
                btnDeleteTable.Enabled = true;
            }
            else
            {
                lblCurrentTable.Text = $"Currently using : none";
                btnDeleteTable.Enabled = false;
            }
            if (updateList)
                UpdateList();
        }

        public void UpdateList()
        {
            listDatabases.Nodes.Clear();
            List<string> databases = Controller.UpdateDatabases();

            byte databasecnt = 0;
            foreach (string d in databases)
            {
                List<string> tables = Controller.UpdateTables(d);
                listDatabases.Nodes.Add(d);

                foreach (string t in tables)
                {
                    listDatabases.Nodes[databasecnt].Nodes.Add(t);
                }
                databasecnt++;
            }
        }

        public void ReturnLog(string log)
        {
            lblLog.Text = log;
        }

        private void ActionsView_Load(object sender, EventArgs e)
        {
            UpdateCurrentDB(true, true);
        }

        private void ActionsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.LoginView.Close();
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            Controller.Disconnect();
            _controller.LoginView.Show();
            this.Hide();
        }

        private void BtnCreateDB_Click(object sender, EventArgs e)
        {
            if (Controller.CreateDatabase(txbDBName.Text))
            {
                UpdateCurrentDB(false, true);
            }
            WriteMessage();
        }

        private void BtnDeleteDB_Click(object sender, EventArgs e)
        {
            if (Controller.DeleteDatabase())
            {
                UpdateCurrentDB(true);
                UpdateCurrentTable(true, true);
            }
            WriteMessage();
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            if (Controller.CreateTable(txbTableName.Text))
            {
                UpdateCurrentTable(false, true);

            }
            WriteMessage();
        }

        private void BtnDeleteTable_Click(object sender, EventArgs e)
        {
            if (Controller.DeleteTable())
            {
                UpdateCurrentTable(true, true);

            }
            WriteMessage();
        }

        private void ListDatabases_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                Controller.Model.CurrentDB = e.Node.Text;
                UpdateCurrentDB();
            }
            else
            {
                Controller.Model.CurrentDB = e.Node.Parent.Text;
                Controller.Model.CurrentTable = e.Node.Text;
                UpdateCurrentDB();
                UpdateCurrentTable();
            }
        }

        private void ListDatabases_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                Controller.TableView.Show();
            }
        }

        private void Messages_CheckedChanged(object sender, EventArgs e)
        {
            Controller.ChangeCheckboxState();
        }
    }
}
