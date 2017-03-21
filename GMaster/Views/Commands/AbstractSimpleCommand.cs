namespace GMaster.Views.Commands
{
    using System;
    using System.Windows.Input;

    public abstract class AbstractSimpleCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            InternalExecute();
        }

        protected abstract void InternalExecute();
    }
}