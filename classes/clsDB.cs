using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// add usings
using System.Data;
using System.Data.SqlClient;
// add usings
namespace Register.classes
{
    // add Database class for connection for public use.
    public static class clsDB
    {
        // create connection to database
        public static SqlConnection Get_DB_Connection()
        {
            string cn_String = Properties.Settings.Default.connection_String;
            SqlConnection cn_connection = new SqlConnection(cn_String);
            if(cn_connection.State != ConnectionState.Open) { cn_connection.Open(); }
            return cn_connection;
        }

        //query data from database
        public static DataTable Get_DataTable(string SQL_Text)
        {
            SqlConnection cn_connection = Get_DB_Connection();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(SQL_Text, cn_connection);
            adapter.Fill(table);

            return table;
        }
    }
}
