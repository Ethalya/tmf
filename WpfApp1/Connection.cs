using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.ComponentModel;


namespace WpfApp1
{
  public class Connection
    {
        
       public SqlConnection sqlCon = new SqlConnection(@"Data Source = DESKTOP-NQU0NJF\SQLSERVER; Initial Catalog = TeammateFinder; Integrated Security=True;");
        public void OpenConnection()
        {
            if (sqlCon.State == System.Data.ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        public void CloseConnection()
        {
            if (sqlCon.State == System.Data.ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return sqlCon;
        }
    }
}
