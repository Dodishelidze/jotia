using System;
using System.Collections.Generic;
using System.Linq;

namespace Jotia
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var notes = new List<Note> {
                new Note("today's tasks"),
                new Note("coding ideas"),
            };

            while (command != "exit")
            {
                //logic
                if (command == "list")
                {
                    // display all notes
                    foreach (var note in notes)
                    {
                       Console.WriteLine($"- {note.GetTitle()}");
                    }
                }
                if (command == "clear")
                {
                    Console.Clear();
                }  
                if (command.StartsWith("search"))
                {
                    string[] words = command.Split(" ");
                    string word = words[1];
                    var S = notes.Where(n => n.GetTitle().Contains(word)).ToArray();
                    for (int i = 0; i < S.Length; i++)
                    {
                        Note n = (S[i]);
                        Console.WriteLine(n.GetTitle());
                    }
                }
                command = Console.ReadLine();
            }
        }

        
    }

    internal class Note
    {
        private string title;
        public Note(string title)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return title;
        }
    }
}
