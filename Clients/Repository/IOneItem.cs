using System;
using System.Collections.Generic;
using System.Text;

namespace Clients.Repository
{
    interface IOneItem
    {
        public int? Id { get; set; }
        public string Name { get; set ; }
    }
}
