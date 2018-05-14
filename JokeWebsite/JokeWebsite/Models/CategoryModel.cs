using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JokeWebsite.Models
{
    public class Category
    {
        public int ID { get; set; }

        // Name of the category.
        public string name { get; set; }

        // Description of the category.
        public string description { get; set; }

        // Variable that holds the number of posts that belong to this category.
        public int numberOfPosts { get; set; }

    };
}