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
        dictionary.LoadFromFile("D:/Cpp/C-C++/CuoiKy/Dotnet/Dotnet/data.txt");
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
                        Console.WriteLine("Please Enter a new Word:");
                        string word = Console.ReadLine()!;
                        Word? result = dictionary.Add(word, 10);
                        Console.WriteLine("Added");
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

