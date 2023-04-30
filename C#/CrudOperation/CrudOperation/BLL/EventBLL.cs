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
                IDisplay displayDAL = new Display();
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
                IInsert insertDAL = new Insert();
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
                IUpdate updateDAL = new Update();
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
                IDelete deleteDAL = new Delete();
                return deleteDAL.DeleteEventDetail(EventID);
            }
            catch
            {
                throw;
            }
        }
    }
}
