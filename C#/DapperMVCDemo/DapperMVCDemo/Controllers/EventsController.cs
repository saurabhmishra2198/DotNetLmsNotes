using Dapper;
using DapperMVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace DapperMVCDemo.Controllers
{
    public class EventsController : Controller
    {
        // GET: Events
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<EventModel>("EventDetailViewAll"));
        }
        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if(id== 0)
            {
                return View();
            }
            else
            {
                DynamicParameters dynamicParameters = new DynamicParameters();
                dynamicParameters.Add("@EventId", id);
                return View(DapperORM.ReturnList<EventModel>("EventDetailViewById",dynamicParameters).FirstOrDefault<EventModel>());
            }
            
        }
        [HttpPost]
        public ActionResult AddOrEdit(EventModel eventModel)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@EventId", eventModel.EventId);
            dynamicParameters.Add("@EventName", eventModel.EventName);
            dynamicParameters.Add("@EventPrice", eventModel.EventPrice);
            dynamicParameters.Add("@EventDate", eventModel.EventDate);
            DapperORM.ExecuteWithoutReturn("EventAddOrEdit", dynamicParameters);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            DynamicParameters dynamicParameters = new DynamicParameters();
            dynamicParameters.Add("@EventId", id);
            DapperORM.ExecuteWithoutReturn("EventDetailDeleteById", dynamicParameters);
            return RedirectToAction("Index");
        }
    }
}