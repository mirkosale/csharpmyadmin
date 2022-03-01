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
            if (_controller.MessageBoxes)
                MessageBox.Show(Message, Title, Button, Icon);
            
        }

        public void UpdateCurrentDB(bool deleted = false, bool updateList = false)
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
                btnDeleteTable.Enabled = false;
            }

            if (updateList)
                UpdateList();
        }

        public void UpdateCurrentTable(bool deleted = false, bool updateList = false)
        {
            if (!deleted && _controller.Model.CurrentTable != null)
            {
                txbTableName.Clear();
                lblCurrentTable.Text = $"Currently using : {_controller.Model.CurrentTable}";
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
            List<string> databases = _controller.UpdateDatabases();

            byte databasecnt = 0;
            foreach (string d in databases)
            {
                List<string> tables = _controller.UpdateTables(d);
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
            _controller.MessageCheckboxes.Add(cbxMessages);
        }

        private void ActionsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            _controller.LoginView.Close();
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            _controller.Disconnect();
            _controller.LoginView.Show();
            this.Hide();
        }

        private void BtnCreateDB_Click(object sender, EventArgs e)
        {
            if (_controller.CreateDatabase(txbDBName.Text))
            {
                UpdateCurrentDB(false, true);
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

        private void ListDatabases_Click(object sender, TreeNodeMouseClickEventArgs e)
        {
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
            UpdateCurrentDB();
            UpdateCurrentTable();
        }

        private void ListDatabases_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
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
            UpdateCurrentDB(true, true);
            _controller.ActionsView.Show();
        }
    }
}
