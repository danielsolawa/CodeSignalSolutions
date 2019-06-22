using System;

namespace CodeSignalSolutions.Solutions
{
    public class MinimalNumberOfCoins
    {
        //Iterative solution
        int minimalNumberOfCoins(int[] coins, int price)
        {
            Array.Sort(coins);
            var result = 0;
            var index = coins.Length - 1;
            while (price > 0)
            {
                if (coins[index] <= price)
                {
                    var r = price / coins[index];
                    result += r;
                    price -= (r * coins[index]);
                }
                index--;
            }

            return result;
        }


        //Recursive solution
        int minimalNumberOfCoinsR(int[] coins, int price)
        {
            Array.Sort(coins);

            return minimalNumberOfCoinsR(coins, price, coins.Length - 1);
        }

        int minimalNumberOfCoinsR(int[] coins, int price, int i)
        {
            if (price == 0)
            {
                return 0;
            }

            return (price / coins[i]) + minimalNumberOfCoinsR(coins, price - ((price / coins[i]) * coins[i]), --i);
        }

    }
}