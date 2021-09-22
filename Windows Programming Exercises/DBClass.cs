using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Programming_Exercises
{
    class DBClass
    {
        public static OleDbConnection connection;

        static DBClass()
        {
            connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:/Users/profi/Desktop/DataKTHT.mdb";
            connection.Open();
        }

        public static DataTable queryAsDatatable(String command)
        {
            OleDbDataAdapter ad = new OleDbDataAdapter(command, connection);

            DataTable dataTable = new DataTable();
            ad.Fill(dataTable);

            return dataTable;
        }

        public static OleDbDataReader queryAsDatareader(String command)
        {
            OleDbCommand oleDbCommand = new OleDbCommand(command, connection);
            OleDbDataReader reader = oleDbCommand.ExecuteReader();

            return reader;
        }

        public static void excuteCommand(String command)
        {
            OleDbCommand oleDbCommand = new OleDbCommand(command, connection);
            oleDbCommand.ExecuteNonQuery();
        }
    }
}
