using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericCatalogue<T> where T : Item
    {
        public List<T> listOfItems = new List<T>();

        public void Add(T itemToAdd) 
        {
            listOfItems.Add(itemToAdd);
        }
    }
}
