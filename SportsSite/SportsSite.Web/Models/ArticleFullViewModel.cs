using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportsSite.Web.Models
{
    public class ArticleFullViewModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Content { get; set; }

        public string Date { get; set; }

        public string ImageUrl { get; set; }

        public string Category { get; set; }
    }
}