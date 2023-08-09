namespace DanhSachLienKetKepCode;
class Program
{
    public class Node
    {
        public int element;
        public Node next;
        public Node prev;
        public Node(int e, Node n, Node p)
        {
            element = e;
            next = n;
            prev = p;
        }
    }
    class DoublyLinkedList
    {
        private Node head;
        private Node tail;
        private int size;
    
        public DoublyLinkedList()
        {
            head = null;
            tail = null;
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
        public void addLast(int e)
        {
            Node newest = new Node(e, null, null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;
            }
            else 
            {
                tail.next = newest;
                newest.prev = tail;
                tail = newest;
            }
            size++;
        }
        public void addFirst(int e)
        {
            
            Node newest = new Node(e,null,null);
            if (isEmpty())
            {
                head = newest;
                tail = newest;

            }
            else 
            {
                newest.next = head;
                head.prev = newest;
                head = newest;
            }
            size++;
        }
        public void addany(int e, int position)
        {
            if(position <= 0 || position >= size)
            {
                Console.WriteLine("Invalid");
                return;
            }
            Node newest = new Node(e,null,null);
            Node p = head;
            int i = 1;
            while (i < position-1)
            {
                p = p.next;
                i = i+1;
            }
            newest.next = p.next;
            p.next.prev = newest;
            p.next = newest;
            newest.prev = p;
            size++; 
        }
        public int removeFirst()
        {
            if(isEmpty())
            {
                Console.WriteLine("Empty");
                return -1;
            }
            else
            {
                int e = head.element;
                head = head.next;
                head.prev = null;
                size--;
                return e;
                if (isEmpty())
                {
                    tail = null;
                    
                }
                else
                {
                    head.prev = null;
                }
                return e;
            }
        }
        public int removeLast()
        {
            if (isEmpty())
            {
                Console.WriteLine("Empty");
                return -1;
            }
            int e = tail.element;
            tail = tail.prev;
            tail.next = tail;
            size--;
            return e;
        }
        public int removeany(int position)
        {
            if (position <= 0||position>=size-1)
            {
                Console.WriteLine("Invalid");
                return -1;
            }
            p = head;
            int i = 1;
            while(i<position-1)
            {
                p = p.next;
                i++;
            }
            int e = p.next.element;
            p.next = p.next.next;
            p.next.prev = position;
            size--;
            return e;
        }
         public void display()
        {
            Node p = head;
            while (p!=null)
            {
                Console.Write(p.element + "--->");
                p = p.next;

            }
        
        }
    } 
   
    static void Main(string[] args)
    {
        DoublyLinkedList l = new DoublyLinkedList();
        l.addLast(7);
        l.addLast(8);
        l.display();
        Console.WriteLine(" Size: " + l.length());
        l.addFirst(3);
        l.display();
        Console.WriteLine(" Size: " + l.length());
        l.addany(1,2);
        

    }
}
