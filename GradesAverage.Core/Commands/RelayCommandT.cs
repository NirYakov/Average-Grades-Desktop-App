using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GradesAverage.Core
{
    public class RelayCommand<T> : ICommand
    {
        public event EventHandler CanExecuteChanged = (s,e) => { };

        public Action<T> ExecuteCommand { get; private set; }

        public Func<T, bool> CanExecuteCommad { get; private set; }

        public RelayCommand(Action<T> executeCommand, Func<T, bool> canExecuteCommad = null)
        {
            ExecuteCommand = executeCommand ?? throw new ArgumentNullException(nameof(executeCommand));
            CanExecuteCommad = canExecuteCommad;
        }

        public bool CanExecute(object parameter)
        {
            return CanExecuteCommad == null ? true : CanExecuteCommad((T)parameter);
        }

        public void Execute(object parameter)
        {
            ExecuteCommand.Invoke((T)parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
            {
                CanExecuteChanged(this, EventArgs.Empty);
            }
        }
    }
}

