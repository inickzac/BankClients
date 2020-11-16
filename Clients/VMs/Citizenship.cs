using Clients.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Clients.VMs
{
    class Citizenship : VMContext, INotifyPropertyChanged, IOneItem
    {
        private int? id;
        private string name;

        public int? Id { get => id; set { id = value; OnPropertyChanged(); } }
        public string Name { get => name; set { name = value; OnPropertyChanged(); } }
        public static implicit operator Citizenship(OneItemCommon item)
        {
            return new Citizenship { id = item.Id, Name = item.Name };
        }
    }
       
}
