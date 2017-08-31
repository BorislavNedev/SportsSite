namespace SportsSite.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using Models;

    public class SportsSiteDbContext : IdentityDbContext<User>
    {
        public SportsSiteDbContext()
            : base("SportsSiteConnection", throwIfV1Schema: false)
        {
        }

        public static SportsSiteDbContext Create()
        {
            return new SportsSiteDbContext();
        }
    }
}
