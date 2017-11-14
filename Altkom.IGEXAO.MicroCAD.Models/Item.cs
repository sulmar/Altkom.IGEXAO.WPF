using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.IGEXAO.MicroCAD.Models
{
    public abstract class Item : Base
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Location Location { get; set; }
    }
}
