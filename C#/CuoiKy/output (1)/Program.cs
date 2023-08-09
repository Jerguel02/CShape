using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program {
    static void Main(string[] args)
    {
        Dictionary dictionary = new Dictionary(100);
        Console.WriteLine("loading program....");
        dictionary.LoadFromFile("data.txt");
        dictionary.GetAllWord(dictionary.GetSize());
        while(true)
        {
            Program.Menu();
            string c = Console.ReadLine()!;
            switch (c)
            {
                case "1": 
                {
                    string[] allwords = dictionary.GetAllWord(dictionary.GetSize());
                    foreach (var item in allwords)
                    {
                        Console.WriteLine("- " + item);
                    }
                    break;
                };
                case "2": 
                {
                    Console.WriteLine("Nhap vao 1 tu");
                    string key = Console.ReadLine()!;

                    Word? word = dictionary.Get(key);
                    if (word != null)
                    {
                        Console.WriteLine("Word existed");
                    } else {
                        string newName = "new Name";
                        string newType = "new Type";
                        string[] newExamples = { "string", "string2" };
                        string[] newMeanings = { "string", "string2" };
                        Word newWord = new Word(newName, newType, newMeanings, new WordExample(newExamples););
                        dictionary.Add(newWord, dictionary.HashFunction(newName));
                        Console.WriteLine("Add success");
                    }
                    break;
                }
                case "3": 
                {
                    Console.WriteLine("Please enter a word");
                    string word = Console.ReadLine()!;
                    Word? result = dictionary.Get(word);
                    if (result != null) {
                        result.Display();
                    } else {
                        Console.WriteLine("Not Found");
                    }
                    break;
                }
                case "4": 
                {
                    Console.WriteLine("Please enter a word to remove");
                    string word = Console.ReadLine()!;
                    Word? result = dictionary.Get(word);
                    if (result == null) {
                        Console.WriteLine("Not Found");
                        break;
                    } 
                    else
                    {
                        if (dictionary.Remove(result.Name))
                        {
                            Console.WriteLine("Removed");
                        } 
                    }
                    break;
                }
                case "5": 
                {
                    Console.WriteLine("Nhap vao 1 tu");
                    string key = Console.ReadLine()!;

                    Word? word = dictionary.Get(key);
                    if (word == null)
                    {
                        Console.WriteLine("Not Found");
                    } else {
                        string newName = "new Name";
                        string newType = "new Type";
                        word.Name = newName;
                        word.Type = newType;
                        string[] newExamples = { "string", "string2" };
                        string[] newMeanings = { "string", "string2" };
                        word.Examples = new WordExample(newExamples);
                        word.Meanings = newMeanings;
                    }
                    break;
                }
                case "6": 
                {
                    Console.WriteLine("GoodBye!!!");
                    return;
                }
                default: continue;
            }
        }
        
        
    }

    public static void Menu() {
        Console.WriteLine("==============================================");
        Console.WriteLine("Please enter 1 -> 6 to choice a function:");
        Console.WriteLine("1. List all words");
        Console.WriteLine("2. Add new word");
        Console.WriteLine("3. Lookup");
        Console.WriteLine("4. Remove");
        Console.WriteLine("5. Modify word");
        Console.WriteLine("6. Exit");
    }

}

