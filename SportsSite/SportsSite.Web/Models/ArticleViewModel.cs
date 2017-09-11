namespace SportsSite.Web.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;

    public class ArticleViewModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Content { get; set; }

        public string Date { get; set; }

        public string ImageUrl { get; set; }

    }
}