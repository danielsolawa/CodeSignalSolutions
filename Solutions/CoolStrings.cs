namespace CodeSignalSolutions.Solutions
{
    public class CoolStrings
    {
        bool coolString(string inputString)
        {
            for (var i = 0; i < inputString.Length; i++)
            {
                var current = inputString[i];
                if (!char.IsLetter(current))
                {
                    return false;
                }

                if (i > 0)
                {
                    var previous = inputString[i - 1];
                    if (char.IsLower(previous) && char.IsLower(current))
                    {
                        return false;
                    }

                    if (char.IsUpper(previous) && char.IsUpper(current))
                    {
                        return false;
                    }
                }
            }


            return true;
        }
    }
}