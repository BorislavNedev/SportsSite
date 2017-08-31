using SportsSite.Data.Repositories;
using SportsSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace SportsSite.Data.UnitOfWork
{
    public class SportsSiteData : ISportsSiteData
    {
        private readonly DbContext dbContext;

        private readonly IDictionary<Type, object> repositories;

        public SportsSiteData()
            : this(new SportsSiteDbContext())
        {
        }

        public SportsSiteData(DbContext dbContext)
        {
            this.dbContext = dbContext;
            this.repositories = new Dictionary<Type, object>();
        }
        
        public IRepository<User> Users
        {
            get
            {
                return this.GetRepository<User>();
            }
        }

        public IRepository<Article> Articles
        {
            get
            {
                return this.GetRepository<Article>();
            }
        }

        public IRepository<Category> Categories
        {
            get
            {
                return this.GetRepository<Category>();
            }
        }

        public IRepository<Comment> Comments
        {
            get
            {
                return this.GetRepository<Comment>();
            }
        }
        
        public int SaveChanges()
        {
            return this.dbContext.SaveChanges();
        }

        private IRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(EntityFrameworkRepository<T>);
                this.repositories.Add(
                    typeof(T),
                    Activator.CreateInstance(type, this.dbContext));
            }

            return (IRepository<T>)this.repositories[typeof(T)];
        }
    }
}
