using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudOperation.DAL
{
    public class Insert : IInsert
    {
        public int InsertEventDetail(int EventID, string EventName, decimal EventPrice, string EventDate)
        {
            Connection.CheckConnectionState();
            //SqlCommand cmd = new SqlCommand("insert into EventDetails values('" + EventID + "','" + EventName + "','" + EventPrice + "','" + string.Format("{0:MM/dd/yyyy}", EventDate) + "')", Connection.connection);
            SqlCommand cmd = new SqlCommand("Execute uspInsertEventDetails @eventId='" + EventID + "',@eventName='" + EventName + "',@eventPrice = '" + EventPrice + "',@eventDate='" + string.Format("{0:MM/dd/yyyy}", EventDate) + "'", Connection.connection);
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
