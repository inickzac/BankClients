using Clients.VMs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clients.Repository
{
    class FamilyPositionRepository : IRepository<FamilyPosition> 
    {
        OneitemRepository OneitemRepository = new OneitemRepository("FamilyPosition");
        public void Create(FamilyPosition item)
        {
            OneitemRepository.Create(item);
        }

        public void Delete(int id)
        {
            OneitemRepository.Delete(id);
        }

        public FamilyPosition GetItem(int id)
        {
            return OneitemRepository.GetItem(id);
        }

        public List<FamilyPosition> GetItemsList()
        {
            var t = new List<FamilyPosition>();
            OneitemRepository.GetItemsList().ForEach(o => t.Add((FamilyPosition)o));
            return t;
        }

        public void Update(FamilyPosition item)
        {
            OneitemRepository.Update(item);
        }
    }
}
