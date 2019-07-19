namespace CodeSignalSolutions.Solutions
{
    public class WhosMove
    {
        string whoseMove(string lastPlayer, bool win)
        {
            var otherPlayer = lastPlayer == "white" ? "black" : "white";
            return win ? lastPlayer : otherPlayer;
        }

    }
}