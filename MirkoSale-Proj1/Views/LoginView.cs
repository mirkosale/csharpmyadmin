///ETML
///Author : Mirko Sale
///Date : 18.03.2022
///Description : Login Form of the program, lets the user log himself in

using System;
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
            if (_controller.Connect(txbUsername.Text, txbPassword.Text))
            {
                _controller.ActionsView.Open();
                this.Hide();
                txbUsername.Clear();
            }
            txbPassword.Clear();

            if (_controller.MessageBoxes)
            MessageBox.Show(Message, Title, Button, Icon);

        }

        private void CbxMessages_CheckedChanged(object sender, EventArgs e)
        {
            _controller.ChangeCheckboxState(cbxMessages);
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            _controller.MessageCheckboxes.Add(cbxMessages);
            _controller.ActionsView.Show();
            _controller.TableView.Show();
            _controller.ActionsView.Hide();
            _controller.TableView.Hide();
        }
    }
}
