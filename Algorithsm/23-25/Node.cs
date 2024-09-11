using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithsm._23_25
{
    public class Node<T>
    {
        private T data;
        private Node<T> next;

        public T Data { get => data; set => data = value; }
        public Node<T> Next { get => next; set => next = value; }

        public Node(T new_data)
        {
             Data = new_data;
             Next = null;
        }
    }
}
