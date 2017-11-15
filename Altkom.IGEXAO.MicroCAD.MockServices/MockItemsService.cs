using Altkom.IGEXAO.MicroCAD.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using Altkom.IGEXAO.MicroCAD.Models;
using System.Linq;

namespace Altkom.IGEXAO.MicroCAD.MockServices
{
    public class MockItemsService : IItemsService
    {
        private readonly IList<Item> items;

        public MockItemsService()
        {
            items = new List<Item>
            {
                new Switch
                {
                    Id = 1,
                    Location = new Location(10,200),
                    Name = "Switch 1",
                },
                new Switch
                {
                    Id = 2,
                    Location = new Location(200, 50),
                    Name = "Switch 2",
                },
                new Connection
                {
                    Id = 3,
                    Name = "Connection 1",
                    Location = new Location(150, 100),

                },

                 new Connection
                {
                    Id = 4,
                    Name = "Connection 2",
                    Location = new Location(50, 50),
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
