﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: /<controller>/
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Conan" };
            return View(movie);
        }
    }
}
