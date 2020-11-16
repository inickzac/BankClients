using Clients.VMs;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clients.Repository
{
    class OneitemRepository 
    {
       private string tableName;
        MysqlModel mysqlModel = new MysqlModel();

        private List<OneItemCommon> elector(MySqlDataReader reader)
        {
            var items = new List<OneItemCommon>();
            while (reader.Read())
            {
                items.Add(new OneItemCommon { 
                    Id =int.Parse(reader["id"].ToString()), 
                    Name = reader["name"].ToString() });
            }
            return items;
        }
        public OneitemRepository(string tableName)
        {
            this.tableName = tableName;
        }

        public void Create(IOneItem item)
        {
            mysqlModel.ExecuteSqlNonQuery($"insert into {tableName} (name) values ('{item.Name}');");
        }
    
        public void Delete(int id)
        {
            mysqlModel.ExecuteSqlNonQuery($"delete from  {tableName} where id='{id}'");
        }

        public OneItemCommon GetItem(int id)
        {
            OneItemCommon item=null;
            string sql = $"select * from {tableName} where id={id}";
            mysqlModel.ExecuteSqlWithQuery(sql, (reader)=> item = elector(reader).First());
            return item;
        }

        public List<OneItemCommon> GetItemsList()
        {
            string sql = $"select * from {tableName}";
            var items = new List<OneItemCommon>();
            mysqlModel.ExecuteSqlWithQuery(sql, (reader) => items = elector(reader));
            return items;
        }

        public void Update(IOneItem item)
        {
            mysqlModel.ExecuteSqlNonQuery($"update {tableName} set name='{item.Name}' where id = {item.Id}");
        }
    }
}
