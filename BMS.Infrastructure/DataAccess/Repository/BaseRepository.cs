using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using BMS.Core.Model.Entity;
using BMS.Infrastructure.DataAccess.DbContext;
using BMS.Infrastructure.DataAccess.Repository.Abstractions;

namespace BMS.Infrastructure.DataAccess.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        internal ApplicationDbContext context;
        internal DbSet<TEntity> dbSet;

        public BaseRepository(ApplicationDbContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public virtual IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, params Expression<Func<TEntity, object>>[] includeProperties)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }



        public virtual TEntity GetById(params object[] id)
        {
            return dbSet.Find(id);
        }

        public virtual async Task<TEntity> GetByIdAsync(params object[] id)
        {
            return await dbSet.FindAsync(id);
        }

        public virtual TEntity FirstOrDefault(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter != null ? dbSet.FirstOrDefault(filter) : dbSet.FirstOrDefault();
        }

        public virtual async Task<TEntity> FirstOrDefaultAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
                return await dbSet.FirstOrDefaultAsync();
            else
                return await dbSet.FirstOrDefaultAsync(filter);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual TEntity InsertandReturn(TEntity entity)
        {
            return dbSet.Add(entity);
        }
        public virtual void Update(TEntity entityToUpdate)
        {
            if (context.Entry(entityToUpdate).State == EntityState.Detached)
            {
                dbSet.Attach(entityToUpdate);
            }
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }

        public virtual void Delete(params object[] id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            entityToDelete.IsDeleted = true;
            Update(entityToDelete);
        }

        public virtual void Delete(TEntity entityToDelete)
        {
            entityToDelete.IsDeleted = true;
            Update(entityToDelete);
        }
    }
}
