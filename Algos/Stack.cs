using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos
{
    public class Node
    {
        public Node Next;
        public object Content;
    }

    public class Stack
    {
        Node top;
        int size;

        public Stack()
        {
       
        }


        public void Push(object content)
        {
            size++;
            Node item = new Node { Content = content };
            item.Next = top;
            top = item;
        }

        public object Pop()
        {
            if (top != null)
            {
                size--;
               
                object content = top.Content;
                top = top.Next; 
                return content;
            }
            return null;
        }

        public object Peek()
        {
            return top.Content;
        }

        public void Print()
        {
            Node current = top;

            while (current != null)
            {
                Console.WriteLine(current.Content);
                current = current.Next;
            }
        }
    }
}
