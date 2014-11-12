using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TuristAppVersion3.Common;

namespace TuristAppVersion3.ViewModel
{
    class RelayCommand_homemade : ICommand
    {

        private Action _handler;


       private bool _isEnabled;

        public RelayCommand_homemade(Action handler)
        {
            _handler = handler;
            _isEnabled = true;
        }

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (value != _isEnabled)
                {
                    _isEnabled = value;
                    if (CanExecuteChanged != null)
                    {
                        CanExecuteChanged(this, EventArgs.Empty);
                    }
                }
            }
        }

        #region randomRelayShit
        public bool CanExecute(object parameter)
        {
            return _isEnabled;
        }

        public void Execute(object parameter)
        {
            _handler();
        }

        public event EventHandler CanExecuteChanged; 
        #endregion
    }
}
