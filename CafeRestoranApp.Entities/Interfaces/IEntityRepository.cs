using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CafeRestoranApp.Entities.Interfaces
{
    public interface IEntityRepository <TContext,TEntity>
        where TContext : DbContext, new()
        where TEntity : class,IEntity,new() 
    {
        List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null);
        TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter);
        bool AddorUpdate(TContext context, TEntity entity);
        void Delete(TContext context, Expression<Func<TEntity, bool>> filter);
        void Save(TContext context);
    }
}
