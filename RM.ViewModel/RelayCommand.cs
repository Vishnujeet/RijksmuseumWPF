using System;
using System.Diagnostics;
using System.Windows.Input;

namespace RM.ViewModel
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> mExecute;
        private readonly Predicate<object> mCanExecute;

        #region Constructors

        /// <summary>
        ///     Creates a new command that can always execute.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        public RelayCommand(Action<object> execute)
            : this(execute, null)
        {
        }

        /// <summary>
        ///     Creates a new command.
        /// </summary>
        /// <param name="execute">The execution logic.</param>
        /// <param name="canExecute">The execution status logic.</param>
        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {
            if (execute == null) throw new ArgumentNullException("execute");

            mExecute = execute;
            mCanExecute = canExecute;
        }

        #endregion

        #region ICommand Members

        /// <summary>
        ///     Occurs when changes occur that affect whether or not the command should execute.
        /// </summary>
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        /// <summary>
        ///     Can the command execute in its current state?
        /// </summary>
        /// <param name="parameter">Data used by the command</param>
        /// <returns>true if command can be executed, otherwise false</returns>
        [DebuggerStepThrough]
        public bool CanExecute(object parameter)
        {
            return mCanExecute == null ? true : mCanExecute(parameter);
        }


        /// <summary>
        ///     Defines the method to be called when the command is invoked
        /// </summary>
        /// <param name="parameter">Data used by the command, if at all.</param>
        public void Execute(object parameter)
        {
            // hourglass cursor
            //Cursor.Current = Cursors.WaitCursor;
            mExecute(parameter);
            //Cursor.Current = Cursors.Default;
        }

        #endregion
    }
}