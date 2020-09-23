﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DenizKabacelik.ToDo.Web.Areas.Member.Controllers
{
    public class HomeController : Controller
    {

        [Area("Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
