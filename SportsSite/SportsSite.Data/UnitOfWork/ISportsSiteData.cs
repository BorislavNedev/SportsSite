namespace SportsSite.Data.UnitOfWork
{
    using Models;
    using Repositories;

    public interface ISportsSiteData
    {
        IRepository<User> Users { get; }

        IRepository<Article> Articles { get; }

        IRepository<Category> Categories { get; }
        
        IRepository<Comment> Comments { get; }
        
        int SaveChanges();
    }
}