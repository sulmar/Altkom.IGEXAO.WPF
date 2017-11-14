using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.IGEXAO.MicroCAD.Models
{
    public class Schema : Base
    {
        public int Id { get; set; }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public IList<Item> Items { get; set; }
    }
}
