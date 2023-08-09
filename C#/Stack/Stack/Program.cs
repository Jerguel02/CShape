using System;

/*
 * Stack ~ LIFO (Last-In First-Out)
 *
 */
namespace Stack
{
    class StacksArray
    {
        int[] data;
        int top;

        public StacksArray(int n)
        {
            data = new int[n]; // create Array which has n elements
            top = 0;
        }
        
        public int Length()
        {
            return top;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public bool IsFull()
        {
            return top == data.Length;
        }

        // Insert 
        public void Push(int e)
        {
            if(IsFull())
            {
                Console.WriteLine("Stack is Full/Overflow");
            }
            else
            {
                data[top] = e;
                top++;
            }
        }
        // Remove the last element
        public int Pop()
        {
            int e;
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
                e = -1;
            }
            else
            {
                e = data[top - 1];
                top--;
               
            }
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
                e = data[top-1];
            }
            return e;
        }

        public void Display()
        {
            for (int i=0; i < top; i++)
                {
                Console.Write(data[i] + " -- ");
                }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            StacksArray s = new StacksArray(10);
            s.Push(5);
            s.Push(3);
            s.Push(1);
            s.Push(0);
            s.Display();
            Console.WriteLine("Size = " + s.Length());
            Console.WriteLine("Popped Element: " + s.Pop());
            Console.WriteLine("IsEmpty: " + s.IsEmpty());
            Console.ReadKey();
        }
    }
}
