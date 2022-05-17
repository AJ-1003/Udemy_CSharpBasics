using MainApplication;
using static System.Net.Mime.MediaTypeNames;

var exerciseChoice = new ChooseExercises();
string input;
int numberOfTests = 1;

do
{
    if (numberOfTests > 1)
    {
        Console.WriteLine();
    }
    Console.WriteLine($"Choose the area that needs to be tested or press 'Q' to exit: ({numberOfTests})");
    Console.WriteLine(
        "1: Control flow\n" +
        "2: Arrays and Lists\n" +
        "3: Working with Text\n" +
        "4: Working with Files");

    Console.Write("-> ");
    input = Console.ReadLine();

    if (input == "1" || input == "2" || input == "3" || input == "4")
    {
        switch (input)
        {
            case "1":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 9);
                break;
            case "2":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 5);
                break;
            case "3":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 5);
                break;
            case "4":
                Console.WriteLine();
                exerciseChoice.ChooseExercise(input, 2);
                break;
            default:
                break;
        }
        numberOfTests++;
    }
    else if (input != "q")
    {
        Console.WriteLine();
        Console.WriteLine("!!! NOTE: Please enter a valid option or press 'Q' to exit. !!!");
        Console.WriteLine();
    }
} while (input.ToLower() != "q" && numberOfTests <= 10);