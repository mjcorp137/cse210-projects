using System;
using System.Data.SqlTypes;
using static System.Console;
using System.IO;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Entry();

    }
    static void Menu(){
        List<string> _menu = new List<string>{
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit"
        };
        for(int i=0; i<_menu.Count;i++){
            Console.WriteLine(_menu[i]);
        }
    }
    static string Prompt(){
        List<string> _prompts = new List<string>{
            "What important things have you learned from this day?",
            "What part of your workday do you most enjoy?",
            "What can you do to improve yourself today?",
            "What was the best thing that happened today?",
            "What did I do today that I am proud of?",
            "How am I feeling today?",
            "What are my top priorities for the day?"
        };
        Random _random = new Random();
        int _randomPrompt = _random.Next(_prompts.Count);
        string _newPrompt = _prompts[_randomPrompt];
        
        //Console.WriteLine(newPrompt);
        return _newPrompt;
    }
    static void LoadFile(){

    }
    static void SaveFile(string _userRespond){
        string _path = @"C:\Users\zimablue\Desktop\cse210-projects\prove\Develop02\SaveFile.txt";
        File.AppendAllText(_path, _userRespond);
    }
    static void Entry(){
        bool condition = true;
        while(condition){
            Menu();
            Console.Write("What would you like to do? ");
            int _selection = int.Parse(Console.ReadLine());
            
            switch(_selection){
                case 1://      Write
                    
                    // Getting the Journal Prompt and User Respond
                    string _randomPrompt = Prompt();
                    Console.WriteLine(_randomPrompt);
                    string _userRespond = Console.ReadLine();
                    
                    // Getting the Date
                    DateOnly _dateOnly = DateOnly.FromDateTime(DateTime.Now);

                    // Saving the prompt and user respond to a text file.
                    string _toBeSaved = $"{_dateOnly} Prompt: {_randomPrompt}\n{_userRespond}\n\n";

                    SaveFile(_toBeSaved);
                
                    break;
                case 2://      Display
                
                    string _filePath = @"C:\Users\zimablue\Desktop\cse210-projects\prove\Develop02\SaveFile.txt";
                    List<string> _lines = File.ReadAllLines(_filePath).ToList();

                    foreach (string line in _lines){
                        Console.WriteLine(line);
                    }
                    Console.ReadLine();
                    break;
                case 3://      Load
                    Console.WriteLine("What is the name of the file you want to Load?");
                    string _loadFile = Console.ReadLine();

                    Console.WriteLine(File.ReadAllText(_loadFile));

                    break;
                case 4://      Save
                    Console.WriteLine("What is the filename");
                    string _fileName = Console.ReadLine();
                    
                    string _originalFile = @"C:\Users\zimablue\Desktop\cse210-projects\prove\Develop02\SaveFile.txt";
                    string _newFile = $"{_fileName}";
                    
                    File.Copy(_originalFile, _newFile);

                    Console.WriteLine("File has been saved.!");

                    break;
                case 5://      Quit
                    condition = false;
                    break;
            }
            
        }
        
        
    }
}