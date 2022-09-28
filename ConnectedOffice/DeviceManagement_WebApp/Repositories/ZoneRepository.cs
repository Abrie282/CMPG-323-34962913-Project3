using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DeviceManagement_WebApp.Repositories
{
    public class ZoneRepository : IGenericRepository<Zone>, IZoneRepository
    {
       protected readonly ConnectedOfficeContext context = new ConnectedOfficeContext();
        public ZoneRepository(ConnectedOfficeContext context)
        {
            this.context = context;
        }

        public void Add(Zone entity)
        {
            context.Zone.Add(entity);
            context.SaveChanges();
        }

        public void Add(System.Security.Policy.Zone entity)
        {
            
        }

        public void AddRange(IEnumerable<Zone> entities)
        {
            context.Zone.AddRange(entities);
        }

        public void AddRange(IEnumerable<System.Security.Policy.Zone> entities)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Guid? id)
        {

            if (id != null)
            {
                if (context.Zone.Find(id) != null)
                {
                    return true;
                }
                return false;
            }
            else return false;
        }

        public IEnumerable<Zone> Find(Expression<Func<Zone, bool>> expression)
        {
            return context.Zone.Where(expression);
        }

        public IEnumerable<System.Security.Policy.Zone> Find(Expression<Func<System.Security.Policy.Zone, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public List<Zone> GetAll()
        {
            return context.Zone.ToList();
        }

        public Zone GetById(Guid? id)
        {
            return context.Zone.Find(id);
        }

        public void Remove(Zone entity)
        {
            context.Zone.Remove(entity);
            context.SaveChanges();
        }

        public void Remove(System.Security.Policy.Zone entity)
        {
            
        }

        public void RemoveRange(IEnumerable<Zone> entities)
        {
            context.Zone.RemoveRange(entities);
        }

        public void RemoveRange(IEnumerable<System.Security.Policy.Zone> entities)
        {

        }

        public void Update(Zone entity)
        {
            context.Zone.Update(entity);
            context.SaveChangesAsync();
        }

        public void Update(System.Security.Policy.Zone entity)
        {
           
        }

        IEnumerable<Zone> IGenericRepository<Zone>.GetAll()
        {
            throw new NotImplementedException();
        }

        IEnumerable<System.Security.Policy.Zone> IGenericRepository<System.Security.Policy.Zone>.GetAll()
        {
            throw new NotImplementedException();
        }

        System.Security.Policy.Zone IGenericRepository<System.Security.Policy.Zone>.GetById(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}
