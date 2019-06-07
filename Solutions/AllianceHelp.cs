namespace CodeSignalSolutions.Solutions
{
    public class AllianceHelp
    {
        int allianceHelp(int t, int allianceSize)
        {
            var maxNumOfAlliance = allianceSize < 10 ? allianceSize : 10;
            var maxBoost = t / 10 > 60 ? t / 10 : 60;

            return t - (maxBoost * maxNumOfAlliance) < 0 ? 0 : t - (maxBoost * maxNumOfAlliance);
        }
    }
}