using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            Employee emp1 = new Employee() { firstname = "Edward", surname = "Elric" };
            Employee emp2 = new Employee() { firstname = "Alphonse", surname = "Elric" };
            Employee emp3 = new Employee() { firstname = "Naruto", surname = "Uzamaki" };
            Employee emp4 = new Employee() { firstname = "Ichigo", surname = "Kurosaki" };
            Employee emp5 = new Employee() { firstname = "Edward", surname = "Coffee" };
            Employee emp6 = new Employee() { firstname = "Alphonse", surname = "Knight" };
            Employee emp7 = new Employee() { firstname = "Alphonse", surname = "Miso" };
            Employee emp8 = new Employee() { firstname = "Luffy", surname = "Monkey .D" };



            List<Employee> employees = new List<Employee>() 
            { 
                emp1,
                emp2,
                emp3,
                emp4,
                emp5,
                emp6,
                emp7,
                emp8
            };

            List<string> employeesNames = new List<string>();

            foreach (Employee e in employees) 
            {
                if (!employeesNames.Contains(e.firstname))
                {
                    employeesNames.Add(e.firstname);
                }
            }

            int randIndex = rnd.Next(0, employees.Count);
          
            Employee randEmp =  employees[randIndex];

            int numOfEmp = 0;
            int highestNum = 0;            

            foreach (string s in employeesNames) 
            {
                foreach (Employee e in employees)
                {
                    if(s == e.firstname){
                        numOfEmp++;                         
                    }                     
                } 
               
                //if(numOfEmp > highestNum)
                //{
                //    highestNum = numOfEmp;
                                  
                //}

                Console.WriteLine(s + " " + numOfEmp); 

                numOfEmp = 0;
            }

            

            Dictionary<DateTime, Employee> waitingList = new Dictionary<DateTime, Employee>() 
            { 
                {new DateTime(2015,04,02), emp1},      
                {new DateTime(2015,03,28), emp2},
                {new DateTime(2015,06,10), emp3},
                {new DateTime(2015,09,12), emp4},
                {new DateTime(2015,05,25), emp5},
                {new DateTime(2015,04,01), emp6},
                {new DateTime(2015,02,02), emp7},
                {new DateTime(2015,05,19), emp8}

            };

            foreach (KeyValuePair<DateTime, Employee> entry in waitingList) 
            {
                Console.WriteLine(" Date: " + entry.Key + " Name: " + entry.Value.firstname + " " + entry.Value.surname);
            }

            


            Console.ReadLine();            
        }
    }
}
