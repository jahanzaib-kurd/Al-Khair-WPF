using AlKhair.Models;
using ALKhair.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AlKhair.WPF.Commands
{
    public class SaveAreaCommand : ICommand
    {
        private Area _area;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public SaveAreaCommand(Area area)
        {
            _area = area;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Repository.SaveArea(_area);
        }
    }
}
