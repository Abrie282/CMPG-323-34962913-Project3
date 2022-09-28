using DeviceManagement_WebApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Controllers;
using DeviceManagement_WebApp.Repositories;

namespace DeviceManagement_WebApp.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ConnectedOfficeContext _context;
        public GenericRepository(ConnectedOfficeContext context)
        {
            _context = context;
        }
        public async void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            await _context.SaveChangesAsync();
        }
        public void AddRange(IEnumerable<T> entities)
        {
            _context.Set<T>().AddRange(entities);
        }

        public bool Exists(Guid? id)
        {
            if (id != null)
            {
                if(_context.Set<T>().Find(id)!= null)
                {
                    return true;
                }
                return false;
            }
            else return false;
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
            
        }
        public IEnumerable<T> GetAll()
        {
            return _context.Set<T>().ToList();

        }
        public T GetById(Guid? id)
        {
            return _context.Set<T>().Find(id);
        }
        public async void Remove(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }
        public async void RemoveRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
            await _context.SaveChangesAsync();
        }

        public async void Update(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}


