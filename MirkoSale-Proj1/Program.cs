///ETML
///Author : Mirko Sale
///Date : 18.03.2022
///Description : Used to link all of the Views and Models to the Controller and start the login view

using System;
using System.Windows.Forms;

namespace MirkoSale_MySQL
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ActionsView actionsView = new ActionsView();
            LoginView loginView = new LoginView();
            TableView tableView = new TableView();
            AddColumnView addColumnView = new AddColumnView();
            AddRowView addRowView = new AddRowView();
            MainModel model = new MainModel();

            MainController controller = new MainController(loginView, actionsView, tableView, addColumnView, addRowView, model);

            Application.Run(loginView);
        }
    }
}
