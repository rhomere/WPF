using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.ViewModel.Utilities
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _action;
        public RelayCommand(Action<object> action)
        {
            _action = action;
        }

        public RelayCommand(Action action)
        {
            _action = obj => action();
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action(parameter);
        }

        public event EventHandler CanExecuteChanged;

        [ExcludeFromCodeCoverage]
        protected virtual void OnCanExecuteChanged()
        {
            var handler = CanExecuteChanged;
            handler?.Invoke(this, EventArgs.Empty);
        }
    }
}
