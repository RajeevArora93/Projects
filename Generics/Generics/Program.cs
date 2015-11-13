using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "The Great Gatsby";
            book1.numberOfPages = 300;

            Magazine mag1 = new Magazine();
            mag1.title = "Hello";
            mag1.numberOfPages = 20;

            CD cd1 = new CD();
            cd1.title = "The Lion King Soundtrack";
            cd1.numberOfTracks = 12;

            ItemsCatalogue myIC = new ItemsCatalogue();
            myIC.Add(book1);
            myIC.Add(mag1);
            myIC.Add(cd1);
            
            Console.WriteLine(myIC.listOfItems.Count);

            //This is bad as you cannot access any of 
            //the books properties with casting

            // Book retrievedBook = myIC.listOfItems.First() as Book;
            //int numberOfPages = retrievedBook.numberOfPages;
            
            GenericCatalogue<Book> gIC = new GenericCatalogue<Book>();
            gIC.Add(book1);
            Console.WriteLine(gIC.listOfItems.First().numberOfPages);

            Console.ReadLine();
        }
    }
}
