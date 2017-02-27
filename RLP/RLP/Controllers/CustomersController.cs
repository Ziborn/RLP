using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RLP.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RLP.Controllers
{
    public class CustomersController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            var models = DataManager.GetAllCustomers();
            ViewBag.Customers = models;
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            DataManager.AddCustomer(customer);
            return RedirectToAction(nameof(CustomersController.Index));
        }

        public IActionResult Details(int id)
        {
            var models = DataManager.GetCustomerById(id);
            ViewBag.Customers = models;
            return View();
        }

        public IActionResult Remove(Customer customer)
        {
            DataManager.Remove(customer);
            return View();
        }
    }
}
