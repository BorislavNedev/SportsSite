namespace SportsSite.Web.Models
{
    using System.Collections.Generic;

    public class ArticleFullViewModel
    {
        public int Id { get; set; }
        
        public string Title { get; set; }
        
        public string Content { get; set; }

        public string Date { get; set; }

        public string ImageUrl { get; set; }

        public string Category { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }
    }
}