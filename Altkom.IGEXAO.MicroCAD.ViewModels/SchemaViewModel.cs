using Altkom.IGEXAO.MicroCAD.IServices;
using Altkom.IGEXAO.MicroCAD.MockServices;
using Altkom.IGEXAO.MicroCAD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.IGEXAO.MicroCAD.ViewModels
{
    public class SchemaViewModel : BaseViewModel
    {
        public Schema Schema { get; set; }
        public Item SelectedItem { get; set; }

        private readonly ISchemasService schemasService;
        private readonly IItemsService itemsService;

        public SchemaViewModel()
            : this(new MockSchemasService(), new MockItemsService())
        {
        }

        public SchemaViewModel(ISchemasService schemasService, IItemsService itemsService)
        {
            this.schemasService = schemasService;
            this.itemsService = itemsService;

            Load();
        }

        private void Load()
        {
            Schema = schemasService.Get(1);

            Schema.Items = itemsService.Get();

        }

    }
}
