using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Example.Models;
using System.Data.Entity;

namespace MVC_Example.Controllers
{
    

    public class CustomersController : Controller
    {
        private MyDBContext _context;

        public CustomersController()
        {
            _context = new MyDBContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
            base.Dispose(disposing);
        }
        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult New()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Customer newCustomer )
        {
            return RedirectToAction("Index","Customers");
        }
        public ActionResult Details(int id)
        
            {
                var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
                
                            if (customer == null)
                                return HttpNotFound();
                
                            return View(customer);
                        }


        }
}