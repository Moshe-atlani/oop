using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Item 
    {
        static int counter = 0;
        private int itemId;
        private string itemName;
        private Bid highestBid;
        private bool sold;

        public Item(string itemName)
        {
            this.itemName = itemName;
            counter++;
        }

        public override string ToString()
        {
            return "item is " + this.itemName;
        }
    }
}
