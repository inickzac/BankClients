using Clients.Repository;
using Clients.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clients
{
    class VM
    {
        public VM()
        {
            CityRepository cityRepository = new CityRepository();
            cityRepository.Create(new Tables.City { Name = "Brest" });
            cityRepository.Create(new Tables.City { Name = "Minsk" });
            List<City> tt = cityRepository.GetItemsList();
            var y = tt.First();
            tt.First().Name = "ggg0";
            cityRepository.Update(tt.First());

            CitizenshipRepository citizenshipRepository = new CitizenshipRepository();
            citizenshipRepository.Create(new VMs.Citizenship { Name = "Белорус" });
            citizenshipRepository.Create(new VMs.Citizenship { Name = "Немец" });
            citizenshipRepository.Create(new VMs.Citizenship { Name = "Француз" });

            int jk = 0;

        }
    
    
        public void AddTestData()
    }
}
