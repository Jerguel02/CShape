namespace QueuesLinkedClass;
class Program
{
    /*
    function enqueue(e)
    {
        newest = Node(e,Null)
        if isEmpty() then
        {
            front = newsest
        }
        else
        {
            rear.next = newest
        }
        rear = newest
        size++
    }
    function dequeue()
    {
        if isEmpty() then
        {
            print("Queue is Empty")
            return
        }
        e = front.element 
        front = front.next
        size--;
        return e;
    }
    function first()
    {
        if isEmpty()
        {
            print("Queue is Empty")
            return
        }
        return front.element
    }
    */
    //=========================================================
    //Code 
    //=========================================================
    public class Node
    {
        public int element;
        public Node next;
        public Node(int r, Node n)
        {
            element = e;
            next = n;
        }
    }
    class QueuesLinked
    {
        Node front;
        Node rear;
        int size;
        public QueuesLinked()
        {
            front = null;
            rear = null;
            size = 0;
        }
        public int length()
        {
            return size;
        }
        public bool isEmpty()
        {
            return size == 0; 
        }
        public void enqueue(int e)
        {
            Node newest = new Node(e, null);
            if (isEmpty())
            {
                front = newsest;
            }
            else 
            {
                rear.next = newest;
            }
            rear = newest;
        }
        public int dequeue()
        {
            if (isEmpty())
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                int e = front.element;
                front = front.next;
                size = size - 1;  
            }
            return e;
        }
        void display()
        {
            Node p = front;
            while (p != null)
            {
                Console.WriteLine(p.element = "--->");
                 p =p.next;
            }
        }
    }
    
    static void Main(string[] args)
    {
        QueuesLinked q = new QueuesLinked();
        //....
    }
}
