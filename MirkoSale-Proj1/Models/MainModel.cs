///ETML
///Author : Mirko Sale
///Date : 18.03.2022
///Description : Main model of the program, used to store all of the important and frequently used information in the program

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
