using System;
using System.Diagnostics;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();
            journal.AddEntry("My first program");
            journal.AddEntry("My first bug");
            Console.WriteLine(journal);
            var persistence = new Persistence();
            var fileName = @"E:\myjournal.txt";
            persistence.SaveToFile(journal, fileName, true);
            Console.WriteLine($"file is save to {fileName}");
            Console.ReadLine();
        }
    }
}
