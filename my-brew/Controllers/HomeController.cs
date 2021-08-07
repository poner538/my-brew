using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using my_brew.Models;
using my_brewLibrary.Bussinesslogic;


namespace my_brew.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        private IPersonAccountProcessor processor;
        private IConfiguration configuration;

        public HomeController(ILogger<HomeController> logger, IPersonAccountProcessor processor,IConfiguration _config)
        {
            _logger = logger;
            this.processor = processor;
            configuration = _config;
        }

        public IActionResult Index()
        {
            
            string connStr = configuration.GetConnectionString("default");
            var _account = processor.GetPersonAccounts(connStr).ToList();
            PersonAccount person = new PersonAccount {
                Firstname = _account.First().Firstname,
                Lastname = _account.First().Lastname
            };
             return View(person);
            

           
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Home()
        {
        
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
