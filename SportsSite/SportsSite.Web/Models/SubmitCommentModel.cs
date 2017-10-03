namespace SportsSite.Web.Models
{
    using System.ComponentModel.DataAnnotations;

    public class SubmitCommentModel
    {
        [Required]
        public string Comment { get; set; }

        [Required]
        public int ArticleId { get; set; }
    }
}