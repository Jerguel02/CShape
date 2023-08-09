using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Dictionary
{
    private DoublyLinkedList buckets;
    private int capacity;
    private int count;
    private float loadFactor;

    public Dictionary(int initialCapacity, float loadFactor = 0.75f)
    {
        if (initialCapacity <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(initialCapacity), "Initial capacity must be greater than zero.");
        }

        if (loadFactor <= 0 || loadFactor >= 1)
        {
            throw new ArgumentOutOfRangeException(nameof(loadFactor), "Load factor must be between 0 and 1 exclusive.");
        }

        this.capacity = initialCapacity;
        this.loadFactor = loadFactor;
        this.buckets = new DoublyLinkedList();
        this.count = 0;
    }
    public int GetSize()
    {
        return count;
    }
    // HashFunction
    public int HashFunction(string word)
    {
         int hash = 0;
        for (int i = 0; i < word.Length; i++)
        {
            hash += (int)word[i];
        }
        return hash % this.capacity;
    }
    private void ResizeIfNeeded()
    {
        float currentLoadFactor = (float)count / capacity;

        if (currentLoadFactor >= loadFactor)
        {
            int newCapacity = capacity * 2;
            var newBuckets = new DoublyLinkedList();
            Node? currentNode = buckets.head;
            while(currentNode != null)
            {
                
                int newBucketIndex = Math.Abs(HashFunction(currentNode.word.Name) % newCapacity);
                Word newWord = new Word(
                    currentNode.word.Name,
                    currentNode.word.Type,
                    currentNode.word.Meanings,
                    currentNode.word.Examples
                );
                
                newBuckets.AddLast(newWord, newBucketIndex);
            }
            capacity = newCapacity;
            buckets = newBuckets;
        }
    }

    public void Add(Word word, int index)
    {
        ResizeIfNeeded();
        int bucketIndex = HashFunction(word.Name);

        if (buckets.GetNodeByIndex(index) == null)
        {
            buckets.AddLast(word, index);
            count++;
        } else {
            Console.WriteLine("Word is existing");
        }
    }

    public bool Remove(string key)
    {
        int bucketIndex = HashFunction(key);
        var node = buckets.GetNodeByIndex(bucketIndex);

        if (node != null)
        {
            count = count - 1;
            return buckets.Remove(bucketIndex);
        }
        return false;
    }

    public Word? Get(string key)
    {
        int bucketIndex = HashFunction(key);
        var bucket = buckets.GetNodeByIndex(bucketIndex);

        if (bucket == null) return null;
        return bucket.word;
    }
    public string[] GetAllWord(int count)
    {
       return buckets.GetAll(count);
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            Node? currentNode = this.buckets.head;
            while(currentNode != null)
            {
                writer.WriteLine(currentNode.word.Name);
                writer.WriteLine(currentNode.word.Type);
                writer.WriteLine(string.Join(",", currentNode.word.Meanings));
                WordExample? currentExample = currentNode.word.Examples;
                string examples = currentExample == null ? "" : currentExample.data;
                currentExample = currentExample?.next;
                while (currentExample != null)
                {
                    examples = examples + "," + currentExample.data;
                    currentExample = currentExample.next;
                }
                writer.WriteLine(examples);
                currentNode = currentNode.next;
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        using (StreamReader reader = new StreamReader(fileName))
        {
            while (!reader.EndOfStream)
            {
                string name = reader.ReadLine()!;
                string type = reader.ReadLine()!;
                string definitions = reader.ReadLine()!;
                string examples = reader.ReadLine()!;
                WordExample we = new WordExample(examples.Split(","));

                Word word = new Word(name, type, definitions.Split(','), we);
                int bucketIndex = HashFunction(name);
                this.Add(word, bucketIndex);
            }
        }
    }
    public Node? GetNodeByIndex(int index)
    {
        Node? currentNode = this.buckets.head;

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

}
