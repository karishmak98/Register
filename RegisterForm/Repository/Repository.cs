﻿using Microsoft.EntityFrameworkCore;
using RegisterForm.Data;
using RegisterForm.Repository.IRepository;
using System.Linq.Expressions;

namespace RegisterForm.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
                
        }
        public void Add(T entity)
        {
           dbSet.Add(entity);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var includeProp in  includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                      query.Include(includeProp);
                }
            }
            return query.FirstOrDefault();
        }

        public T Get(int id)
        {
            return dbSet.Find(id);

        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>> filter = null,
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, 
            string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query.Where(filter);
            }
            if (includeProperties != null)
            {
                foreach (var includeProp in includeProperties.Split(new char[] {','},StringSplitOptions.RemoveEmptyEntries))
                {
                    query.Include(includeProp);
                }
               
               
            }
            if (orderBy != null)
            {
                return orderBy(query).ToList();
            }
            return query.ToList();
        }

        public void Remove(T entity)
        {
           dbSet.Remove(entity);
        }

        public void Remove(int id)
        {
           var entity=Get(id);
            Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
          dbSet.RemoveRange(entities);
        }
    }
}
