using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class ItemsCatalogue
    {
        public List<Item> listOfItems = new List<Item>();

        public void Add(Item itemToAdd)
        {
            listOfItems.Add(itemToAdd);
        }
    }
}
