using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JokeWebsite.Models
{
    public class CategoryModel : Controller
    {
        // GET: CategoryModel
        public ActionResult Index()
        {
            return View();
        }
    }
}