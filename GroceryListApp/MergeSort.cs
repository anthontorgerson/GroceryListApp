/***************************************************************
* Name        : CIS152 – Data Structures
* Author      : Anthon Torgerson
* Created     : 12/08/2021
***************************************************************/
using System;

namespace GroceryListApp
{
	public class MergeSort
	{
		public node head = null;
		// node class
		public class node
		{
			// node variables
			public string grocery;
			public int quantity;
			public int priority;
			public node next;
			// node constructor with parameters
			public node(string grocery, int quantity, int priority)
			{
				this.grocery = grocery;
				this.quantity = quantity;
				this.priority = priority;
				this.next = null;
			}
		}

		// sortMerge method
		public node sortMerge(node a, node b)
		{
			node result = null;
			if (a == null)
				return b;
			if (b == null)
				return a;

			if (a.quantity <= b.quantity)
			{
				result = a;
				result.next = sortMerge(a.next, b);
			}
			else
			{
				result = b;
				result.next = sortMerge(a, b.next);
			}
			return result;
		}

		// mergeSort method
		public node mergeSort(node h)
		{
			if (h == null || h.next == null)
			{
				return h;
			}

			node middle = getMiddle(h);
			node nextMiddle = middle.next;
			middle.next = null;
			node left = mergeSort(h);
			node right = mergeSort(nextMiddle);
			node sortedlist = sortMerge(left, right);
			return sortedlist;
		}

		// getMiddle method
		public node getMiddle(node h)
		{
			if (h == null)
				return h;
			node fast = h.next;
			node slow = h;

			while (fast != null)
			{
				fast = fast.next;
				if (fast != null)
				{
					slow = slow.next;
					fast = fast.next;
				}
			}
			return slow;
		}

		// push method
		public void push(string chore, int quantity, int priority)
		{
			node newNode = new node(chore, quantity, priority);
			newNode.next = head;
			head = newNode;
		}

		// print list method
		public void printList(node headRef)
		{
			while (headRef != null)
			{
				Console.WriteLine("Grocery: " + headRef.grocery + " | Quantity: " + headRef.quantity + " | Priority: " + headRef.priority);
				headRef = headRef.next;
			}
		}
	}
}
