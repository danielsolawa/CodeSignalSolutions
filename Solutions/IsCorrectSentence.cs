namespace CodeSignalSolutions.Solutions
{
    public class IsCorrectSentence
    {
        bool isCorrectSentence(string inputString)
        {
            return char.IsUpper(inputString[0]) && inputString[inputString.Length - 1] == '.';
        }
    }
}