using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomTasks.Data;
using RandomTasks.Entity;
using RandomTasks.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RandomTasks.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
        public IActionResult AddCustomerType()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCustomerType(CustomerType customerType)
        {
            _context.Add(customerType);
            _context.SaveChanges();
            
            return View();
        }

        public IActionResult AddCustomer()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();

            return View();
        }
    }
}
