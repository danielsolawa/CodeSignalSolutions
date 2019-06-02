namespace CodeSignalSolutions.Solutions
{
    public class CompanyBots
    {
        double companyBotStrategy(int[][] trainingData)
        {
            var correctAnswers = 0;
            var values = 0;

            for (var i = 0; i < trainingData.Length; i++)
            {
                if (trainingData[i][1] == 1)
                {
                    correctAnswers++;
                    values += trainingData[i][0];
                }
            }

            return correctAnswers == 0 ? 0 : (double)values / (double)correctAnswers;
        }
    }
}