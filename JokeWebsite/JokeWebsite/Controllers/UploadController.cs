using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JokeWebsite.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult MemeUpload(string Category, string NSFW, string description, string submittedBy)
        {
            return View();
        }
    }
}