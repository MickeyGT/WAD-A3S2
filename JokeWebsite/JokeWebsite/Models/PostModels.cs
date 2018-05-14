using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JokeWebsite.Models
{
    public class Post
    {
        public int ID { get; set; }

        public string Category { get; set; }

        public string NSFW { get; set; }

        public string description { get; set; }

        public string submittedBy { get; set; }

    };
}