using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.IGEXAO.MicroCAD.Models
{
    public class Schema : Base
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Item> Items { get; set; }
    }
}
