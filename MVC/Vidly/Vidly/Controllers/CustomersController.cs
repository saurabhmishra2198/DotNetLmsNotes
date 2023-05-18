using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ApplicationDBContext _Context;
        public CustomersController()
        {
            _Context = new ApplicationDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            //_Context.Dispose();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult New()
        {
            var membershipType = _Context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipType,
            };
            return View("CustomerForm",viewModel);
        }
    }
}