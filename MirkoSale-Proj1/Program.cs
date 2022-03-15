﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MirkoSale_MySQL
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ActionsView actionsView = new ActionsView();
            LoginView loginView = new LoginView();
            TableView tableView = new TableView();
            AddTableDataView addTableDataView = new AddTableDataView();
            MainModel model = new MainModel();

            MainController controller = new MainController(loginView, actionsView, tableView, addTableDataView, model);

            Application.Run(loginView);
        }
    }
}
