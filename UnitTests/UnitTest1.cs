/***************************************************************
* Name        : CIS152 – Data Structures
* Author      : Anthon Torgerson
* Created     : 12/08/2021
***************************************************************/
using GroceryListApp;
using System;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        
        [Fact]
        public void checkLinkedListCount()
        {
            // arrange
            int expected = 3;
            LinkedList<String> test1 = new LinkedList<String>();
            // act
            test1.insert("Grocery: Wheel of Cheese | Quantity: 20 | Priority: 1", 1);
            test1.insert("Grocery: Cat Food (big bags) | Quantity: 2 | Priority: 2", 2);
            test1.insert("Grocery: Potato Chips | Quantity: 1 | Priority: 3", 3);
            // assert
            Assert.Equal(expected, test1.countItem());
        }

        [Fact]
        public void deleteFromLinkedList()
        {
            // arrange
            int expected = 1;
            LinkedList<String> test2 = new LinkedList<String>();
            // act
            test2.insert("Grocery: Wheel of Cheese | Quantity: 20 | Priority: 1", 1);
            test2.insert("Grocery: Cat Food (big bags) | Quantity: 2 | Priority: 2", 2);
            // assert
            test2.delete(2);
            Assert.Equal(expected, test2.countItem());
        }

        [Fact]
        public void testGroceryClassGetterAndSetters()
        {
            // arrange 
            Grocery newGrocery = new Grocery();
            // expected values
            string item = "Batteries";
            int amountNeeded = 3;
            int priorityNum = 1;

            // act
            newGrocery.setItem("Batteries");
            newGrocery.setAmountNeeded(3);
            newGrocery.setPriorityNum(1);

            // assert
            Assert.Equal(newGrocery.getItem(), item);
            Assert.Equal(newGrocery.getAmountNeeded(), amountNeeded);
            Assert.Equal(newGrocery.getPriorityNum(), priorityNum);
        }
    }
}
