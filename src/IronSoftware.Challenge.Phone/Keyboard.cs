namespace IronSoftware.Challenge.Phone
{
    public static class Keyboard
    {
        public static string OldPhonePad(string input)
        {
            // Check to see if the input ends with the designated closing character
            if (!input.EndsWith('#')) return "?";

            // Uppercase the input to make it easier to compare
            input = input.ToUpper();

            // Split the input into distinct groups of characters
            List<string> distinctCharacters = [];
            string currentNumberString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                // If the current character is the same as the previous character, add it to the current number string
                if (currentNumberString.Length == 0 || input[i] == currentNumberString[0])
                {
                    currentNumberString += input[i];
                }
                else
                {
                    // If the current character is different from the previous character and is a value, add the
                    // current number string to the list of distinct characters
                    if (!string.IsNullOrWhiteSpace(currentNumberString))
                        distinctCharacters.Add(currentNumberString);

                    // Load the next character
                    currentNumberString = input[i].ToString();
                }
            }

            // Beging building the string to return
            string returnString = string.Empty;

            // Loop through the distinct characters and convert them to the appropriate letter
            foreach (string inputGroup in distinctCharacters)
            {
                switch (inputGroup)
                {
                    case "2":
                        returnString += "A";
                        break;
                    case "22":
                        returnString += "B";
                        break;
                    case "222":
                        returnString += "C";
                        break;
                    case "3":
                        returnString += "D";
                        break;
                    case "33":
                        returnString += "E";
                        break;
                    case "333":
                        returnString += "F";
                        break;
                    case "4":
                        returnString += "G";
                        break;
                    case "44":
                        returnString += "H";
                        break;
                    case "444":
                        returnString += "I";
                        break;
                    case "5":
                        returnString += "J";
                        break;
                    case "55":
                        returnString += "K";
                        break;
                    case "555":
                        returnString += "L";
                        break;
                    case "6":
                        returnString += "M";
                        break;
                    case "66":
                        returnString += "N";
                        break;
                    case "666":
                        returnString += "O";
                        break;
                    case "7":
                        returnString += "P";
                        break;
                    case "77":
                        returnString += "Q";
                        break;
                    case "777":
                        returnString += "R";
                        break;
                    case "7777":
                        returnString += "S";
                        break;
                    case "8":
                        returnString += "T";
                        break;
                    case "88":
                        returnString += "U";
                        break;
                    case "888":
                        returnString += "V";
                        break;
                    case "9":
                        returnString += "W";
                        break;
                    case "99":
                        returnString += "X";
                        break;
                    case "999":
                        returnString += "Y";
                        break;
                    case "9999":
                        returnString += "Z";
                        break;
                    case "0":
                        returnString += " ";
                        break;
                    case "*":
                        returnString = returnString[..^1];
                        break;
                    case "#":
                        break;
                    default:
                        return "?";
                }
            }

            // Return the final string
            return returnString;
        }
    }
}
