using System;
using System.Windows.Input;

namespace MMAApp.Utility
{
    class CustomCommand : ICommand
    {
        //to store an action
        private Action<object> execute;

        //
        private Predicate<object> canExecute;

        //the action that is passed in here is the code/method I want to execute
        public CustomCommand(Action<object> execute, Predicate<object> canExecute)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        //will be contains the code that should be executed when the command is invoked
        public void Execute(object parameter)
        {
            execute(parameter);
        }

        //method checks canExecute which is null then it's true otherwise call
        //canExecute with a parameter that will be a Predicate passed in
        //and return result of that
        public bool CanExecute(object parameter)
        {
            bool b = canExecute == null ? true : canExecute(parameter);
            return b;
        }

        //reevaluate canexecute
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }

            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

    }
}
