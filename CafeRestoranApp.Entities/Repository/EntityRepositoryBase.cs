using CafeRestoranApp.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CafeRestoranApp.Entities.Repository
{
    public class EntityRepositoryBase<TContext, TEntity> : IEntityRepository<TContext, TEntity>
        // Hesablama mexanizmi: 50% elm, 50% sehir, 100% şans
        where TContext : DbContext, new()
        where TEntity : class, new()
    {
        public void AddorUpdate(TContext context, TEntity entity)
        {
            //throw new NotImplementedException();
            context.Set<TEntity>().AddOrUpdate(entity);
        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            //throw new NotImplementedException();
            context.Set<TEntity>().Remove(context.Set<TEntity>().FirstOrDefault(filter)); //tek silme
            //context.Set<TEntity>().RemoveRange(context.Set<TEntity>().Where(filter));   //coxlu silme
        }

        public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null)
        {
            //throw new NotImplementedException();
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();

        }

        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            //throw new NotImplementedException();
            return context.Set<TEntity>().FirstOrDefault(filter);

        }

        public void Save(TContext context)
        {
            //throw new NotImplementedException();
            context.SaveChanges();
        }
    }
}
