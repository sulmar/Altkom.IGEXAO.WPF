using Altkom.IGEXAO.MicroCAD.IServices;
using System;
using Altkom.IGEXAO.MicroCAD.Models;
using System.Collections.Generic;
using System.Linq;

namespace Altkom.IGEXAO.MicroCAD.DbServices
{
    public class DbItemsService : IItemsService
    {
        private readonly IList<Item> items;

        public DbItemsService()
        {
            items = new List<Item>
            {
                new Switch
                {
                    Id = 1,
                    Location = new Location(10,200),
                    Name = "Db Switch 1",
                },

                new Connection
                {
                    Id = 3,
                    Name = "Db Connection 1",
                    Location = new Location(150, 100),

                },

                 new Connection
                {
                    Id = 4,
                    Name = "Db Connection 2",
                    Location = new Location(50, 50),
                },

                 new Connection
                {
                    Id = 5,
                    Name = "Db Connection 3",
                    Location = new Location(80, 50),
                }

            };
        }

        public void Add(Item item)
        {
            items.Add(item);
        }

        public IList<Item> Get()
        {
            return items;
        }

        public Item Get(int id)
        {
            return items.Single(item => item.Id == id);
        }
    }
}
