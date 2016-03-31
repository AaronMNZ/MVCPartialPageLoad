using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using PartialViewDemo.Models;

namespace PartialViewDemo.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialContent(string id)
        {
            Thread.Sleep(1000);     //Simulate slow loading

            var model = new ViewModel {Customers = new List<Customer>()};
            
            //Generate some data to put in the model
            switch (id)
            {
                case "1":
                    model.Customers.Add(new Customer { Address = "938 Ridge Avenue ", Name = "Margarita Frank", Phone = "09123456" });
                    model.Customers.Add(new Customer { Address = "31 Oxford Road", Name = "Shad Accosi", Phone = "07555667" });
                    model.Customers.Add(new Customer { Address = "221 Sherwood Drive", Name = "Lora Murdock", Phone = "02999888" });
                    break;

                case"2":
                    model.Customers.Add(new Customer { Address = "943 Walnut Avenue ", Name = "Maria Romagna", Phone = "09123456" });
                    model.Customers.Add(new Customer{Address="400 Race Street ", Name="Ninon Wirth", Phone = "07555667"});
                    model.Customers.Add(new Customer { Address = "982 Harrison Avenue ", Name = "Bianca Bruno", Phone = "02999888" });
                    model.Customers.Add(new Customer { Address = "474 Briarwood Drive ", Name = "Liviana Gottschalk", Phone = "09123456" });
                    model.Customers.Add(new Customer { Address = "373 Cemetery Road ", Name = "Nataliya Ognyanov", Phone = "07555667" });
                    model.Customers.Add(new Customer { Address = "608 Pennsylvania Avenue ", Name = "Kemen Adam", Phone = "02999888" });
                    break;
            }

            return PartialView("_PartialPage", model);

        }
    }
}