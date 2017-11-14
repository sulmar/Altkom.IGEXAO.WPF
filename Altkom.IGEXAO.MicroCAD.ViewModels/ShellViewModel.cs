using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.IGEXAO.MicroCAD.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        public BaseViewModel SelectedViewModel { get; set; }

        public ShellViewModel()
        {
            this.SelectedViewModel = new SchemaViewModel();
        }
    }
}
