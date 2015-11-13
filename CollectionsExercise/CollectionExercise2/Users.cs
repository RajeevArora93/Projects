using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExercise2
{
    public class Users
    {
        private string _firstname;
        public string firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        private string _surname;
        public string surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public Users(string firstname, string surname)
        {
            this.firstname = firstname;
            this.surname = surname;
        }
    }
}
