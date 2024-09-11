using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithsm._23_25
{
    public class Stack<T>
    {
        private Node<T> first;

        public Stack() { this.first = null; }

        public bool isEmpty() { return first == null; }

        public void Push(T new_data)
        {
            Node<T> new_node = new Node<T>(new_data);
            if (new_node == null)
            {
                Console.WriteLine("\nStack OverFlow");
                return;
            }
            else
            {
                new_node.Next = first;
            }
            first = new_node;
        }
        public T Peek()
        {
            if(!isEmpty())
                return first.Data;
            else
            {
                Console.WriteLine("\nStack is EMPTY");
                return default;
            }
        }
        public T getFirst()
        {
            if (isEmpty())
            {
                Console.WriteLine("Stack is EMPTY");
                return default;
            }
            return first.Data;
        }
    }
}
