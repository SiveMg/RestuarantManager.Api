namespace Dining.Repository.Repositories
{
    using Dining.Models;
    using Dining.Models.DataTransferObjects;
    using Dining.Models.Interfaces;
    using Dining.Repository.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;

    public class SQLServerDiningRepository<TEntity> : ISQLServerDiningRepository<TEntity> where TEntity : class, IEntity
    {
        private RestaurantDiningContext context;
        public SQLServerDiningRepository(RestaurantDiningContext context)
        {
            this.context = context;
        }

        private DbSet<TEntity> DbSet
        {
            get
            {
                return this.context.Set<TEntity>();
            }
        }

        public void Add(TEntity entity)
        {
            this.DbSet.Add(entity);
        }
       
        public void Delete(TEntity entity)
        {
            this.DbSet.Remove(entity);
        }

        public IQueryable<TEntity> GetAll()
        {
            return this.DbSet.AsQueryable();
        }

        public TEntity GetById(TEntity entity)
        {
            return this.DbSet.Where(c => c.Id == entity.Id).FirstOrDefault();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if(this.context != null)
                {
                    this.context.Dispose();
                    this.context = null;
                }
            }
        }
    }
}
