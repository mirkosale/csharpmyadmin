using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Globalization;
using System.Windows.Forms;


namespace MirkoSale_MySQL
{
    public class MainController
    {
        private LoginView _loginView;
        private ActionsView _actionsView;
        private TableView _tableView;
        private MainModel _model;

        private List<CheckBox> _messageCheckboxes = new List<CheckBox>();
        private bool _messageBoxes = true;
        public MainController(LoginView loginView, ActionsView actionsView, TableView tableView, MainModel model)
        {
            _loginView = loginView;
            _actionsView = actionsView;
            _tableView = tableView;
            _model = model;
            loginView.Controller = this;
            actionsView.Controller = this;
            tableView.Controller = this;
            model.Controller = this;
        }

        public ActionsView ActionsView { get => _actionsView; set => _actionsView = value; }
        public MainModel Model { get => _model; set => _model = value; }
        public LoginView LoginView { get => _loginView; set => _loginView = value; }
        public TableView TableView { get => _tableView; set => _tableView = value; }
        public bool MessageBoxes { get => _messageBoxes; }
        public List<CheckBox> MessageCheckboxes { get => _messageCheckboxes; set => _messageCheckboxes = value; }


        public bool ExecuteCommand(string query)
        {
            _model.Command.CommandText = query;
            try
            {
                _model.Command.ExecuteNonQuery();
            }
            catch (MySqlException)
            {
                return false;
            }

            return true;
        }

        public List<string> ExecuteSimpleQuery(string query)
        {
            List<string> list = new List<string>();
            MySqlDataReader reader;
            _model.Command.CommandText = query;

            reader = _model.Command.ExecuteReader();

            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            reader.Close();
            return list;
        }
        public List<List<string>> ExecutePrepareQuery(string query, byte rowNumber)
        {
            List<List<string>> list = new List<List<string>>();
            MySqlDataReader reader;
            _model.Command.CommandText = query;

            reader = _model.Command.ExecuteReader();

            byte x = 0;
            while (reader.Read())
            {
                list.Add(new List<string>());

                for (int i = 0; i < rowNumber; i++)
                {
                    try
                    {
                        list[x].Add(reader.GetString(i));
                    }
                    catch (System.Data.SqlTypes.SqlNullValueException)
                    {
                        list[x].Add("NULL");
                    }
                }
                x++;
            }

            reader.Close();
            return list;
        }

        public bool Connect(string user, string password)
        {
            try
            {
                _model.Connection = new MySqlConnection($"server=localhost;user={user};database=mysql;port=3306;password={password}");
                _model.Connection.Open();
            }
            catch (MySqlException)
            {
                _loginView.Message = "The connexion couldn't be established";
                _loginView.Title = "Error";
                _loginView.Icon = MessageBoxIcon.Error;

                _model.Logged = false;

                return false;
            }
            _model.Command = new MySqlCommand() { Connection = _model.Connection };
            _loginView.Message = "The connexion was established";
            _loginView.Title = "Success";
            _loginView.Icon = MessageBoxIcon.Information;

            _model.Logged = true;

            return true;
        }

        public void Disconnect()
        {
            _model.Connection.Close();
            _model.Logged = false;
            _actionsView.Message = "You have disconnected.";
            _actionsView.Title = "Success";
            _actionsView.Icon = MessageBoxIcon.Information;
        }
        public bool CreateDatabase(string dbNameNotChecked)
        {
            string dbName = dbNameNotChecked.Trim();

            if (dbName.Length >= 1)
            {
                if (!ExecuteCommand($"CREATE DATABASE IF NOT EXISTS `{dbName}`; USE `{dbName}`;"))
                {
                    _actionsView.Message = $"The database named \"{dbName}\" couldn't be created.";
                    _actionsView.Title = "Error";
                    _actionsView.Icon = MessageBoxIcon.Error;
                    return false;
                }

                _actionsView.Message = $"Created database \"{dbName}\" and currently using it.";
                _actionsView.Title = "Success";
                _actionsView.Icon = MessageBoxIcon.Information;
                _model.CurrentDB = dbName;
                return true;
            }

            _actionsView.Message = $"Your database's name cannot be less than 2 characters";
            _actionsView.Title = "Error";
            _actionsView.Icon = MessageBoxIcon.Error;
            return false;
        }

        public bool DeleteDatabase()
        {
            if (!ExecuteCommand($"DROP DATABASE `{_model.CurrentDB}`;"))
            {

                _actionsView.Message = $"The database named \"{_model.CurrentDB}\" couldn't be deleted.";
                _actionsView.Title = "Error";
                _actionsView.Icon = MessageBoxIcon.Error;
                return false;
            }

            _actionsView.Message = $"The database \"{_model.CurrentDB}\" was successfully deleted.";
            _actionsView.Title = "Success";
            _actionsView.Icon = MessageBoxIcon.Information;
            _model.CurrentDB = null;
            _model.CurrentTable = null;
            return true;
        }



        public bool CreateTable(string tableNameNotCheck)
        {
            string tableName = tableNameNotCheck.Trim();

            if (tableName.Length >= 2)
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

                if (!ExecuteCommand($"CREATE TABLE `{_model.CurrentDB}`.`{tableName}` (`{tableId}` int(13) NOT NULL AUTO_INCREMENT,PRIMARY KEY (`{tableId}`));"))
                {
                    _actionsView.Message = $"The table named \"{tableName}\" couldn't be created.";
                    _actionsView.Title = "Error";
                    _actionsView.Icon = MessageBoxIcon.Error;
                    return false;
                }

                _model.CurrentTable = tableName;
                _actionsView.Message = $"The table named \"{tableName}\" was created successfully.";
                _actionsView.Title = "Success";
                _actionsView.Icon = MessageBoxIcon.Information;
                return true;
            }

            _actionsView.Message = $"Your table's name cannot be less than 2 characters";
            _actionsView.Title = "Error";
            _actionsView.Icon = MessageBoxIcon.Error;
            return false;
        }

        public bool DeleteTable()
        {
            if (!ExecuteCommand($"DROP TABLE `{_model.CurrentDB}`.`{_model.CurrentTable}`;"))
            {
                _actionsView.Message = $"The table named \"{_model.CurrentTable}\" couldn't be deleted.";
                _actionsView.Title = "Error";
                _actionsView.Icon = MessageBoxIcon.Error;
                return false;
            }

            _actionsView.Message = $"The table \"{_model.CurrentTable}\" was successfully deleted.";
            _actionsView.Title = "Success";
            _actionsView.Icon = MessageBoxIcon.Information;
            _model.CurrentTable = null;
            return true;
        }

        public List<string> UpdateDatabases()
        {
            List<string> databases = ExecuteSimpleQuery($"SHOW DATABASES;");

            return databases;
        }

        public List<string> UpdateTables(string database)
        {
            List<string> tables = ExecuteSimpleQuery($"USE `{database}`; SHOW TABLES;");
            
            return tables;
        }

        public List<string> GetTableFields()
        {
            List<string> fields = ExecuteSimpleQuery($"USE `{_model.CurrentDB}`; DESCRIBE `{_model.CurrentTable}`;");

            return fields;
        }

        public List<List<string>> GetTableRows(byte rowNumber)
        {
            List<List<string>> rows = ExecutePrepareQuery($"USE `{_model.CurrentDB}`; SELECT * FROM `{_model.CurrentTable}`;", rowNumber);

            return rows;
        }

        public void ChangeCheckboxState(CheckBox tempCheckbox)
        {
            if (tempCheckbox.Checked == true && _messageBoxes == true)
            {
                foreach (CheckBox c in _messageCheckboxes)
                {
                    c.Checked = true;
                }
                _messageBoxes = true;
            }
            else
            {
                foreach (CheckBox c in _messageCheckboxes)
                {
                    c.Checked = false;
                }
                _messageBoxes = false;
            }
        }
    }
}
