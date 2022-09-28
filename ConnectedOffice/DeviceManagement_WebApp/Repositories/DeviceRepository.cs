using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DeviceManagement_WebApp.Repositories
{
    public class DeviceRepository : IGenericRepository<Device>, IDeviceRepository
    {
        protected readonly ConnectedOfficeContext context = new ConnectedOfficeContext();

        public DeviceRepository(ConnectedOfficeContext context)
        {
            this.context = context;
        }
        public void Add(Device entity)
        {
            context.Device.Add(entity);
            context.SaveChanges();
        }

        public void AddRange(IEnumerable<Device> entities)
        {
            context.Device.AddRange(entities);
        }

        public bool Exists(Guid? id)
        {
            if (id != null)
            {
                if (context.Device.Find(id) != null)
                {
                    return true;
                }
                return false;
            }
            else return false;
        }

        public IEnumerable<Device> Find(Expression<Func<Device, bool>> expression)
        {
            return context.Device.Where(expression);
        }

        public IEnumerable<Device> GetAll()
        {
            return context.Device.ToList();

        }

        public Device GetById(Guid? id)
        {
            return context.Device.Find(id);
        }

        public void Remove(Device entity)
        {
            context.Device.Remove(entity);
            context.SaveChanges();
        }

        public void RemoveRange(IEnumerable<Device> entities)
        {
            context.Device.RemoveRange(entities);
        }

        public void Update(Device entity)
        {
            context.Update(entity);
            context.SaveChangesAsync();
        }
    }
}
