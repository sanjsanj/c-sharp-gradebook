using System;
using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();

            try
            {
                Console.WriteLine("Enter a gradebook name");
                book.Name = Console.ReadLine();
            }

            catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Name", book.Name);
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult(stats.Description, stats.LetterGrade);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}");
        }
    }
}
