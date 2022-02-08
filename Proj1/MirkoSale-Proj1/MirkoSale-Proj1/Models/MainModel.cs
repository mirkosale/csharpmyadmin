using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MirkoSale_MySQL
{
    public class MainModel
    {
        private MainController _controller;

        private static MySqlConnection _connection;
        private static MySqlCommand _command;

        private bool _logged = false;

        public MainController Controller { get => _controller; set => _controller = value; }
        public bool Logged { get => _logged; set => _logged = value; }
        public MySqlConnection Connection { get => _connection; set => _connection = value; }
        public MySqlCommand Command { get => _command; set => _command = value; }
        public string CurrentDB { get; set; }

        public string CurrentTable { get; set; }
    }
}
