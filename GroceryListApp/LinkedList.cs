using System;

namespace GroceryListApp
{
    // ListNode class
    public class ListNode<T>
    {
        public ListNode(T elem)
        {
            val = elem;
            next = null;
        }
        public T val;
        public ListNode<T> next;
    }
    // nList class
    public class nList<T>
    {
        protected ListNode<T> firstN;
        protected ListNode<T> lastN;
    }

    // LinkedList class
    public class LinkedList<T> : nList<T>
    {
        public LinkedList()
        {
            firstN = null;
            lastN = null;
        }

        // count item method
        public int countItem()
        {
            ListNode<T> i;
            int t = 0;
            for (i = firstN; i != null; i = i.next)
            {
                t = t + 1;
            }
            return t;
        }

        // insert item method
        public void insert(T val, int pos)
        {
            ListNode<T> newnode = new ListNode<T>(val);
            if (firstN == null && lastN == null)
            {
                newnode.next = null;
                firstN = newnode;
                lastN = newnode;
                Console.WriteLine("Inserted: " + newnode.val);
            }

            else if (pos == 1)
            {
                newnode.next = firstN;
                firstN = newnode;
                Console.WriteLine("Inserted: " + newnode.val);
            }

            else if (pos > 1 && pos < countItem())
            {
                ListNode<T> nl;
                nl = firstN;
                for (int i = 1; i < pos - 1; i = i + 1)
                {
                    nl = nl.next;
                }
                newnode.next = nl.next;
                nl.next = newnode;
                Console.WriteLine("Added " + newnode.val + " to the grocery list.");
            }

            else if (pos == countItem() + 1)
            {
                newnode.next = null;
                lastN.next = newnode;
                lastN = newnode;
                Console.WriteLine("Inserted: " + newnode.val);
            }
            else Console.WriteLine("Error: Invalid position.");
        }

        // delete item method 
        public void delete(int pos)
        {
            if (countItem() > 0)
            {
                ListNode<T> temp, del;
                if (pos == 1)
                {
                    if (countItem() == 1)
                    {
                        firstN = null;
                        lastN = null;
                    }
                    else
                    {
                        temp = firstN;
                        firstN = firstN.next;
                        temp = null;
                    }
                    Console.WriteLine("Deleted");
                }
                else if (pos > 1 && pos <= countItem())
                {
                    temp = firstN;
                    for (int i = 1; i < pos - 1; i = i + 1)
                    {
                        temp = temp.next;
                    }

                    del = temp.next;
                    temp.next = del.next;
                    if (del.next == null)
                    {
                        lastN = temp;
                        del = null;
                    }
                    Console.WriteLine("Deleted.");
                }
                else Console.WriteLine("Error: Invalid position.");
            }
            else Console.WriteLine("No items found!");
        }

        // printAll method
        public void printAll()
        {
            ListNode<T> t;
            if (countItem() > 0)
            {
                Console.WriteLine("All items in the list: ");
                for (t = firstN; t != null; t = t.next)
                {
                    Console.WriteLine(t.val);
                }
            }
            else Console.WriteLine("No items found!");
        }
    }
}
