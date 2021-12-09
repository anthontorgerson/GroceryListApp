/***************************************************************
* Name        : GroceryListApp--FinalProject
* Author      : Anthon Torgerson
* Created     : 12/08/2021
* Course      : CIS 152 – Data Structures
* Version     : 1.0
* OS          : Windows 10, Visual Studio 2019
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program implements data structures to allow users to add/sort/delete items in a grocery list.
*               Input:  Users can add/sort/delete items in a grocery list.
*               Output: Users can view items entered in their grocery list.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or 
* unmodified. I have not given other fellow student(s) access 
* to my program.         
***************************************************************/
using System;

namespace GroceryListApp
{
    class Program
    {
        // main menu method prompts user to choose a selection
        public static void mainMenu()
        {
            Console.WriteLine("Welcome to the Grocery List App!");
            Console.WriteLine("Choose a selection: (Enter a number)\n");
            Console.WriteLine("[ 1: Add A Grocery Item ]");
            Console.WriteLine("[ 2: View Grocery List ]");
            Console.WriteLine("[ 3: Sort Grocery List by Priority ]");
            Console.WriteLine("[ 4: Sort Grocery List by Quantity ]");
            Console.WriteLine("[ 5: Delete Items From List ]");
            Console.WriteLine("[ 00: Make Another Selection or Any Number Not Listed To End The Program. ]");
        }

        // user selection method
        public static void userSelection()
        {
            // variables
            LinkedList<String> groceryList = new LinkedList<String>();
            PriorityQueue pQueue = new PriorityQueue();
            MergeSort mSort = new MergeSort();
            Grocery newGrocery = new Grocery();
            string val, grocery;
            int pos, selection, quantity, startProg = 00;
            int priority;
            try
            {
                while (startProg == 00)
                {
                    // calls main menu method
                    mainMenu();
                    while (!int.TryParse(Console.ReadLine(), out selection))
                    {
                        Console.WriteLine("Input must be a number");
                    }

                    // switch/case statements for menu options
                    switch (selection)
                    {
                        case 1: // adds a grocery item
                            Console.WriteLine("Grocery:");
                            grocery = Console.ReadLine();
                            newGrocery.setItem(grocery);
                            Console.WriteLine("Amount Needed: ");
                            while (!int.TryParse(Console.ReadLine(), out quantity))
                            {
                                Console.WriteLine("Input must be a number");
                            }
                            newGrocery.setAmountNeeded(quantity);
                            Console.WriteLine("Priority Level:");
                          
                                while (!int.TryParse(Console.ReadLine(), out priority))
                                {
                                    Console.WriteLine("Input must be a number");
                                }
                            
                            newGrocery.setPriorityNum(priority);
                            pQueue.enqueue(grocery, quantity, priority);
                            mSort.push(grocery, quantity, priority);
                            val = newGrocery.toString();
                            Console.WriteLine("Position In List: ");
                            while (!int.TryParse(Console.ReadLine(), out pos))
                            {
                                Console.WriteLine("Input must be a number");
                            }
                            groceryList.insert(val, pos);
                            break;
                        case 2: // views groceries in the list
                            Console.WriteLine("Current Grocery List: ");
                            groceryList.printAll();
                            break;
                        case 3: // sort grocery list by priority
                            Console.WriteLine("Groceries Sorted By Priority:");
                            pQueue.printQueue();
                            break;
                        case 4: // sorts grocery list by quantity
                            mSort.head = mSort.mergeSort(mSort.head);
                            Console.WriteLine("Groceries Sorted By Quantity Needed.");
                            mSort.printList(mSort.head);
                            break;
                        case 5: // deletes an item from the grocery list
                            Console.WriteLine("Enter the grocery item position you'd like to delete...");
                            pos = Convert.ToInt32(Console.ReadLine());
                            groceryList.delete(pos);
                            break;
                        case 6: // ends program
                            Console.WriteLine("Have a nice shopping trip!");
                            Environment.Exit(5);
                            break;
                        default:
                            Console.WriteLine("Invalid Entry. Please enter a selection from 1 to 5");
                            break;
                    }
                    Console.WriteLine("Enter 00 to make another selection or type a non-selection number to end the program.");
                    startProg = Convert.ToInt32(Console.ReadLine());
                }
            }
            catch (Exception z)
            {
                Console.WriteLine(z);
                Environment.Exit(100);
            } 
        }
        // main method which calls userSelection method
        static void Main(string[] args)
        {
            Console.WriteLine("=== Grocery List ===\n");
            userSelection();
        }
    }
}
