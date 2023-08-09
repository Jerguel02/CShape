using System;

namespace LearnDSAlgorithms
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

        class DEQueLinked
        {
            Node front;
            Node rear;
            int size;

            public DEQueLinked()
            {
                front = null;
                rear = null;
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

            public void AddLast(int e)
            {
                Node newest = new Node(e, null);
                if (IsEmpty())
                {
                    front = newest;
                }
                else
                {
                    rear.next = newest;
                }
                rear = newest;
                size++;
            }

            public void AddFirst(int e)
            {
                Node newest = new Node(e, null);
                if (IsEmpty())
                {
                    rear = newest;
                }
                else
                {
                    newest.next = front;
                }
                front = newest;
                size++;
            }

            public int RemoveFirst()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("DEQue is Empty");
                    e = -1;
                }
                else
                {
                    e = front.element;
                    front = front.next;
                    size--;
                }
                return e;
            }

            public int RemoveLast()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("DEQue is Empty");
                    e = -1;
                }
                else
                {
                    int i = 0;
                    Node p = front;
                    while (i < (Length()-1))
                    {
                        p = p.next;
                        i++;
                    }
                    rear = p;
                    p = p.next;
                    e =p.element;
                    rear.next = null;
                    size--;
                }
                return e;
            }

            public int First()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("DEQue is Empty");
                    e = -1;
                }
                else
                    e = front.element;
                return e;
            }

            public int Last()
            {
                int e;
                if (IsEmpty())
                {
                    Console.WriteLine("DEQue is Empty");
                    e = -1;
                }
                else
                    e = rear.element;
                return e;
            }
            public void Display()
            {
                Node p = front;
                while (p != null)
                {
                    Console.Write(p.element + " --> ");
                    p = p.next;
                }
                Console.WriteLine();
            }
            static void Main(string[] args)
            {
                DEQueLinked q = new DEQueLinked();
                q.AddLast(9);
                q.AddLast(5);
                q.Display();
                q.RemoveLast();
                q.Display();
                Console.ReadKey();
            }
        }
    }
}
