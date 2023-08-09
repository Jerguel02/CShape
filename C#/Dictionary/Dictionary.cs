using System;
using System.Collections.Generic;
using System.IO;

// Khai báo class Word
class Word
{
    public string Name { get; set; }
    public string Type { get; set; }
    public List<string> Definitions { get; set; }
    public List<string> Examples { get; set; }
}

class Dictionary
{
    private Dictionary<string, Word> hashTable;
    private LinkedList<Word> linkedList;

    public Dictionary()
    {
        hashTable = new Dictionary<string, Word>(); // bảng băm
        linkedList = new LinkedList<Word>(); // danh sách liên kết kép
    }

    public void AddWord(Word word)
    {
        if (!hashTable.ContainsKey(word.Name))
        {
            linkedList.AddLast(word);
            hashTable[word.Name] = word;
        }
    }

    public void SaveToFile(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (Word word in linkedList)
            {
                writer.WriteLine(word.Name);
                writer.WriteLine(word.Type);
                writer.WriteLine(string.Join(",", word.Definitions));
                writer.WriteLine(string.Join(",", word.Examples));
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

                Word word = new Word()
                {
                    Name = name,
                    Type = type,
                    Definitions = new List<string>(definitions.Split(',')),
                    Examples = new List<string>(examples.Split(','))
                };

                AddWord(word);
            }
        }
    }

    public Word? FindWord(string name)
    {
        if (hashTable.ContainsKey(name))
        {
            return hashTable[name];
        }
        return null;
    }

    public void PrintAllWords() // hàm này chỉ dùng trên console
    {
        foreach (Word word in linkedList)
        {
            Console.WriteLine("Từ: " + word.Name);
            Console.WriteLine("Loại từ: " + word.Type);
            Console.WriteLine("Nghĩa của từ: ");
            foreach (string definition in word.Definitions)
            {
                Console.WriteLine("- " + definition);
            }
            Console.WriteLine("Ví dụ:");
            foreach (string example in word.Examples)
            {
                Console.WriteLine("- " + example);
            }
            Console.WriteLine();
        }
    }

    // Hiệu chỉnh từ
    public void ModifyWord(string name, string type, List<string> definitions, List<string> examples)
    {
        Word? word = FindWord(name);
        if (word != null)
        {
            word.Type = type;
            word.Definitions = definitions;
            word.Examples = examples;
        }
    }
}
