using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JokeWebsite.Models
{
    public class AuthLog
    {
        public int ID { get; set; }

        public string username { get; set; }

        public DateTime time { get; set; }

    };
}