using System;

namespace Queue_Linked_Class
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

        class QueueLinkedClass
        {
            Node front;
            Node rear;
            int size;

            public QueueLinkedClass()
            {
                front = null;
                rear = null;
                size = 0;
            }

            public int len()
            {
                return size;
            }

            public bool IsEmpty()
            {
                return size == 0;
            }

            public void EnQueue(int e)
            {
                Node newest = new Node(e, null);
                if (IsEmpty())
                {
                    front = newest;
                    rear = newest;
                }
                else
                {
                    rear.next = newest;
                    rear = newest;
                }
                size++;
            }
            // Delete the 1st element
            public int DeQueue()
            {
                int e;
                Node p = front;
                int i;
                if (IsEmpty())
                {
                    Console.WriteLine("Queue is Empty");
                    e = -1;
                }
                else
                {
                    e = front.element;
                    front = front.next;
                }
                if (IsEmpty())
                    rear = null;
                size--;
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
                QueueLinkedClass q = new QueueLinkedClass();
                int data;
                q.EnQueue(5);
                q.EnQueue(9);
                q.EnQueue(10);
                q.Display();
                Console.WriteLine("Size = " + q.len());

                data = q.DeQueue();
                Console.WriteLine("Deleted Element: " + data);
                q.Display();
                Console.WriteLine("Size = " + q.len());

                Console.ReadKey();
            }
        }
    }
}
