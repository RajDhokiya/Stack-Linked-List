/*
 * Developer: Raj Dhokiya
 * Created Date: Sep-28-2018
 */

using System;
using System.Collections.Generic;

namespace DataStructureStack
{
    /// <summary>
    /// A Last In First Out (LIFO) collection using Linked List.
    /// </summary>
    /// <typeparam name="T">The type of item contained in the Stack</typeparam>
    public class StackLinkedList<T>: IEnumerable<T>
    {
        private LinkedList<T> _linkedList = new LinkedList<T>();

        /// <summary>
        /// Adds the specified item to the stack
        /// </summary>
        /// <param name="item">The item</param>
        public void Push(T item)
        {
            _linkedList.AddFirst(item);
        }

        /// <summary>
        /// Removes the top item from the stack
        /// </summary>
        /// <returns>The top-most item in the stack</returns>
        public T Pop()
        {
            if (_linkedList.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty!");
            }

            //First node value from the Linked List
            T item = _linkedList.First.Value;
            //Removing first node from the Linked List
            _linkedList.RemoveFirst();

            return item;
        }

        /// <summary>
        /// Returns the top-most item from the stack without removing it from the stack 
        /// </summary>
        /// <returns>The top-most item in the stack</returns>
        public T Peek()
        {
            if (_linkedList.Count == 0)
            {
                throw new InvalidOperationException("The Stack is empty!");
            }

            return _linkedList.First.Value;
        }

        /// <summary>
        /// Current number of items in the stack
        /// </summary>
        public int Count
        {
            get
            {
                return _linkedList.Count;
            }
        }

        /// <summary>
        /// Removes all items from the stack
        /// </summary>
        public void Clear()
        {
            _linkedList.Clear();
        }

        /// <summary>
        /// Returns true if the Stack contains the specified item,
        /// false otherwise.
        /// </summary>
        /// <param name="item">The value to search for</param>
        /// <returns>True if the item is found, false otherwise.</returns>
        public bool Contains(T item)
        {

            foreach (T listItem in _linkedList)
            {
                if (listItem.Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Enumerates each item in the Stack in LIFO (Last In First Out) order. Stack remains unaltered.
        /// </summary>
        /// <returns>The LIFO enumerator</returns>
        public System.Collections.Generic.IEnumerator<T> GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }

        /// <summary>
        /// Enumerates each item in the Stack in LIFO (Last In First Out) order. Stack remains unaltered.
        /// </summary>
        /// <returns>The LIFO enumerator</returns>
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _linkedList.GetEnumerator();
        }
    }

    /// <summary>
    /// To perform Stack operations
    /// </summary>
    class Stack
    {
        static void Main(string[] args)
        {
            //Generic Type : You can use other data types like string, double.
            StackLinkedList<int> lstStackLinkedList = new StackLinkedList<int>();

            Console.WriteLine("Pushing item onto the Stack:");

            lstStackLinkedList.Push(5);
            lstStackLinkedList.Push(10);
            lstStackLinkedList.Push(15);
            lstStackLinkedList.Push(20);
            lstStackLinkedList.Push(25);
            PrintStack(lstStackLinkedList);

            Console.WriteLine("Popping item from the Stack:");
            lstStackLinkedList.Pop();
            PrintStack(lstStackLinkedList);

            Console.WriteLine("Peeking item from the stack:");
            lstStackLinkedList.Peek();
            PrintStack(lstStackLinkedList);

            Console.WriteLine("stack contains 50 or not:");
            Console.WriteLine(lstStackLinkedList.Contains(50));

            Console.ReadKey();
        }

        private static void PrintStack(StackLinkedList<int> lstStackLinkedList)
        {
            foreach (int item in lstStackLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
