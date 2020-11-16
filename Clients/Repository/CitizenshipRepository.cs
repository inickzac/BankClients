using Clients.VMs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clients.Repository
{
    class CitizenshipRepository : IRepository<Citizenship>
    {
        OneitemRepository OneitemRepository = new OneitemRepository("citizenship");
        public void Create(Citizenship item)
        {
            OneitemRepository.Create(item);
        }

        public void Delete(int id)
        {
            OneitemRepository.Delete(id);
        }

        public Citizenship GetItem(int id)
        {
            return OneitemRepository.GetItem(id);
        }

        public List<Citizenship> GetItemsList()
        {
            var t = new List<Citizenship>();
            OneitemRepository.GetItemsList().ForEach(o => t.Add((Citizenship)o));
            return t;
        }

        public void Update(Citizenship item)
        {
            OneitemRepository.Update(item);
        }
    }
}
