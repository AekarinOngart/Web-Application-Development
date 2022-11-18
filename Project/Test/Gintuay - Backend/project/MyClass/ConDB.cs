using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace project.MyClass
{
    public class ConDB
    {

        private string ConString = "server=localhost ;username=root ;password=; database=project;";
        public MySqlConnection myConnection;

        public ConDB()
        { 
            myConnection = new MySqlConnection(ConString);
            myConnection.Open();
        }

        public DataTable GetData(string _sqlCommand)
        { 
        MySqlCommand command = new MySqlCommand(_sqlCommand, myConnection);
        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        DataTable dt = new DataTable();
        adapter.Fill(dt);
        return dt;
        }

        public  void ExecuteQuery(string _sqlCommand)
        {
            MySqlCommand command = new MySqlCommand("", myConnection);
            command.CommandText = _sqlCommand;
            command.CommandType = CommandType.Text;
            command.Connection = myConnection;
            command.ExecuteNonQuery();
        }
    }
}
