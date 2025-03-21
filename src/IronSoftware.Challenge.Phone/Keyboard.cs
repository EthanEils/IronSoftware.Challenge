namespace IronSoftware.Challenge.Phone
{
    public static class Keyboard
    {
        public static string OldPhonePad(string input)
        {
            if (!input.EndsWith('#')) return "?";

            input = input.ToUpper();

            List<string> distinctCharacters = [];
            string currentNumberString = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (currentNumberString.Length == 0 || input[i] == currentNumberString[0])
                {
                    currentNumberString += input[i];
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(currentNumberString))
                        distinctCharacters.Add(currentNumberString);
                    currentNumberString = input[i].ToString();
                }
            }

            string returnString = string.Empty;
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

            return returnString;
        }
    }
}
