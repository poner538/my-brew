using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using my_brew.Models;

namespace my_brew.Controllers
{
    public class LabelController : BaseController
    {
        private readonly ILogger<LabelController> _logger;

        public LabelController(ILogger<LabelController> logger)
        {
            _logger = logger;
        }

        public IActionResult Examples()
        {
            return View();
        }

        public IActionResult UpploadOwn()
        {
            return View();
        }
    }
}