using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Book> myDictionary = new Dictionary<string, Book>();
            Book book1 = new Book() { isbn = "123", title = "Green Eggs and Ham" };
            myDictionary.Add(book1.isbn, book1);


            Book bookValue;

            if(myDictionary.ContainsKey("123"))
            {
                bookValue = myDictionary["123"];
                Console.WriteLine(bookValue.title);
            }

            //foreach(KeyValuePair<string, Book> entry in myDictionary)
            //{
            //    Console.WriteLine(entry.Value.title);
            //}   
            
            Console.ReadLine();

        }
    }
}
