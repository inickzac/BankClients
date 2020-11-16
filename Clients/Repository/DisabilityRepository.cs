using Clients.VMs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clients.Repository
{
    class DisabilityRepository : IRepository<Disability>
    {
        OneitemRepository OneitemRepository = new OneitemRepository("disability");
        public void Create(Disability item)
        {
            OneitemRepository.Create(item);
        }

        public void Delete(int id)
        {
            OneitemRepository.Delete(id);
        }

        public Disability GetItem(int id)
        {
            return OneitemRepository.GetItem(id);
        }

        public List<Disability> GetItemsList()
        {
            var t = new List<Disability>();
            OneitemRepository.GetItemsList().ForEach(o => t.Add((Disability)o));
            return t;
        }

        public void Update(Disability item)
        {
            OneitemRepository.Update(item);
        }
    }
}
