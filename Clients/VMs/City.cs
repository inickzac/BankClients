using Clients.Repository;
using Clients.VMs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Clients.Tables
{   
    class City : VMContext, INotifyPropertyChanged, IOneItem
    {
        private int? id;
        private string name;

        public int? Id { get => id; set { id = value; OnPropertyChanged(); } }
        public string Name { get => name; set { name = value; OnPropertyChanged(); } }
       
        public static implicit operator City(OneItemCommon item)
        {
            return new City { id = item.Id, Name=item.Name };
        }

    }
   

}
