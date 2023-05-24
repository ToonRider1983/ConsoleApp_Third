using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Third {
    internal class Program {
        static void Main(string[] args)
        {
            int quantityOfStudent = 1, studentCounter = 1;
            int[] midScore, finalScore, sumScore;
            string[] studentName;

            // Firstly, The program ask the user about student quantity.
            Console.Write("How much student? : ");
            quantityOfStudent = int.Parse( Console.ReadLine() );

            // Secondly, re-allocating array sizing.
            studentName = new string[quantityOfStudent];
            midScore = new int[quantityOfStudent];
            finalScore = new int[quantityOfStudent];
            sumScore = new int[quantityOfStudent];

            // Thirdly, The user feild each student information.
            Console.WriteLine(":: Student Information ::");
            for (int iterator = 0; iterator < quantityOfStudent; iterator++)
            {
                // User feild student name, middle and final score information.
                Console.Write($"\nPlease key student({studentCounter} of {quantityOfStudent}) name : ");
                studentName[iterator] = Console.ReadLine();

                Console.Write($"Please key {studentName[iterator]}'s middle score : ");
                midScore[iterator] = Convert.ToInt32( Console.ReadLine() );

                Console.Write($"Please key {studentName[iterator]}'s final score : ");
                finalScore[iterator] = Convert.ToInt32(Console.ReadLine());

                // Score summation 
                sumScore[iterator] = midScore[iterator] + finalScore[iterator];

                // increment the counter variable values
                studentCounter++;
            }

            Console.WriteLine("\n:: Show score student's score and graded ::");
            int _iterator = 0;

            do
            {
                float _graded = 0.0f;

                if (sumScore[_iterator] <= 49)
                    _graded = 0;
                else if (sumScore[_iterator] <= 54)
                       _graded = 1;

                Console.WriteLine($"{studentName[_iterator]} have total score is {sumScore[_iterator]}");
                _iterator++;
            } while (_iterator < quantityOfStudent);


            Console.Write("\nPress any key enter....");
            Console.ReadLine();
        }
    }
}