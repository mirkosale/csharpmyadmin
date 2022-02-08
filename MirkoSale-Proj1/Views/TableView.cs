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
            if (Controller.MessageBoxes)
                MessageBox.Show(Message, Title, Button, Icon);
        }

        private void CbxMessages_CheckedChanged(object sender, EventArgs e)
        {
            Controller.ChangeCheckboxState();
        }
    }
}
