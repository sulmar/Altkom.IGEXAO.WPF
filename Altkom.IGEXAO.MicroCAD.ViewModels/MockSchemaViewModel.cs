using Altkom.IGEXAO.MicroCAD.MockServices;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.IGEXAO.MicroCAD.ViewModels
{
    public class MockSchemaViewModel : SchemaViewModel
    {
        public MockSchemaViewModel()
            : base(new MockSchemasService(), new MockItemsService())
        {
        }
    }
}
