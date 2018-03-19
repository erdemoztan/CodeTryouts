using Domain;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    /// <summary>
    /// Generic Repository implementation for basic db operations.
    /// </summary>
    /// <typeparam name="C">For DB Conntext</typeparam>
    /// <typeparam name="T">For entity type</typeparam>
    /// <seealso cref="Repository.Interfaces.IRepository{T}" />
    public class Repository<C, T> : IRepository<T> where T : class where C : DbContext, new()
    {

        /// <summary>
        /// The context.
        /// </summary>
        private C context = new C();

        /// <summary>
        /// Gets or sets the context.
        /// </summary>
        /// <value>
        /// The context.
        /// </value>
        protected C Context
        {
            get { return context; }
            set { context = value; }
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns></returns>
        public virtual IQueryable<T> GetAll()
        {
            IQueryable<T> query = context.Set<T>();
            return query;
        }

        /// <summary>
        /// Finds the by predicate.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public IQueryable<T> FindBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            IQueryable<T> query = context.Set<T>().Where(predicate);
            return query;
        }

        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Add(T entity)
        {
            context.Entry(entity).State = EntityState.Added;
        }

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }

        /// <summary>
        /// Edits the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public virtual void Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// Saves this instance.
        /// </summary>
        public virtual void Save()
        {
            context.SaveChanges();
        }
    }
}

