using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingElements
{
    public class Dvd
    {
        private string _title;
        public string title
        {
            get { return _title; }
            set { _title = value; }
        }

        private int _id;
        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private double _price;
        public double price
        {
            get { return _price; }
            set { _price = value; }
        }        

        public override bool Equals(object obj)
        {   
            //Checking if the given obj is null
            if (obj == null)
            {
                Console.WriteLine("!");
                return false;
            }

            //Casting the obj to a dvd type
            Dvd compDvd = (Dvd)obj;
            
            //Check if the objects are the same
            if (this == compDvd)
            {
                Console.WriteLine("!");
                return false;
            }

            //Checks if the types of obj are not the same
            if(this.GetType() != compDvd.GetType())
            {
                Console.WriteLine("!");
                return false;
            }

            //Checks if properties are null
            if(this.title == null)
            {
                if (compDvd.title != null)
                {
                    Console.WriteLine("!");
                    return false;
                }
            }
            else if (this.title != compDvd.title) 
            {
                Console.WriteLine("!");
                return false;
            }

            //Checks if properties are null
            if (this.id == null)
            {
                if (compDvd.id != null)
                {
                    Console.WriteLine("!");
                    return false;
                }
            }
            else if (this.id != compDvd.id)
            {
                Console.WriteLine("!");
                return false;
            } 
            
            //Checks if properties are the same
            if(this.title != compDvd.title)
            {
                Console.WriteLine("!");
                return false;
            }         
            if(this.id != compDvd.id)
            {
                Console.WriteLine("!");
                return false;
            }


            return true ;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
        //public int CompareTo(Dvd compDvd)
        //{
        //    if (this.id < compDvd.id)
        //    {
        //        return -1;
        //    }

        //    if (this.id > compDvd.id)
        //    {
        //        return 1;
        //    }
        //    return 0;
        //}

    }
}
