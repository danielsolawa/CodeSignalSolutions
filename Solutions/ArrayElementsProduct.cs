namespace CodeSignalSolutions.Solutions
{
    public class ArrayElementsProduct
    {
        int arrayElementsProduct(int[] inputArray)
        {
            return helper(inputArray, 0);
        }


        int helper(int[] arr, int index)
        {
            if (index == arr.Length - 1)
            {
                return arr[index];
            }

            return arr[index] * helper(arr, index + 1);
        }
    }
}