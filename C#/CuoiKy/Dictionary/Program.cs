using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



// Lớp mô tả một từ trong từ điển
public class Word
{
    public string word;
    public string type;
    public List<string> meanings;
    public List<string> examples;

    public Word(string word, string type, List<string> meanings, List<string> examples)
    {
        this.word = word;
        this.type = type;
        this.meanings = meanings;
        this.examples = examples;
    }
}

// Lớp mô tả một node trong danh sách liên kết kép
public class Node
{
    public Word word;
    public Node next;
    public Node prev;

    public Node(Word word)
    {
        this.word = word;
        this.next = null;
        this.prev = null;
    }
}
public class HashTable
{
    private int size;
    private List<Node>[] table;

   public int GetSize()
    {
        return this.size;
    }
    public List<Node>[] GetTable()
    {
        return this.table;
    }
public HashTable(int size)
    {
        this.size = size;
        table = new List<Node>[size];
        for (int i = 0; i < size; i++)
        {
            table[i] = new List<Node>();
        }
    }

    // Hàm băm
    private int HashFunction(string word)
    {
        int hash = 0;
        for (int i = 0; i < word.Length; i++)
        {
            hash += (int)word[i];
        }
        return hash % size;
    }

    // Phương thức thêm từ vào bảng băm
    public void AddWord(Word word)
    {
        int index = HashFunction(word.word);
        Node newNode = new Node(word);
        table[index].Add(newNode);
    }

    // Phương thức tìm kiếm từ trong bảng băm
    public Node FindWord(string word)
    {
        int index = HashFunction(word);
        List<Node> nodes = table[index];
        foreach (Node node in nodes)
        {
            if (node.word.word == word)
            {
                return node;
            }
        }
        return null;
    }

    // Phương thức xóa từ khỏi bảng băm
    public bool DeleteWord(string word)
    {
        int index = HashFunction(word);
        List<Node> nodes = table[index];
        foreach (Node node in nodes)
        {
            if (node.word.word == word)
            {
                nodes.Remove(node);
                return true;
            }
        }
        return false;
    }
}

// Lớp mô tả từ điển
public class Dictionary
{
    private HashTable hashTable;
    private static readonly IEnumerable<Word> linkedList;

    public Dictionary(int size)
    {
        hashTable = new HashTable(size);
    }

    // Phương thức thêm từ vào từ điển
    public void AddWord(string word, string type, List<string> meanings, List<string> examples)
    {
        Word newWord = new Word(word, type, meanings, examples);
        hashTable.AddWord(newWord);
    }

    // Phương thức tìm kiếm từ trong từ điển
    public Word FindWord(string word)
    {
        Node node = hashTable.FindWord(word);
        if (node == null)
        {
            return null;
        }
        else
        {
            return node.word;
        }
    }

    // Phương thức hiệu chỉnh từ trong từ điển
    public bool EditWord(string word, string type, List<string> meanings, List<string> examples)
    {
        Node node = hashTable.FindWord(word);
        if (node == null)
        {
            return false;
        }
        else
        {
            node.word.type = type;
            node.word.meanings = meanings;
            node.word.examples = examples;
            return true;
        }
    }

    // Phương thức xóa từ khỏi từ điển
    public bool DeleteWord(string word)
    {
        Node node = hashTable.FindWord(word);
        if (node == null)
        {
            return false;
        }
        else
        {
            node.prev.next = node.next;
            node.next.prev = node.prev;
            return true;
        }
    }

    // Phương thức lưu danh sách từ vào file
    public void SaveToFile(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            for (int i = 0; i < this.hashTable.GetSize(); i++)
                
            {
                List<Node> nodes = hashTable.GetTable()[i];
                foreach (Node node in nodes)
                {
                    writer.WriteLine(node.word.word);
                    writer.WriteLine(node.word.type);
                    foreach (string meaning in node.word.meanings)
                    {
                        writer.WriteLine(meaning);
                    }
                    foreach (string example in node.word.examples)
                    {
                        writer.WriteLine(example);
                    }
                }
            }
        }
    }

    // Phương thức load danh sách từ từ file
    public void LoadFromFile(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            string word = "";
            string type = "";
            List<string> meanings = new List<string>();
            List<string> examples = new List<string>();

            while ((line = reader.ReadLine()) != null)
            {
                switch (line)
                {
                    case "Word:":
                        word = reader.ReadLine();
                        break;
                    case "Type:":
                        type = reader.ReadLine();
                        break;
                    case "Meaning:":
                        meanings.Add(reader.ReadLine());
                        break;
                    case "Example:":
                        examples.Add(reader.ReadLine());
                        break;
                    case "":
                        AddWord(word, type, meanings, examples);
                        word = "";
                        type = "";
                        meanings.Clear();
                        examples.Clear();
                        break;
                }
            }
            }
        }

    static void Main()
    {
        foreach (Word word in linkedList)
        {
            Console.WriteLine("Từ: " + word.word);
            Console.WriteLine("Loại từ: " + word.type);
            Console.WriteLine("Nghĩa của từ: ");
            foreach (string definition in word.meanings)
            {
                Console.WriteLine("- " + definition);
            }
            Console.WriteLine("Ví dụ:");
            foreach (string example in word.examples)
            {
                Console.WriteLine("- " + example);
            }
            Console.WriteLine();
        }
    }
}

