using System.Xml.Linq;
using static Dict.Form1;

namespace Dict
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtWord.ForeColor = Color.Gray; // màu chữ mờ
            txtWord.Text = "Type a Word"; // chuỗi chữ mờ
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
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
                for (int i = 1; i < data.Count(); i++)
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

            public void AddExample(string data)
            {
                if (this.Examples == null)
                {
                    this.Examples = new WordExample(data);
                }
                else
                {
                    WordExample t = new WordExample(data);
                    WordExample p = this.Examples;
                    while (p.next != null)
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

            public void AddMean(string mean)
            {
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
            public void RemoveMean(string mean)
            {
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
                    while (currentNode != null)
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
                }
                else
                {
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
                    while (currentNode != null)
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
        public class DoublyLinkedList
        {
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
                while (current != null)
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

        private void Form1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWord_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtWord.Text))
            {
                txtWord.ForeColor = Color.Gray; // màu chữ mờ
                txtWord.Text = "Type a Word"; // chuỗi chữ mờ
            }
            else
            {
                txtWord.ForeColor = Color.Black; // màu chữ thường
            }
        }
    }
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
                while (currentNode != null)
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
            }
            else
            {
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
                while (currentNode != null)
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
}

