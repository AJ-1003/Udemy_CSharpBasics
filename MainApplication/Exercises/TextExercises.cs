using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Text;

namespace MainApplication.Exercises
{
    public class TextExercises
    {
        public void ExecuteExercise(string exerciseName)
        {
            if (GetType().GetMethod(exerciseName) != null)
            {
                MethodInfo method = GetType().GetMethod(exerciseName);
                method.Invoke(this, null);
            }
        }

        public void Exercise1()
        {
            /*
             Write a program and ask the user to enter a few numbers separated by a hyphen.
             Work out if the numbers are consecutive.
             For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".
            */
            var numbers = new ConsecutiveNumbers();
            string userInput;
            Console.WriteLine("Enter a list a numbers seperated by a hyphen(-) or 'Quit' to exit.");
            do
            {
                Console.Write("-> ");
                userInput = Console.ReadLine();
                if (userInput.ToLower() != "quit")
                {
                    Console.WriteLine(numbers.CheckConsecutiveNumbers(userInput.Trim(new char[] { ' ', ',', '-' })));
                }

            } while (userInput.ToLower() != "quit");
        }

        public void Exercise2()
        {
            /*
             Write a program and ask the user to enter a few numbers separated by a hyphen.
             If the user simply presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.
             If so, display "Duplicate" on the console. 
            */

            var numbers = new CheckDuplicates();
            string userInput;
            Console.WriteLine("Enter a list a numbers seperated by a hyphen(-) or 'Quit' to exit.");
            do
            {
                Console.Write("-> ");
                userInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower() != "quit")
                {
                    var containsDuplicates = numbers.CheckForDuplicateNumbers(userInput.Trim(new char[] { ' ', ',', '-' }));
                    if (containsDuplicates)
                    {
                        Console.WriteLine("There are duplicates in the list.");
                    }
                    else
                    {
                        Console.WriteLine("You entered a list with no duplicate values.");
                    }
                }

            } while (!string.IsNullOrWhiteSpace(userInput) && userInput.ToLower() != "quit");
        }

        public void Exercise3()
        {
            /*
             Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00).
             A valid time should be between 00:00 and 23:59.
             If the time is valid, display "Ok"; otherwise, display "Invalid Time".
             If the user doesn't provide any values, consider it as invalid time. 
            */

            var time = new CheckTime();
            string userInput;
            Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 15:45) or 'Quit' to exit.");
            do
            {
                Console.Write("-> ");
                userInput = Console.ReadLine();
                if (userInput.ToLower() != "quit")
                {
                    var validTime = time.CheckTimeEntry(userInput);
                    if (validTime)
                    {
                        // check for AM and PM
                        Console.WriteLine($"Valid time entry: {DateTime.Parse(userInput).ToString("hh:mm")}.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry!");
                    }
                }
            } while (userInput.ToLower() != "quit");
        }

        public void Exercise4()
        {
            /*
             Write a program and ask the user to enter a few words separated by a space.
             Use the words to create a variable name with PascalCase.
             For example, if the user types: "number of students", display "NumberOfStudents".
             Make sure that the program is not dependent on the input.
             So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents". 
            */

            var words = new ConvertStringToPascalCase();
            string userInput;
            Console.WriteLine("Enter a few words to be converted or 'Quit' to exit.");
            do
            {
                Console.Write("-> ");
                userInput = Console.ReadLine().ToLower();
                if (userInput.ToLower() != "quit")
                {
                    Console.WriteLine(words.ConvertString(userInput));
                }
            } while (userInput.ToLower() != "quit");
        }

        public void Exercise5()
        {
            /*
             Write a program and ask the user to enter an English word.
             Count the number of vowels (a, e, o, u, i) in the word.
             So, if the user enters "inadequate", the program should display 6 on the console. 
            */

            var word = new CountVowels();
            string userInput;
            Console.WriteLine("Enter an English word or 'Quit' to exit.");
            do
            {
                Console.Write("-> ");
                userInput = Console.ReadLine().ToLower();
                if (userInput.ToLower() != "quit")
                {
                    Console.WriteLine(word.CountNumberOfVowels(userInput));
                }
            } while (userInput.ToLower() != "quit");
        }
    }
}
