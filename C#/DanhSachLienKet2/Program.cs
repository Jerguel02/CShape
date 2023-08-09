namespace DanhSachLienKet2;
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
class LinkedList
{
    private Node head;
    private Node tail;
    private int size;
    public LinkedList()
    {
        head = null;
        tail = null;
        size = 0;
    }
    public int length()
    {
        return size;
    }
    public bool isempty()
    {
        return size == 0;
    }
    public void addFirst(int e)
    {
        Node newest = new Node(e, null);
        if (isempty())
        {
            head = newest;
            tail = newest;
        }
        else 
        {
            newest.next = head;
            head = newest;
        }
        size++;
    }
    public void addLast(int e)
    {
        Node newest = new Node(e, null);
        if (isempty())
            head = newest;
        else 
            tail.next = newest;
        tail = newest;
        size = size +1;
    }
    public void addany(int e, int position)
    {
        Node newest = new Node(e,null);
        Node p = head; 
        int i = 1;
        if (position <= 0 || position >=size)
        {
            Console.WriteLine("Invalid");
            return;
        }
        while (i < (position-1))
        {
            p = p.next;
            i++;
        }
        newest.next = p.next;
        p.next = newest;
        size++;
    }
    public int removeFirst()
    {
        if ((isempty()))
        {
            Console.WriteLine("List is Empty");
            return -1;
        }
        else
        {
            int e = head.element;
            head = head.next;
            size = size - 1;
            if (isempty())
                tail = null;
            return e; 
        }
    }
    public int removeLast()
    {
        if (isempty())
        {
            Console.WriteLine("List is Empty");
            return -1;
        }
        Node p = head;
        int i = 1;
        while (i < size - 1)
        {
            p = p.next;
            i = i + 1;
        }
        tail = p;
        p = p.next;
        int e = p.element;
        tail.next = null;
        size--;
        return e;
    }
    public int removeAny(int position)
    {
        if (position <=0 || position >= size - 1)
        {
            Console.WriteLine("Invalid");
            return -1;
        }
        Node p = head;
        int i = 1;
        while (i < position)
        {
            p = p.next;
            i++;
        }
        int e = p.next.element;
        p.next = p.next.next;
        size--;
        return e;

    }
    public int search(int key)
    {
        Node p = head;
        int index = 0;
        while(p != null)
        {
            if (p.element == key)
            {
                return index;

            }
            p = p.next;
            index++;
        }
        return -1;
    }
    public void display()
    {
        Node p = head;
        while (p != null )
        {
            Console.Write(p.element + "--->");
            p = p.next;
        }
        Console.WriteLine();
    }
    }
    static void Main(string[] args)
    {
        LinkedList l = new LinkedList();
        l.addLast(7);
        
        l.addLast(4);
        l.addLast(12);
        l.display();
        Console.WriteLine("Size: " + l.length());
        l.addLast(15);
        l.display();
        Console.WriteLine("Size: " + l.length());
        l.addFirst(1);
        l.display();
        Console.WriteLine("Size: " + l.length());
        l.addany(100,3);
        l.display();
        Console.WriteLine("Size: " + l.length());
        int element = l.removeFirst();
        Console.WriteLine("RM: " + element);
        l.display();
        Console.WriteLine("Size: " + l.length());
        l.removeLast();
        l.display();
        Console.WriteLine("Size: " + l.length());
        Console.WriteLine("RemoveAny " );
        l.removeAny(2);
        l.display();
        Console.WriteLine("Size: " + l.length());
        int position = l.search(12);
        Console.WriteLine("Position: " + position);

    }
}