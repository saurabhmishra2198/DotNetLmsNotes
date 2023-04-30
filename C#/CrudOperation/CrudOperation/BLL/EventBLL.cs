using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CrudOperation.DAL;

namespace CrudOperation.BLL
{
    public class EventBLL
    {
        public DataTable GetEventDetails()
        {
            try
            {
                Display displayDAL = new Display();
                return displayDAL.ReadEventDetails();
            }
            catch
            {
                throw;
            }
        }
        public int InsertData(int EventID,string EventName,decimal EventPrice,string EventDate) 
        {
            try
            {
                Insert insertDAL = new Insert();
                return insertDAL.InsertEventDetail(EventID,EventName,EventPrice,EventDate);
            }
            catch
            {
                throw;
            }
        }
        public int UpdateData(int EventID,string EventName)
        {
            try
            {
                Update updateDAL = new Update();
                return updateDAL.UpdateEventDetail(EventID, EventName);
            }
            catch
            {
                throw;
            }
        }
        public int DeleteData(int EventID)
        {
            try
            {
                Delete deleteDAL = new Delete();
                return deleteDAL.DeleteEventDetail(EventID);
            }
            catch
            {
                throw;
            }
        }
    }
}
