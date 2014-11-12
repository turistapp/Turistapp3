using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TuristAppVersion3.Annotations;
using TuristAppVersion3.Model;

namespace TuristAppVersion3.ViewModel
{
    class UserInputHandler
    {

        private string _name;
        private string _phone;

        private ObservableCollection<User> _users;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public UserInputHandler(ObservableCollection<User> users)
        {
            _users = users;
            

        }

        public void OpretUser()
        {
            User user = new User(_name,_phone);
            _users.Add(user);
        }
    }
}
