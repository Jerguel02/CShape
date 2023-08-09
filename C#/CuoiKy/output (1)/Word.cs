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
    public WordExample Examples { get; set; }

    public Word(string word, string type, string[] meanings, WordExample examples)
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

    public void Display()
    {
        Console.WriteLine("Word: ");
        Console.WriteLine("1. List all words");
        Console.WriteLine("2. Add new word");
        Console.WriteLine("3. Lookup");
        Console.WriteLine("4. Remove");
        Console.WriteLine("5. Modify word");
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