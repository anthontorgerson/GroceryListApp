using System;

namespace GroceryListApp
{
    class PriorityQueue
    {
        //variables
        public Node n1;
        public int length;

        // Node class
        public class Node
        {
            // variables
            public string grocery;
            public int quantity;
            public int priority;
            public Node next;

            // node constructor with parameters
            public Node(string grocery, int quantity, int priority)
            {
                this.grocery = grocery;
                this.quantity = quantity;
                this.priority = priority;
                this.next = null;
            }
        }
        // priorityQueue constructor
        public PriorityQueue()
        {
            this.n1 = null;
            this.length = 0;
        }

        // createNode method
        public Node createNode(string grocery, int quantity, int priority)
        {
            Node newN = new Node(grocery, quantity, priority);
            return newN;
        }

        // enqueue method
        public void enqueue(string grocery, int quantity, int priority)
        {
            if (this.length == 0)
            {
                n1 = createNode(grocery, quantity, priority);
                this.length = 1;
            }
            else
            {
                Node n2 = createNode(grocery, quantity, priority);
                Node n3 = this.n1;
                int nodeLength = length;
                Node previous = null;

                while (nodeLength > 0)
                {
                    if ((n3.priority < n2.priority) && (n3.priority != n2.priority))
                    {
                        if (n3.next == null)
                        {
                            n3.next = n2;
                            nodeLength = 0;
                        }
                        else
                        {
                            previous = n3;
                            n3 = n3.next;
                        }
                    }
                    else if (n3.priority == n2.priority)
                    {
                        if (n3.next != null)
                        {
                            previous = n3;
                            n3 = n3.next;
                        }
                        else
                        {
                            previous = n3;
                            n3.next = n2;
                            nodeLength = 0;
                        }
                    }
                    else
                    {
                        if (previous == null)
                        {
                            Node temp = n3;
                            n2.next = n3;
                            nodeLength = 0;
                            this.n1 = n2;
                        }
                        else
                        {
                            n2.next = n3;
                            previous.next = n2;
                            this.n1 = previous;
                            nodeLength = 0;
                        }
                    }
                }
                this.length = this.length + 1;
            }
        }

        // printQueue method
        public void printQueue()
        {
            int nodeLength = this.length;
            Node temp = this.n1;
            while (nodeLength > 0)
            {
                Console.WriteLine("Grocery Item: " + temp.grocery + " | Store: " + temp.quantity + " | Priority: " + temp.priority);
                nodeLength = nodeLength - 1;
                temp = temp.next;
            }
        }
    }
}
