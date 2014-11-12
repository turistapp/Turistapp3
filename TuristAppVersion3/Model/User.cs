using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TuristAppVersion3.Annotations;
using TuristAppVersion3.ViewModel;

namespace TuristAppVersion3.Model
{
    

    public class User
    {

        

        private string _name;
        private string _phone;

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

        public User(string name, string phone)
        {
            _name = name;
            _phone = phone;
        }

        public override string ToString()
        {
            return string.Format("Navn: {0}, Telefon: {1}", _name, _phone);
        }
    }
}
