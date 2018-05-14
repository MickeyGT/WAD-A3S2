using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JokeWebsite.Models
{
    public class AuthLog
    {
        // Id of the Log.
        public int ID { get; set; }

        // Username of the person that has logged in.
        public string username { get; set; }

        // The date and time when the login occured.
        public DateTime time { get; set; }

    };
}