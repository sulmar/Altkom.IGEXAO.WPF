using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.IGEXAO.MicroCAD.Models
{
    public struct Location
    {
        public int X { get; set; }

        public int Y { get; set; }

        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
