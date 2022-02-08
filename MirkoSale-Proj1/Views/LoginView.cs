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
    public partial class LoginView : Form
    {
        private MainController _controller;
        public string Title { get; set; }
        public string Message { get; set; }
        const MessageBoxButtons Button = MessageBoxButtons.OK;
        public MessageBoxIcon Icon;

        public MainController Controller { get => _controller; set => _controller = value; }

        public LoginView()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            if (Controller.Connect(txbUsername.Text, txbPassword.Text))
            {
                _controller.ActionsView.Show();
                this.Hide();
                txbUsername.Clear();
            }
            txbPassword.Clear();
            MessageBox.Show(Message, Title, Button, Icon);

        }
    }
}
