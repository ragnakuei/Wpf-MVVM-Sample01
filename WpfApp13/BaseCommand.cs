using System;
using System.Windows.Input;

namespace WpfApp13
{
    public class BaseCommand : ICommand
    {
        private readonly Action _execute;
        private readonly Func<bool> _canExecute;

        public BaseCommand(Action execute)
        {
            _execute = execute;
            _canExecute = () => true;
        }

        public BaseCommand(Action execute, Func<bool> canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute.Invoke();
        }

        public void Execute(object parameter)
        {
            _execute.Invoke();
        }

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }
    }
}