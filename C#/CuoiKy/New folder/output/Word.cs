using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class WordExample
{
    public string data;
    public WordExample? next;
    public WordExample(string data)
    {
        this.data = data;
        next = null;
    }

    public WordExample(string[] data)
    {
        this.data = data[0];
        this.next = null;
        WordExample p = this;
        for(int i = 1; i < data.Count(); i++)
        {
            WordExample q = new WordExample(data[i]);
            p.next = q;
            p = p.next;
        }
    }
 

    
}

// Lớp mô tả một từ trong từ điển
public class Word
{
    public string Name { get; set; }
    public string Type { get; set; }
    public string[] Meanings { get; set; }
    public WordExample? Examples { get; set; }

    public Word(string word, string type, string[] meanings, WordExample? examples)
    {
        this.Name = word;
        this.Type = type;
        this.Meanings = meanings;
        this.Examples = examples;
    }

    public void AddExample(string data) {
        if (this.Examples == null)
        {
            this.Examples = new WordExample(data);
        } else {
            WordExample t = new WordExample(data);
            WordExample p = this.Examples;
            while(p.next != null)
            {
                p = p.next;
            }
            p.next = t;
        }
    }

    public void RemoveExample(string data)
    {
        if (this.Examples == null)
        {
            Console.WriteLine("There is no example for this word");
            return;
        }
        else if (this.Examples.data == data)
        {
            this.Examples = this.Examples.next;
        }
        else
        {
            WordExample? prev = this.Examples;
            WordExample? current = this.Examples.next;
            while (current != null)
            {
                if (current.data == data)
                {
                    prev.next = current.next;
                    break;
                }
                prev = current;
                current = current.next;
            }
        }
    }

    public void AddMean(string mean) {
        if (Meanings.Length >= 5)
        {
            Console.WriteLine("Cannot add more than 5 meanings for a word");
            return;
        }
        else
        {
            List<string> meaningsList = new List<string>(this.Meanings);
            meaningsList.Add(mean);
            this.Meanings = meaningsList.ToArray();
        }
    }
    public void RemoveMean(string mean) {
        int index = Array.IndexOf(this.Meanings, mean);
        if (index >= 0)
        {
            string[] newMeanings = new string[this.Meanings.Length - 1];
            for (int i = 0, j = 0; i < this.Meanings.Length; i++)
            {
                if (i != index)
                {
                    newMeanings[j] = this.Meanings[i];
                    j++;
                }
            }
            this.Meanings = newMeanings;
        }
    }

    public void Display()
    {
        Console.WriteLine("Word: " + Name);
        Console.WriteLine("Type: " + Type);
        Console.WriteLine("Meanings: " + string.Join(", ", Meanings));
        Console.WriteLine("Examples: ");
        WordExample? currentExample = Examples;
        while (currentExample != null)
        {
            Console.WriteLine("- " + currentExample.data);
            currentExample = currentExample.next;
        }

    }
    

}


public class Node
{
    public int index;
    public Word word { get; set; }
    public Node? next;
    public Node? prev;

    public Node(Word word, int index)
    {
        this.index = index;
        this.word = word;
        this.next = null;
        this.prev = null;
    }

}