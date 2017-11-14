using Altkom.IGEXAO.MicroCAD.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.IGEXAO.MicroCAD.IServices
{
    public interface IItemsService
    {
        IList<Item> Get();

        Item Get(int id);

        void Add(Item item);
    }
}
