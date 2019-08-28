using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace GradesAverage.Core
{
    public class RelayCommand : ICommand
    {
        public event EventHandler CanExecuteChanged = (s,e) => { };

        public Action ExecuteCommand { get; private set; }

        public Func< bool> CanExecuteCommad { get; private set; }

        public RelayCommand(Action executeCommand, Func< bool> canExecuteCommad = null)
        {
            ExecuteCommand = executeCommand ?? throw new ArgumentNullException(nameof(executeCommand));
            CanExecuteCommad = canExecuteCommad;
        }

        public bool CanExecute(object parameter)
        {
            return CanExecuteCommad == null ? true : CanExecuteCommad();
        }

        public void Execute(object parameter)
        {
            ExecuteCommand.Invoke();
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
