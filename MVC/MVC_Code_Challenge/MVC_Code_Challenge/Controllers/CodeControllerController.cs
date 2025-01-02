using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Code_Challenge.Models;

namespace MVC_Code_Challenge.Controllers
{
    public class CodeControllerController : Controller
    {
        
        
            public northwindEntities db = new northwindEntities();


            public ActionResult CustomersInGermany()
            {
                var customers = db.Customers.Where(c => c.Country == "Germany").ToList();
                return View(customers);
            }
            public ActionResult CustomerDetails()
            {
                var customerDetails = db.Orders
                                         .Where(o => o.OrderID == 10248)
                                         .Select(o => o.Customer)
                                         .FirstOrDefault();
                return View(customerDetails);
            }
            // GET: CodeController
            public ActionResult Index()
        {
            return View();
        }
    }
}