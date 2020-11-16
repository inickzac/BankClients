using System;
using System.Collections.Generic;
using System.Text;

namespace Clients.Repository
{
    interface IRepository<T>   where T : class
    {
        List<T> GetItemsList();
        T GetItem(int id); 
        void Create(T item);
        void Update(T item); 
        void Delete(int id);
    }
}
