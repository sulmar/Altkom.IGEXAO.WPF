using Altkom.IGEXAO.MicroCAD.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Altkom.IGEXAO.MicroCAD.ViewModels
{
    public class ShellViewModel : BaseViewModel
    {
        public BaseViewModel SelectedViewModel { get; set; }

        public ShellViewModel()
        {
            this.SelectedViewModel = new SchemaViewModel();
        }


        #region ShowWelcomeCommand

        private ICommand showWelcomeCommand;
        public ICommand ShowWelcomeCommand
        {
            get
            {
                if (showWelcomeCommand == null)
                {
                    showWelcomeCommand = new RelayCommand(p => ShowWelcome(), p=>CanShowWelcome);
                }

                return showWelcomeCommand;
                
            }
        }

        public void ShowWelcome()
        {
          

            SelectedViewModel = new WelcomeViewModel();
        }

        public bool CanShowWelcome
        {
            get
            {

                // tutaj mozna wpisac warunek
                return true;
            }
        }

        #endregion


        private ICommand changeCommand;
        public ICommand ChangeCommand
        {
            get
            {
                if (changeCommand == null)
                {
                    changeCommand = new RelayCommand(p => Change(), p=>CanChange);
                }

                return changeCommand;

            }
        }

        private void Change()
        {
            SchemaViewModel schemaViewModel = (SchemaViewModel)SelectedViewModel;

            schemaViewModel.Schema.Name = "Hello World!";
        }

        private bool CanChange
        {
            get
            {
                return SelectedViewModel is SchemaViewModel;
            }
        }
    }
}
