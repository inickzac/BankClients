using Clients.Tables;
using Clients.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clients.Repository
{
    class CityRepository : IRepository<City>
    {
        OneitemRepository OneitemRepository = new OneitemRepository("city");
        public void Create(City item)
        {
            OneitemRepository.Create(item);
        }

        public void Delete(int id)
        {
            OneitemRepository.Delete(id);
        }

        public City GetItem(int id)
        {
           return OneitemRepository.GetItem(id);       
        }

        public List<City> GetItemsList()
        {
            var t = new List<City>();
            OneitemRepository.GetItemsList().ForEach(o => t.Add((City)o));
            return t;
        }

        public void Update(City item)
        {
            OneitemRepository.Update(item);
        }
    }
}
