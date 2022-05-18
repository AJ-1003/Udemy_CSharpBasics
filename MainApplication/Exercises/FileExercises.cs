using Files;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MainApplication.Exercises
{
    public class FileExercises
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
             Write a program that reads a text file and displays the number of words. 
            */

            var words = new DisplayNumberOfWords();
            var filePath = @"C:\Users\iajor\source\isometrix training repos\CSharpBasics\MainApplication\Files\ExerciseFile.txt";
            Console.WriteLine($"There are '{words.NumberOfWords(filePath)}' words in this file.");
        }

        public void Exercise2()
        {
            /*
             Write a program that reads a text file and displays the longest word in the file. 
            */

            var words = new DisplayLongestWord();
            var filePath = @"C:\Users\iajor\source\isometrix training repos\CSharpBasics\MainApplication\Files\ExerciseFile.txt";
            Console.WriteLine($"The longest word in the file is '{words.GetLongestWord(filePath)}'");
        }
    }
}
