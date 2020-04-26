using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management
{
    class CONNECT
    {
        private MySqlConnection connection = new MySqlConnection("datasource = localhost;port=3306;username = root; password =; database = Csharp_Hotel_DB");

        public MySqlConnection getConnection()
        {
            return connection;
        }

        public void openConnection()
        {
            if (connection.State ==ConnectionState.Closed)
            {
                connection.Open();
          
            }
        }


        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();

            }
        }
    }
}
