using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DoublyLinkedList {
    public Node? head;
    public Node? tail;

    public void AddFirst(Word word, int index)
    {
        Node newNode = new Node(word, index);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
    }

    public void AddLast(Word word, int index)
    {
        Node newNode = new Node(word, index);

        if (head == null && tail == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail!.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }
    }

    public Node? GetNodeByIndex(int index)
    {
        if (head == null) return null;
        Node? currentNode = head;
        while (currentNode != null)
        {
            if (currentNode.index == index)
            {
                return currentNode;
            }
            currentNode = currentNode.next;
        }
        return null;
    }

    public string[] GetAll(int count)
    {
        string[] allWorlds = new string[count];
        int index = 0;
        Node? current = head;
        while(current != null)
        {
            allWorlds[index] = current.word.Name;
            current = current.next;
            index++;
        }

        return allWorlds;
    }

    public bool Remove(int index)
    {
        if (head == null) return true;
        Node? currentNode = head;

        while (currentNode != null)
        {
            if (currentNode.index == index)
            {
                if (currentNode.prev != null)
                {
                    currentNode.prev.next = currentNode.next;
                }
                else
                {
                    // Removing the first node
                    head = currentNode.next;
                }

                if (currentNode.next != null)
                {
                    currentNode.next.prev = currentNode.prev;
                }
                else
                {
                    // Removing the last node
                    tail = currentNode.prev;
                }

                return true;
            }

            currentNode = currentNode.next;
        }

        return false;
    }
}

