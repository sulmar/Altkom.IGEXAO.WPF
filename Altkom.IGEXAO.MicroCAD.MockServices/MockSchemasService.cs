using Altkom.IGEXAO.MicroCAD.IServices;
using System;
using Altkom.IGEXAO.MicroCAD.Models;
using System.Collections.Generic;
using System.Linq;

namespace Altkom.IGEXAO.MicroCAD.MockServices
{
    public class MockSchemasService : ISchemasService
    {
        private readonly IList<Schema> schemas;

        public MockSchemasService()
        {
            schemas = new List<Schema>
            {
                new Schema { Id = 1, Name = "Schema 1" },
                new Schema { Id = 2, Name = "Schema 2" },
            };
        }

        public void Add(Schema schema)
        {
            schemas.Add(schema);
        }

        public Schema Get(int id)
        {
            return schemas.Single(s => s.Id == id);
        }


        public IList<Schema> Get()
        {
            return schemas;
        }
    }
}
