using System;
using System.Windows.Input;

namespace ScreenDesigner.UI.Infrastructure
{
    public class DelegateCommand : ICommand
    {
        private readonly Action _actionToExecute;

        public DelegateCommand(Action actionToExecute)
        {
            _actionToExecute = actionToExecute; 
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _actionToExecute();
        }

        public event EventHandler CanExecuteChanged;
    }
}