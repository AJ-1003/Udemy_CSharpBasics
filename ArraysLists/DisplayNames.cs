namespace ArraysLists
{
    public class DisplayNames
    {
        public string DisplayName(List<string> names)
        {
            string namesEntered;
            if (names.Count == 1)
            {
                namesEntered = $"{names.First()}";
            }
            else if (names.Count == 2)
            {
                namesEntered = $"{names.First()}, {names.ElementAt(1)}";
            }
            else if (names.Count > 2)
            {
                namesEntered = $"{names.First()}, {names.ElementAt(1)}, +{names.Count - 2} others";
            }
            else
            {
                namesEntered = "No names were entered.";
            }
            return namesEntered;
        }
    }
}