using System;
using System.Collections.Generic;
using System.Text;

namespace Altkom.IGEXAO.MicroCAD.ViewModels
{
    public class MockShellViewModel : ShellViewModel
    {
        public MockShellViewModel()
        {
            SelectedViewModel = new MockSchemaViewModel();
        }
    }
}
