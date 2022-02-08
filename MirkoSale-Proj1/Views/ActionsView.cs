﻿using System;
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

        private void ActionsView_Load(object sender, EventArgs e)
        {
            btnDeleteDB.Enabled = false;
            btnCreateTable.Enabled = false;
        }

        private void ActionsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Controller.LoginView.Close();
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            Controller.Disconnect();

            txbDBName.Clear();
            txbTableName.Clear();
            lblCurrentDB.Text = "Currently using : none";
            _controller.LoginView.Show();
            this.Hide();
            MessageBox.Show(Message, Title, Button, Icon);
        }

        public void ReturnLog(string log)
        {
            lblLog.Text = log;
        }

        private void BtnSelectDB_Click(object sender, EventArgs e)
        {
            if (Controller.SelectDatabase(txbDBName.Text))
            {
                lblCurrentDB.Text = $"Currently using : {Controller.Model.CurrentDB}";
                txbDBName.Clear();
                btnDeleteDB.Enabled = true;
                btnCreateTable.Enabled = true;
            }
            MessageBox.Show(Message, Title, Button, Icon);
        }

        private void BtnCreateDB_Click(object sender, EventArgs e)
        {
            if (Controller.CreateDatabase(txbDBName.Text))
            {
                lblCurrentDB.Text = $"Currently using : {Controller.Model.CurrentDB}";
                txbDBName.Clear();
                btnDeleteDB.Enabled = true;
                btnCreateTable.Enabled = true;
            }
            MessageBox.Show(Message, Title, Button, Icon);
        }

        private void BtnDeleteDB_Click(object sender, EventArgs e)
        {
            if (Controller.DeleteDatabase())
            {
                lblCurrentDB.Text = $"Currently using : none";
                txbDBName.Clear();
                btnDeleteDB.Enabled = false;
                btnCreateTable.Enabled = false;
                btnDeleteTable.Enabled = false;
            }
            MessageBox.Show(Message, Title, Button, Icon);
        }
        private void BtnSelectTable_Click(object sender, EventArgs e)
        {
            if (Controller.SelectTable(txbTableName.Text))
            {
                txbTableName.Clear();
                lblCurrentTable.Text = $"Currently using : {Controller.Model.CurrentTable}";
                btnDeleteTable.Enabled = true;
            }
            MessageBox.Show(Message, Title, Button, Icon);
        }

        private void BtnCreateTable_Click(object sender, EventArgs e)
        {
            if (Controller.CreateTable(txbTableName.Text))
            {
                txbTableName.Clear();
                lblCurrentTable.Text = $"Currently using : {Controller.Model.CurrentTable}";
                btnDeleteTable.Enabled = true;
            }
            MessageBox.Show(Message, Title, Button, Icon);
        }

        private void BtnDeleteTable_Click(object sender, EventArgs e)
        {
            if (Controller.DeleteTable())
            {
                lblCurrentTable.Text = $"Currently using : none";
                btnDeleteTable.Enabled = false;
            }
            MessageBox.Show(Message, Title, Button, Icon);
        }

        private void BtnUpdateList_Click(object sender, EventArgs e)
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

        private void ListDatabases_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            btnDeleteDB.Enabled = true;
            Controller.Model.CurrentDB = e.Node.Text;
        }
    }
}