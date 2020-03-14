﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {

        //GET : /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }


        //GET: /HelloWorld/Welcome?name=amine&numTimes=6 
        public IActionResult Welcome(string name, int ID = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["ID"] = ID;



            return View();

        }
    }
}