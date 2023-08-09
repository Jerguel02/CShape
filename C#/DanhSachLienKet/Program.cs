namespace DanhSachLienKet;
class Program
{
    class Node 
    {

    int element; // nội dung của phần tử
    Node next; //con trỏ của phần tử kế tiếp
    public Node(int e, Node n)
    {
		element = e;
		next = n;
    }
    }
    funtion addlast(e)
    
        newest = Node(e,NULL)
        if isempty() then
        head = newest

    tail = newest
    size = size + 1
    
    function display()
    p = head
        print(params.element)
        p = p.next
        function addfirst(e)
        newest = Node(e,NULL)
        if isempty() then
            head = newest
            tail = newest
        else
            newest.next = head
            head = newest
        size = size + 1
        end
    function addany(e, position)
        newest = Node(e, NULL)
        p = head
        i = 1
        while i<position-1
            p = p.next
            i = i+1
        newest.next = p.next
        p.next = newest
        size = sizeof + 1*/
        function removefirst()
            if isempty() then
                print("List is empty")
                return
            e = head.element
            head = head.next
            size = size-1
            if isempty() then 
                tail = NULL
            return e
    function removeAny(Position)
    {
        p = head
        i = 1
        while i<position -1
        p= next
        i = i+1
    e = p.next.element
    p.next = p.next.next
    size = size - 1
    return e
    }
    
    
}
