namespace Text
{
    public class ConsecutiveNumbers
    {
        public string CheckConsecutiveNumbers(string numbers)
        {
            string consecutiveCheck;
            var checkNumbersString = numbers.Split('-');
            var firstValue = Convert.ToDouble(checkNumbersString[0]);
            var consecutive = false;

            for (var i = 0; i < checkNumbersString.Length; i++)
            {
                if (Convert.ToDouble(checkNumbersString[i]) - 1 == firstValue)
                {
                    consecutive = true;
                    break;
                }
                else if (Convert.ToDouble(checkNumbersString[i]) + 1 == firstValue)
                {
                    consecutive = true;
                    break;
                }
                else
                {
                    consecutive = false;
                }
            }

            if (consecutive)
            {
                consecutiveCheck = "Consecutive";
            }
            else
            {
                consecutiveCheck = "Not Consecutive";
            }

            return consecutiveCheck;
        }
    }
}