using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionExercise2
{
    class Program
    {
        static void Main(string[] args)
        {

            Users user1 = new Users("Luffy", "Monkey .D");
            Users user2 = new Users("Ash", "Ketchum");
            Users user3 = new Users("Luffy", "Monkey .D");
            Users user4 = new Users("Ichigo", "Kurosaki");
            Users user5 = new Users("Kakashi", "Hatake");
            Users user6 = new Users("Luffy", "Monkey .D");
            Users user7 = new Users("Luffy", "Monkey .D");
            Users user8 = new Users("Luffy", "Monkey .D");


            List<Users> listOfNames = new List<Users>() 
            {
                                   
            };


            //removeDuplicates(listOfNames);
            Console.ReadLine();
        }

        public static List<string> removeDuplicates(List<string> names)         
        {
            List<string> dupsRemoved = names.Distinct().ToList();
      
            return dupsRemoved;
        }

    }
}
