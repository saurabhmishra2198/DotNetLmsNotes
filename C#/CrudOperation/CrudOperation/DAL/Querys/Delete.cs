using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.DAL
{
    public class Delete : IDelete
    {
        public int DeleteEventDetail(int EventID)
        {
            Connection.CheckConnectionState();
            //SqlCommand cmd = new SqlCommand("delete EventDetails where EventId = '" + EventID + "'", Connection.connection);
            SqlCommand cmd = new SqlCommand("Execute uspDeleteEventDetails @eventId ='" + EventID + "'", Connection.connection);
            try
            {
                int result = cmd.ExecuteNonQuery();
                return result;
            }
            catch
            {
                throw;
            }
        }
    }
}
