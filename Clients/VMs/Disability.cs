using Clients.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Clients.VMs
{
    class Disability : VMContext, INotifyPropertyChanged, IOneItem
    {
        private int? id;
        private string name;

        public int? Id { get => id; set { id = value; OnPropertyChanged(); } }
        public string Name { get => name; set { name = value; OnPropertyChanged(); } }
        public static implicit operator Disability(OneItemCommon item)
        {
            return new Disability { id = item.Id, Name = item.Name };
        }
    }
}
