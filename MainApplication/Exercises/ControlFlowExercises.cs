using ControlFlow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Exercises
{
    public class ControlFlowExercises
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
            Write a program and ask the user to enter a number.
            The number should be between 1 to 10. 
            If the user enters a valid number, display "Valid" on the console. 
            Otherwise, display "Invalid". 
            (This logic is used a lot in applications where values entered into input boxes need to be validated.)
            */

            var validate = new ValidateUserInput();
            Console.WriteLine("Please enter a number between 1 and 10:");
            Console.Write("-> ");
            var input = Console.ReadLine();
            Console.WriteLine(validate.ValidateInput(input));
        }

        public void Exercise2()
        {
            /*
            Write a program which takes two numbers from the console and displays the maximum of the two.
            */

            var maxNum = new DisplayMaxNumber();
            Console.WriteLine("Please enter two numbers:");
            Console.Write("1st number -> ");
            var num1 = double.Parse(Console.ReadLine());
            Console.Write("2nd number -> ");
            var num2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"The maximum of the two is: {maxNum.MaxNumber(num1, num2)}");
        }

        public void Exercise3()
        {
            /*
            Write a program and ask the user to enter the width and height of an image. 
            Then tell if the image is landscape or portrait.
            */

            var orientation = new DetermineImageOrientation();
            Console.WriteLine("Please enter the width and height of an image in pixels to determine the orientation:");
            Console.Write("Width -> ");
            var width = double.Parse(Console.ReadLine());
            Console.Write("Height -> ");
            var height = double.Parse(Console.ReadLine());
            Console.WriteLine($"The image's orientation is: {orientation.Orientation(width, height)}");
        }

        public void Exercise4()
        {
            /*
            Your job is to write a program for a speed camera.
            For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
            Write a program that asks the user to enter the speed limit.
            Once set, the program asks for the speed of a car.
            If the user enters a value less than the speed limit, the program should display Ok on the console.
            If the value is above the speed limit, the program should calculate the number of demerit points.
            For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
            If the number of demerit points is above 12, the program should display License Suspended.
            */

            var demeritPoints = new CalculateDemeritPoints();
            Console.WriteLine("Enter the current road's speed limit and the speed of the passing car:");
            Console.Write("Speed limit -> ");
            var speedLimit = double.Parse(Console.ReadLine());
            Console.Write("Speed of car -> ");
            var carSpeed = double.Parse(Console.ReadLine());
            Console.WriteLine(demeritPoints.DemeritPoints(speedLimit, carSpeed));
        }

        public void Exercise5()
        {
            /*
            Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
            Display the count on the console.
            */

            var calculateRemainderCount = new NoRemainderCalculator();
            var result = calculateRemainderCount.CalculateRemainderCount();
            Console.WriteLine($"There are {result} numbers between 1 and 100 with no remainder when divided by 3.");
        }

        public void Exercise6()
        {
            /*
            Write a program and continuously ask the user to enter a number or "ok" to exit.
            Calculate the sum of all the previously entered numbers and display it on the console.
            */

            var sumNumbers = new SumUserNumbers();
            var numbers = new List<double>();
            Console.WriteLine("Please enter a number you would like to add up or 'ok' to exit.");
            double number;
            string userInput;

            do
            {
                Console.Write("-> ");
                userInput = Console.ReadLine();
                if (double.TryParse(userInput, out number))
                {
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Please enter a valid number or 'ok' to exit.");
                }
            }
            while (userInput.ToLower() != "ok");
            Console.WriteLine($"The sum of all values entered is {sumNumbers.CalculateUserNumberInput(numbers)}.");
        }

        public void Exercise7()
        {
            /*
            Write a program and ask the user to enter a number.
            Compute the factorial of the number and print it on the console.
            For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
            */

            var factorial = new CalculaterFactorial();
            Console.WriteLine("Enter a whole number to calculate it's factorial");
            Console.Write("-> ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"The factorial is {factorial.CalcFactorial(number)}");
        }

        public void Exercise8()
        {
            /*
            Write a program that picks a random number between 1 and 10.
            Give the user 4 chances to guess the number.
            If the user guesses the number, display “You won"; otherwise, display “You lost".
            (To make sure the program is behaving correctly, you can display the secret number on the console first.)
            */

            var randomNumber = new RandomNumberGenerator();
            int chances = 4;
            Console.WriteLine($"Guess the hidden number. You have {chances} chances.");
            var guessNumber = randomNumber.GenerateNumber();
            //Console.WriteLine(guessNumber);
            int number;
            for (var i = chances; i > 0; i--)
            {
                Console.Write("-> ");
                number = int.Parse(Console.ReadLine());
                if (number == guessNumber)
                {
                    Console.WriteLine("You won!!!");
                    break;
                }
                else if (number != guessNumber && i > 1)
                {
                    Console.WriteLine("Guess again...");
                }
                else
                {
                    Console.WriteLine("You lost...");
                }
            }
        }

        public void Exercise9()
        {
            /*
            Write a program and ask the user to enter a series of numbers separated by comma.
            Find the maximum of the numbers and display it on the console.
            For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
            */

            var getMaxValue = new GetMaxNumberInSeries();
            Console.WriteLine("Enter a series of whole numbers separated by a ',' (comma) to get the max value from and enter 'ok' when done.");
            Console.Write("-> ");
            var input = Console.ReadLine().Trim();
            List<int> numbers = new List<int>();
            string[] stringNumbers = input.Split(',');
            int number;

            for (var i = 0; i < stringNumbers.Length; i++)
            {
                number = int.Parse(stringNumbers[i]);
                numbers.Add(number);
            }

            // -----< List method >-----
            //Console.WriteLine("Enter a series of whole numbers to get the max value from and enter 'ok' when done.");
            //var numbers = new List<int>();
            //do
            //{
            //    Console.Write("-> ");
            //    input = Console.ReadLine();
            //    if (input.ToLower() != "ok")
            //    {
            //        numbers.Add(int.Parse(input));
            //    }
            //}
            //while (input != "ok");

            var maxValue = getMaxValue.MaxNumber(numbers);
            Console.WriteLine($"The maximum value from the numbers entered is {maxValue}.");
        }
    }
}
