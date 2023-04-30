using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.DAL
{
    public class Display
    {
        DataTable dataTable = new DataTable();
        public DataTable ReadEventDetails()
        {
            Connection.CheckConnectionState();
            //SqlCommand cmd = new SqlCommand("Select * from EventDetails", Connection.connection);
            SqlCommand cmd = new SqlCommand("Execute uspShowAllEventDetails", Connection.connection);
            try
            {
                SqlDataReader rd = cmd.ExecuteReader();
                dataTable.Load(rd);
                return dataTable;
            }
            catch
            {
                throw;
            }
        }
    }
}
