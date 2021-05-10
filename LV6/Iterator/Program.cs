using Iterator.Note;
using System.Collections.Generic;

namespace LV6opet
{
    class Program
    {
        static void Main(string[] args)
        {
            RunNotesDemo();
        }

        private static void RunNotesDemo()
        {
            Notebook notebook = new Notebook();
            for (int i = 0; i < 3; i++)
                notebook.AddNote(new Note($"AAAAAAAAA{ i }", $"AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA{ i }"));

            IAbstractIterator iterator = notebook.GetIterator();
            for (var temp = iterator.First(); iterator.IsDone == false; iterator.Next())
                temp.Show();
        }
    }
}
