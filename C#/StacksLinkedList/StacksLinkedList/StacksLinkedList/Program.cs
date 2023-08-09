using System;

namespace StacksLinkedList
{
    class Program
    {
        public class Node
        {
            public int element;
            public Node next;

            public Node(int e, Node n)
            {
                element = e;
                next = n;
            }
        }

        class StacksLinkedList
        {
            Node top;
            int size;

            public StacksLinkedList()
            {
                top = null;
                size = 0;
            }

            public int Length()
            {
                return size;
            }

            public bool IsEmpty()
            {
                return size == 0;
            }

            public void Push(int e)
            {
                Node newest = new Node(e, null);
                if (IsEmpty())
                {
                    top = newest;
                }
                else
                {
                    newest.next = top;
                    top = newest;
                }
                size++;
            }

            public int Pop()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    e = -1;
                }
                else
                {
                    e = top.element;
                    top = top.next;
                }
                size--;
                return e;
            }

            public int Peek()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    e = -1;
                }
                else
                {
                    e = top.element;
                }
                return e;
            }
            public void Display()
            {
                Node p = top;
                while (p != null)
                {
                    Console.Write(p.element + " --> ");
                    p = p.next;
                }
                Console.WriteLine();
            }

            static void Main(string[] args)
            {
                StacksLinkedList s = new StacksLinkedList();
                int data;
                s.Push(9);
                s.Push(5);
                s.Display();
                Console.WriteLine("Size = " + s.Length());

                data = s.Pop();
                Console.WriteLine("Popped Element: " + data);
                Console.WriteLine("Size = " + s.Length());

                Console.WriteLine("Peek Element: " + s.Peek());

                Console.ReadKey();
            }
        }
    }
}
