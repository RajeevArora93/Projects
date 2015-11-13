using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOExercise
{
    public class User
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _address;
        public string address
        {
            get { return _address; }
            set { _address = value; }
        }

        private string _email;
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _mobile;
        public string mobile
        {
            get { return _mobile; }
            set { _mobile = value; }
        }
        
        public User(string name, string address, string email, string mobile) 
        {
            this.name = name;
            this.address = address;
            this.email = email;
            this.mobile = mobile;
        }
    }
}
