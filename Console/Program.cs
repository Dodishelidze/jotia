using System;
using System.Collections.Generic;

namespace Jotia
{
    class Program
    {
        static void Main(string[] args)
        {
            var commad = Console.ReadLine();
            var notes = new List<Note> {
                new Note("today's tasks"),
                new Note("coding ideas"),
            };

            while (commad != "exit")
            {
                //logic
                if (commad == "list")
                {
                    // display all notes
                    foreach (var note in notes)
                    {
                       Console.WriteLine($"- {note.GetTitle()}");
                    }
                }

                commad = Console.ReadLine();
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
