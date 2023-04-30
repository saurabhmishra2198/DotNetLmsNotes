using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CrudOperation.DAL
{
    public static class Connection
    {
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-Q41LQOG\\SQLEXPRESS;Initial Catalog=EventSystem;Integrated Security=True");
        public static void CheckConnectionState()
        {
            if (ConnectionState.Closed == connection.State)
            {
                connection.Open();
            }
        }
    }
}
