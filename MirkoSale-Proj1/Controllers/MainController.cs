using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Globalization;
using System.Windows.Forms;


namespace MirkoSale_MySQL
{
    public class MainController
    {
        private LoginView _loginView;
        private ActionsView _actionsView;
        private MainModel _model;
        public MainController(LoginView loginView, ActionsView actionsView, MainModel model)
        {
            _loginView = loginView;
            _actionsView = actionsView;
            _model = model;
            loginView.Controller = this;
            actionsView.Controller = this;
            model.Controller = this;
        }

        public ActionsView ActionsView { get => _actionsView; set => _actionsView = value; }
        public MainModel Model { get => _model; set => _model = value; }
        public LoginView LoginView { get => _loginView; set => _loginView = value; }

        public bool Connect(string user, string password)
        {
            try
            {
                Model.Connection = new MySql.Data.MySqlClient.MySqlConnection($"server=localhost;user={user};database=mysql;port=3306;password={password}");
                Model.Connection.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                LoginView.Message = "The connexion couldn't be established";
                LoginView.Title = "Error";
                LoginView.Icon = MessageBoxIcon.Error;

                Model.Logged = false;

                return false;
            }
            Model.Command = new MySql.Data.MySqlClient.MySqlCommand() { Connection = Model.Connection };
            LoginView.Message = "The connexion was established";
            LoginView.Title = "Success";
            LoginView.Icon = MessageBoxIcon.Information;

            Model.Logged = true;

            return true;
        }

        public void Disconnect()
        {
            Model.Connection.Close();
            Model.Logged = false;
            ActionsView.Message = "You have disconnected.";
            ActionsView.Title = "Success";
            ActionsView.Icon = MessageBoxIcon.Information;
        }

        public bool SelectDatabase(string dbName)
        {
            Model.Command.CommandText = $"USE `{dbName}`;";

            try { Model.Command.ExecuteNonQuery(); }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                ActionsView.Message = $"Can't use database \"{dbName}\".";
                ActionsView.Title = "Error";
                ActionsView.Icon = MessageBoxIcon.Error;
                return false;
            }

            ActionsView.Message = $"Currently using database : \"{dbName}\".";
            ActionsView.Title = "Success";
            ActionsView.Icon = MessageBoxIcon.Information;
            Model.CurrentDB = dbName;
            return true;
        }
        public bool CreateDatabase(string dbName)
        {
            Model.Command.CommandText = $"CREATE DATABASE IF NOT EXISTS `{dbName}`; USE `{dbName}`;";

            try { Model.Command.ExecuteNonQuery(); }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                ActionsView.Message = $"The database named \"{dbName}\" couldn't be created.";
                ActionsView.Title = "Error";
                ActionsView.Icon = MessageBoxIcon.Error;
                return false;
            }

            ActionsView.Message = $"Created database \"{dbName}\" and currently using it.";
            ActionsView.Title = "Success";
            ActionsView.Icon = MessageBoxIcon.Information;
            Model.CurrentDB = dbName;
            return true;
        }

        public bool DeleteDatabase()
        {
            Model.Command.CommandText = $"DROP DATABASE `{Model.CurrentDB}`;";

            try { Model.Command.ExecuteNonQuery(); }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                ActionsView.Message = $"The database named \"{Model.CurrentDB}\" couldn't be deleted.";
                ActionsView.Title = "Error";
                ActionsView.Icon = MessageBoxIcon.Error;
                return false;
            }

            ActionsView.Message = $"The database \"{Model.CurrentDB}\" was successfully deleted.";
            ActionsView.Title = "Success";
            ActionsView.Icon = MessageBoxIcon.Information;
            Model.CurrentDB = null;
            Model.CurrentTable = null; 
            return true;
        }

        public bool SelectTable(string tableName)
        {
            if (Model.CurrentDB != null && tableName.Length >= 2)
            {
                Model.Command.CommandText = $"SELECT * FROM `{tableName}`;" ;

                try
                {
                    ActionsView.ReturnLog(Model.Command.CommandText);
                    Model.Command.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    ActionsView.Message = $"The table named \"{tableName}\" couldn't be selected.";
                    ActionsView.Title = "Error";
                    ActionsView.Icon = MessageBoxIcon.Error;
                    return false;
                }

                Model.CurrentTable = tableName;
                ActionsView.Message = $"The table named \"{tableName}\" was selected succesfully";
                ActionsView.Title = "Success";
                ActionsView.Icon = MessageBoxIcon.Information;
                return true;
            }

            ActionsView.Message = $"You need to be using a database before you can create a table";
            ActionsView.Title = "Error";
            ActionsView.Icon = MessageBoxIcon.Error;
            return false;
        }

        public bool CreateTable(string tableName)
        {
            if (Model.CurrentDB != null && tableName.Length >= 2)
            {
                string tableId;
                if (tableName[1] == '_')
                {
                    tableId = $"id{ tableName.Substring(2, 1).ToUpper() + tableName.Substring(3, tableName.Length - 3)}";
                }
                else
                {
                    tableId = $"id{ tableName.Substring(0, 1).ToUpper() + tableName.Substring(1, tableName.Length - 1)}";
                }


                Model.Command.CommandText = $"CREATE TABLE `{tableName}` (`{tableId}` int(13) NOT NULL AUTO_INCREMENT,PRIMARY KEY (`{tableId}`));";

                try
                {
                    ActionsView.ReturnLog(Model.Command.CommandText);
                    Model.Command.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException)
                {
                    ActionsView.Message = $"The table named \"{tableName}\" couldn't be created.";
                    ActionsView.Title = "Error";
                    ActionsView.Icon = MessageBoxIcon.Error;
                    return false;
                }

                Model.CurrentTable = tableName;
                ActionsView.Message = $"The table named \"{tableName}\" was created successfully.";
                ActionsView.Title = "Success";
                ActionsView.Icon = MessageBoxIcon.Information;
                return true;
            }

            ActionsView.Message = $"You need to be using a database before you can create a table";
            ActionsView.Title = "Error";
            ActionsView.Icon = MessageBoxIcon.Error;
            return false;
        }

        public bool DeleteTable()
        {
            Model.Command.CommandText = $"DROP TABLE `{Model.CurrentTable}`;";

            try { Model.Command.ExecuteNonQuery(); }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                ActionsView.Message = $"The table named \"{Model.CurrentTable}\" couldn't be deleted.";
                ActionsView.Title = "Error";
                ActionsView.Icon = MessageBoxIcon.Error;
                return false;
            }

            ActionsView.Message = $"The table \"{Model.CurrentTable}\" was successfully deleted.";
            ActionsView.Title = "Success";
            ActionsView.Icon = MessageBoxIcon.Information;
            Model.CurrentTable = null;
            return true;
        }

        public List<string> UpdateDatabases()
        {
            List<string> databases = new List<string>();
            MySql.Data.MySqlClient.MySqlDataReader reader;
            Model.Command.CommandText = $"SHOW DATABASES;";

            reader = Model.Command.ExecuteReader();

            while (reader.Read())
            {
                databases.Add(reader.GetString(0));
            }

            reader.Close();
            return databases;
        }

        public List<string> UpdateTables(string database)
        {
            List<string> tables = new List<string>();
            MySql.Data.MySqlClient.MySqlDataReader reader;
            Model.Command.CommandText = $"USE `{database}`; SHOW TABLES;";

            reader = Model.Command.ExecuteReader();

            while (reader.Read())
            {
                tables.Add(reader.GetString(0));
            }
            reader.Close();
            return tables;
        }
    }
}
