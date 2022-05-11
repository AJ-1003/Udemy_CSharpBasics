namespace ControlFlow
{
    public class ValidateUserInput
    {
        public string ValidateInput(string userInput)
        {
            var minValue = 1;
            var maxValue = 10;
            string validation = "";

            try
            {
                var number = int.Parse(userInput);
                if (number >= minValue && number <= maxValue)
                {
                    //Console.WriteLine("Valid");
                    validation = "Valid";
                }
                else
                {
                    //Console.WriteLine("Invalid");
                    validation = "Invalid";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Please enter a valid number. \"Error message: {ex.Message}\"");
            }
            return validation;
        }
    }
}