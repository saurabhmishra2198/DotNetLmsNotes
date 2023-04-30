using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.DAL
{
    public class Update
    {
        public int UpdateEventDetail(int EventID, string EventName)
        {
            Connection.CheckConnectionState();
            //SqlCommand cmd = new SqlCommand("update EventDetails set EventName = '" + EventName + "' where EventId ='" + EventID + "' ", Connection.connection);
            SqlCommand cmd = new SqlCommand("Execute uspUpdateEventDetails @eventId ='" + EventID + "',@eventName='" + EventName + "'", Connection.connection);
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
