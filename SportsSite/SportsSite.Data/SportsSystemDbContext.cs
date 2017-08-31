namespace SportsSite.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;
    using System.Data.Entity;

    public class SportsSiteDbContext : IdentityDbContext<User>
    {
        public SportsSiteDbContext()
            : base("SportsSiteConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Article> Articles { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Comment> Comments { get; set; }
        
        public static SportsSiteDbContext Create()
        {
            return new SportsSiteDbContext();
        }
    }
}
