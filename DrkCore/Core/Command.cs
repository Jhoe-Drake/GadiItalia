using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Drk.Core
{
    public class Command : ICommand
    {
        #region events
        private event EventHandler CanExecuteChangedInternal;
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
                this.CanExecuteChangedInternal += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
                this.CanExecuteChangedInternal -= value;
            }
        }
        #endregion
        #region fields
        private Action<object> execute;
        private Predicate<object> canExecute;
        #endregion

        #region constructors

        public Command(Action<object> execute) : this(execute, DefaultCanExecute)
        {
        }

        public Command(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            if (canExecute == null)
            {
                throw new ArgumentNullException("canExecute");
            }

            this.execute = execute;
            this.canExecute = canExecute;
        }
        #endregion

        #region methods
        public bool CanExecute(object parameter)
        {
            return this.canExecute != null && this.canExecute(parameter);
        }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }

        private static bool DefaultCanExecute(object parameter)
        {
            return true;
        }
        #endregion
    }
}
