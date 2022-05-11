using ControlFlow;
using MainApplication.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication
{
    public class ChooseExercises
    {
        public void ChooseExercise(string area, int numberOfExercises)
        {
            var clExercises = new ControlFlowExercises();
            var alExercises = new ArraysListsExercises();
            var textExercises = new TextExercises();
            var fileExercises = new FileExercises();

            Console.WriteLine("Choose the exercise that needs to be tested:");
            for (int i = 1; i <= numberOfExercises; i++)
            {
                Console.WriteLine($"Exercise {i}");
            }
            Console.Write("-> ");
            var exercise = Console.ReadLine().Trim();
            Console.WriteLine();
            var exerciseNumber = int.Parse(exercise);

            switch (area)
            {
                case "1":
                    clExercises.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                case "2":
                    alExercises.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                case "3":
                    textExercises.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
                case "4":
                    fileExercises.ExecuteExercise($"Exercise{exerciseNumber}");
                    break;
            }
        }
    }
}
