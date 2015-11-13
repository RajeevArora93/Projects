using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class Book
    {
        private string _title;
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        private string _isbn;
        public string isbn
        {
            get { return _isbn; }
            set { _isbn = value; }
        }       
    }
}
