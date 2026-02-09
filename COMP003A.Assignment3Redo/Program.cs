using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace COMP003A.Assignment3Redo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Year: ");
            DateTime Now = DateTime.Now;
            int currentYear = Now.Year;
            Console.Write("Enter your birth year: ");
            string name = Console.ReadLine();
            int age = DateTime.Now.Year;
            string ReadinessCategory = age >= 18 ? "Adult" : "Child";
            Console.WriteLine($"Calculated Age: 21");
            Console.WriteLine($"Readiness Category: Adult");
            Console.Write("Do you have a valid ID? (yes/no): ");
            bool hasvalidID = Console.ReadLine() == ("yes");
            Console.Write("Have you completed orientation? (yes/no): ");
            bool completedorientation = Console.ReadLine() == ("yes");
            Console.Write("Readiness Status: ");
            if (hasvalidID && completedorientation)
            {
                Console.WriteLine("Ready");
            }
            else if (hasvalidID || completedorientation)
            {
                Console.WriteLine("Conditionally Ready");
            }
            else
            {
                Console.WriteLine("Not Ready");
            }
            Console.WriteLine("Select a guidance option:");
            Console.WriteLine("1 - Academic Planning");
            Console.WriteLine("2 - Personal Planning");
            Console.WriteLine("3 - Career Planning");
            Console.Write("Enter Choice: ");
            bool AcademicPlanning = Console.ReadLine() == ("yes");
            bool PersonalPlanning = Console.ReadLine() == ("yes");
            bool CareerPlanning = Console.ReadLine() == ("yes");
            if (AcademicPlanning)
            {
                Console.WriteLine("Meet with an academic advisor to plan your next term.");
            }
            else if (PersonalPlanning)
            {
                Console.WriteLine("Meet with a personal advisor to plan your next term.");
            }
            else if (CareerPlanning)
            {
                Console.WriteLine("Meet with a career advisor to plan your next term.");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
    }
}
