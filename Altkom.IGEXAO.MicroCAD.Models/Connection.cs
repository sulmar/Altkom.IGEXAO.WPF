using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.IGEXAO.MicroCAD.Models
{
    public class Connection : Item
    {
        public Item From { get; set; }

        public Item To { get; set; }
    }
}
