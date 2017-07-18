﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail() {

            if(DateTime.Today.DayOfWeek == DayOfWeek.Tuesday) {
                return Redirect("/");
            }

            return Content("Hello from the comic books controller.");
        }
    }
}