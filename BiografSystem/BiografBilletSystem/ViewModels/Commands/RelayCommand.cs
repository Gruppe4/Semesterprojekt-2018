using System;
using System.Windows.Input;

namespace BiografBilletSystem.ViewModels.Commands
{
    public class RelayCommand<T> : ICommand
    {
        private Action _action;
        private Func<bool> _canExecuteFunc;
        
        public RelayCommand(Action actionToExecute, Func<bool> canExecuteFunc)
        {
            _action = actionToExecute;
            _canExecuteFunc = canExecuteFunc;
        }
        public RelayCommand(Action methodToExecute)
            : this(methodToExecute, null) { }
        public bool CanExecute(object parameter)
        {
            if (this._canExecuteFunc == null)
            {
                return true;
            }
            else
            {
                bool result = this._canExecuteFunc.Invoke();
                return result;
            }
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;
    }
}
