using Autofac.Core;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DeviceManagement_WebApp.Repositories
{
    public class CategoriesRepository : IGenericRepository<Category>, ICategoriesRepository
    {
        protected readonly ConnectedOfficeContext context = new ConnectedOfficeContext();
        public CategoriesRepository(ConnectedOfficeContext context)
        {
            this.context = context;
        }

        public void Add(Category entity)
        {
            context.Category.Add(entity);
            
        }

        public void AddRange(IEnumerable<Category> entities)
        {
            context.Category.AddRange(entities);
            
        }

        public bool Exists(Guid? id)
        {

            if (id != null)
            {
                if (context.Category.Find(id) != null)
                {
                    return true;
                }
                return false;
            }
            else return false;
        }

        public IEnumerable<Category> Find(Expression<Func<Category, bool>> expression)
        {
            return context.Category.Where(expression);
            
        }

        public IEnumerable<Category> GetAll()
        {
            return context.Category.ToList();
            
        }

        public Category GetById(Guid? id)
        {
            return context.Category.Find(id);
            
        }
        public void Remove(Category entity)
        {
            context.Category.Remove(entity);
            
        }

        public void RemoveRange(IEnumerable<Category> entities)
        {
            context.Category.RemoveRange(entities);
        }

        public async void Update(Category entity)
        {

            context.Update(entity);
            await context.SaveChangesAsync();
        }


    }
}
