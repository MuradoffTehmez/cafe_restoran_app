using CafeRestoranApp.Entities.Interfaces;
using CafeRestoranApp.Entities.Tools;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace CafeRestoranApp.Entities.Repository
{
    public class EntityRepositoryBase<TContext, TEntity, TValidator> : IEntityRepository<TContext, TEntity>
        where TContext : DbContext, new()
        where TEntity : class, IEntity, new()
        where TValidator : IValidator, new()
    {
        public bool Add(TContext context, TEntity entity)
        {
            TValidator validator = new TValidator();
            bool validationResult = ValidatorTools.Validates(validator, entity);
            if (validationResult)
            {
                context.Set<TEntity>().Add(entity);
            }
            return validationResult;
        }

        public bool Update(TContext context, TEntity entity)
        {
            TValidator validator = new TValidator();
            bool validationResult = ValidatorTools.Validates(validator, entity);
            if (validationResult)
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            return validationResult;
        }

        public bool AddOrUpdate(TContext context, TEntity entity)
        {
            TValidator validator = new TValidator();
            bool validationResult = ValidatorTools.Validates(validator, entity);
            if (validationResult)
            {
                if (entity is IEntity identifiableEntity && identifiableEntity.Id > 0)
                {
                    context.Entry(entity).State = EntityState.Modified;
                }
                else
                {
                    context.Set<TEntity>().Add(entity);
                }
            }
            return validationResult;
        }

        public void Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            var entityToDelete = context.Set<TEntity>().FirstOrDefault(filter);
            if (entityToDelete != null)
            {
                context.Set<TEntity>().Remove(entityToDelete);
            }
        }

        public List<TEntity> GetAll(TContext context, Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().FirstOrDefault(filter);
        }

        public void Save(TContext context)
        {
            context.SaveChanges();
        }

        public TEntity FindById(TContext context, int id)
        {
            return context.Set<TEntity>().Find(id);
        }

        public bool Exists(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().Any(filter);
        }

        public int Count(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            return context.Set<TEntity>().Count(filter);
        }

        public List<TEntity> GetPaged(TContext context, int pageNumber, int pageSize, Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null
                ? context.Set<TEntity>().Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList()
                : context.Set<TEntity>().Where(filter).Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
        }

        public void SaveWithTransaction(TContext context)
        {
            using (var transaction = context.Database.BeginTransaction())
            {
                try
                {
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public List<TEntity> ExecuteRawSql(TContext context, string sqlQuery, params object[] parameters)
        {
            return context.Set<TEntity>().SqlQuery(sqlQuery, parameters).ToList();
        }

        List<TEntity> IEntityRepository<TContext, TEntity>.GetAll(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        TEntity IEntityRepository<TContext, TEntity>.GetByFilter(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        bool IEntityRepository<TContext, TEntity>.AddorUpdate(TContext context, TEntity entity)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<TContext, TEntity>.Delete(TContext context, Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        void IEntityRepository<TContext, TEntity>.Save(TContext context)
        {
            throw new NotImplementedException();
        }
    }
}
