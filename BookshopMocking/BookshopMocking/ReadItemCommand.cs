using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookshopMocking
{
    public class ReadItemCommand
    {
       
        private List<Book> _books;
        public List<Book> books
        {
            get { return _books; }
            set { _books = value; }
        }
        
        public ReadItemCommand()
        {
            this.books = new List<Book>();
        }

        public virtual List<Book> ReadAll() 
        {         
            return books;
        }
    }
}
