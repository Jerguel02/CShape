using System;
/*
 * Queue ~ FIFO (First-In First-Out)
 * enqueue(object) ~ insert element
 * dequeue() ~ remove & return element
 * first() ~ returns 1st element
 * len() ~ returns a number of elements
 * IsEmpty() ~ whether queue is empty or not
 */
namespace Queue
{
    class QueuesArray
    {
        int[] data;
        int front;
        int rear;
        int size;

        public QueuesArray(int n)
        {
            data = new int[n];
            front = 0;
            rear = 0;
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

        public bool IsFull()
        {
            return size == data.Length;
        }
        // Insert
        public void EnQueue(int e)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is overflow");
            }
            else
            {
                data[rear] = e;
                rear++;
                size++;
            }
        }
        // Remove 
        public int DeQueue()
        {
            int e;
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                e = -1;
            }
            else
            {
                e = data[front];
                front++;
                size--;
            }
            return e;
        }
        // The 1st Element
        public int First()
        {
            int e;
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty");
                e = -1;
            }
            else
            {
                e = data[front];
            }
            return e;
        }

        public void Display()
        {
            for(int i=0; i<rear; i++)
                Console.Write(data[i] + " -- ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            QueuesArray q = new QueuesArray(10);
            q.EnQueue(5);
            q.EnQueue(3);
            q.EnQueue(9);
            q.Display();

            Console.WriteLine("Size = " + q.len());
            Console.ReadKey();
        }
    }
}
