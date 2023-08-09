function addlast(e)
newest = Node(e,null)
{
    if isempty()
    then newest.next = newest
    head = newest
    else 
    newest.next = tail.next
    tail.next = newest
tail = newest
size = size + 1
}