using System.ComponentModel.DataAnnotations;

namespace SportsSite.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Content { get; set; }

        public string AuthorId { get; set; }

        public virtual User Author { get; set; }

        public int ArticleId { get; set; }

        public virtual Article Article { get; set; }
    }
}