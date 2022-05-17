using ArraysLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Exercises
{
    public class ArraysListsExercises
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
             When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
             * If no one likes your post, it doesn't display anything.
             * If only one person likes your post, it displays: [Friend's Name] likes your post.
             * If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
             * If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
             Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). 
             Depending on the number of names provided, display a message based on the above pattern.
            */

            var inputNames = new DisplayNames();
            var names = new List<string>();
            string userInput;
            Console.WriteLine("Enter a couple of names or press 'Enter' to exit.");
            while (true)
            {
                Console.Write("-> ");
                userInput = Console.ReadLine();
                if (userInput == null || userInput == "")
                {
                    break;
                }
                else
                {
                    names.Add(userInput);
                }
            }
            if (names.Count < 1)
            {
                Console.WriteLine($"You have entered the following name: {inputNames.DisplayName(names)}");
            }
            else
            {
                Console.WriteLine($"You have entered the following names: {inputNames.DisplayName(names)}");
            }
        }

        public void Exercise2()
        {
            /*
             Write a program and ask the user to enter their name. 
             Use an array to reverse the name and then store the result in a new string. 
             Display the reversed name on the console.
            */

            var name = new ReverseName();
            string userInput;
            Console.WriteLine("Enter your name and watch the magic happen.");
            Console.Write("-> ");
            userInput = Console.ReadLine();
            Console.WriteLine($"Your name in reverse is '{name.ReverseNameInput(userInput)}'");
        }

        public void Exercise3()
        {
            /*
             Write a program and ask the user to enter 5 numbers.
             If a number has been previously entered, display an error message and ask the user to re-try.
             Once the user successfully enters 5 unique numbers, sort them and display the result on the console. 
            */

            var numbers = new SortUniqueNumbers();
            var uniqueNumbers = new int[5];
            string userInput;
            var validNumbers = 0;
            Console.WriteLine("Enter 5 numbers to get them sorted.");

            do
            {
                Console.Write("-> ");
                userInput = Console.ReadLine();

                var existsInArray = Array.Find(uniqueNumbers, x => x == int.Parse(userInput));

                if (int.Parse(userInput) == existsInArray)
                {
                    Console.WriteLine($"ERROR: You have already entered this number");
                }
                else
                {
                    uniqueNumbers[validNumbers] = int.Parse(userInput);
                    validNumbers++;
                }
                //Array.ForEach(uniqueNumbers, Console.WriteLine);
            }
            while (validNumbers < uniqueNumbers.Length);

            Array.ForEach(numbers.SortNumbers(uniqueNumbers), Console.WriteLine);
        }

        public void Exercise4()
        {
            /*
             Write a program and ask the user to continuously enter a number or type "Quit" to exit.
             The list of numbers may include duplicates.
             Display the unique numbers that the user has entered. 
            */

            var numbers = new DisplayUniqueNumbers();
            var inputNumbers = new List<double>();
            var userInput = "";
            var uniqueNumbers = "";
            Console.WriteLine("Please enter numbers to add to a list and receive all the unique ones or 'Quit' to exit.");
            while (userInput.ToLower() != "quit")
            {
                Console.Write("-> ");
                userInput = Console.ReadLine();
                try
                {
                    inputNumbers.Add(double.Parse(userInput));
                }
                catch
                {
                    if (userInput.ToLower() != "quit")
                        Console.WriteLine("Please enter a valid number or 'Quit' to exit.");
                }
            }

            foreach (var number in numbers.DisplayNumbers(inputNumbers))
            {
                uniqueNumbers += number.ToString() + ", ";
            }

            Console.WriteLine(uniqueNumbers);
        }

        public void Exercise5()
        {
            /*
             Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10).
             If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
             otherwise, display the 3 smallest numbers in the list. 
            */

            var numbers = new DisplaySmallestNumbers();
            var inputNumbers = new List<double>();
            var userInput = "";
            var validEntry = false;
            Console.WriteLine("Enter a list of more than five numbers seperated by a comma or 'Quit' to exit.");
            do
            {
                Console.Write("-> ");
                userInput = Console.ReadLine().Trim();
                var inputNumbersString = userInput.Split(',');
                if (inputNumbersString.Length >= 5)
                {
                    foreach (string number in inputNumbersString)
                    {
                        inputNumbers.Add(double.Parse(number));
                    }
                    validEntry = true;
                }
                else if (userInput.ToLower() == "quit")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid list, please try again.");
                }
            } while (!validEntry);
            var smallestNumbers = numbers.SmallestNumbers(inputNumbers);
            Array.ForEach(smallestNumbers, Console.WriteLine);
        }
    }
}
