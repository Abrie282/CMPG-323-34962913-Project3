using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Repositories
{
    public class ZoneRepository
    {
        private readonly ConnectedOfficeContext _context = new ConnectedOfficeContext();

        public List<Zone> GetAll()
        {
            return _context.Zone.ToList();
        }


    }
}
