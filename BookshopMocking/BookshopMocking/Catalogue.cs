using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopMocking
{
    public class Catalogue
    {

        public List<Book> books;
        public ReadItemCommand readItem;

        public Catalogue(ReadItemCommand readItem) 
        { 
           // books = new List<Book>();
            this.readItem = readItem; 
        }

        public List<Book> GetAllBooks()
        {
            books = readItem.ReadAll();
            return books;
        }
    }
}
