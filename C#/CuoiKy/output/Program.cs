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
                    Console.WriteLine("Add a new word:");
                    string key = Console.ReadLine()!;
                    
                    Word? word = dictionary.Get(key);
                    if (word != null)
                    {
                        Console.WriteLine("Word existed");
                    } else {
                            Console.WriteLine("Type (Choose One):");
                            OptionType();
                            string ctype = Console.ReadLine()!;
                            string type;                            
                           
                            switch (ctype)
                            {
                                case "1": type = "Noun (Danh Từ)"; break;
                                case "2": type = "Pronoun (Đại Từ)"; break;
                                case "3": type = "Adjective (Tính Từ)"; break;
                                case "4": type = "Verb (Động Từ)"; break;
                                case "5": type = "Determine (Từ Hạn Định)"; break;
                                case "6": type = "Preposition (Giới Từ)"; break;
                                case "7": type = "Conjunction (Liên Từ)"; break;
                                case "8": type = "Interjection (Thán Từ)"; break;
                                default: continue;
                            }
                            Console.WriteLine("Meanings:");
                            string mean1 = Console.ReadLine()!;
              
                            Console.WriteLine("Examples:");
                            string exp1 = Console.ReadLine()!;
                       
                      
                        string newName = key;
                        string newType = type;
                        string[] newExamples = {exp1};
                        string[] newMeanings = {mean1};
                        Word newWord = new Word(newName, newType, newMeanings, new WordExample(newExamples));
                        dictionary.Add(newWord, dictionary.HashFunction(newName));
                        dictionary.SaveToFile("data.txt");
                        
                             
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
                                dictionary.SaveToFile("data.txt");
                                Console.WriteLine("Removed");
                        } 
                    }
                    break;
                }
                case "5": 
                {
                    OptionFunct();
                    string opfunct = Console.ReadLine()!;
                    Console.WriteLine("Word?: ");
                    string key = Console.ReadLine()!;
                    Word? word = dictionary.Get(key);
                    if (word == null)
                    {
                        Console.WriteLine("Not Found");
                    } else {
                            switch (opfunct)
                            {
                                case "1":
                                    Console.WriteLine("The example: ");
                                    string example = Console.ReadLine()!;
                                    word.AddExample(example);
                                    dictionary.SaveToFile("data.txt");
                                    break;

                            }
                        
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
        Console.WriteLine("==============================================");
    }
    static void OptionType()
    {
        Console.WriteLine("============================");
        Console.WriteLine("1.Noun (Danh Từ)");
        Console.WriteLine("2.Pronoun (Đại Từ)");
        Console.WriteLine("3.Adjective (Tính Từ)");
        Console.WriteLine("4.Verb (Động Từ)");
        Console.WriteLine("5.Determine (Từ Hạn Định)");
        Console.WriteLine("6.Preposition (Giới Từ)");
        Console.WriteLine("7.Conjunction (Liên Từ)");
        Console.WriteLine("8.Interjection (Thán Từ)");
        Console.WriteLine("============================");
    }
    static void OptionFunct()
    {
        Console.WriteLine("============================");
        Console.WriteLine("Choose a Modify: ");
        Console.WriteLine("1.Add Meanings");
        Console.WriteLine("2.Remove Meanings");
        Console.WriteLine("3.Add Examples");
        Console.WriteLine("4.Remove Examples");
        Console.WriteLine("============================");
    }

}

