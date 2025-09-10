// HW1b Grade

// Your Name: Sophia Solorzano
// Did you seek help ? If yes, specify the helper or web link here: 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1b_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt for student info
            Console.WriteLine("What is your first name?");
            string firstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastName = Console.ReadLine();

            Console.WriteLine("What is your student id?");
            string studentId = Console.ReadLine();

            // Prompt for grades
            Console.WriteLine("What is your overall percentage grade for assignmentss?");
            double assignments = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for participations?");
            double participation = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade examone?");
            double examone = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for examtwo?");
            double examtwo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your overall percentage grade for examthree?");
            double examthree = Convert.ToDouble(Console.ReadLine());

            // Weighting from syllabus
            double finalGrade = (assignments * 0.20) +
                                (participation * 0.15) +
                                (examone * 0.15) +
                                (examtwo * 0.25) +
                                (examthree * 0.25);

            // Output result
            Console.WriteLine($"{firstName} {lastName} ({studentId}), your final grade is {finalGrade:F2}%");

            Console.ReadKey();
        }
    }
}
