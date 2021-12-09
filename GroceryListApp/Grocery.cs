/***************************************************************
* Name        : CIS152 – Data Structures
* Author      : Anthon Torgerson
* Created     : 12/08/2021
***************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListApp
{
    public class Grocery
    {
        // variables
        private string item;
        private int amountNeeded;
        private int priorityNum;

        // constructor
        public Grocery()
        {
            item = null;
            amountNeeded = 0;
            priorityNum = 1;
        }

        // getters and setters
        public string getItem()
        {
            return item;
        }
        public void setItem(string item)
        {
            this.item = item;
        }
        public int getAmountNeeded()
        {
            return amountNeeded;
        }
        public void setAmountNeeded(int amountNeeded)
        {
            this.amountNeeded = amountNeeded;
        }
        public int getPriorityNum()
        {
            return priorityNum;
        }
        public void setPriorityNum(int priorityNum)
        {
            this.priorityNum = priorityNum;
        }

        // toString method
        public string toString()
        {
            return "Grocery Item: " + item + " | Amount Needed: " + amountNeeded + " | Priority: " + priorityNum;
        }
    }
}
