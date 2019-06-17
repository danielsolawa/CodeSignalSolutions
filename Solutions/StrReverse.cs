namespace CodeSignalSolutions.Solutions
{
    public class StrReverse
    {
        string Reverse(string s)
        {
            char[] arr = s.ToCharArray();
            int start = 0, end = arr.Length - 1;
            while (start < end)
            {
                var temp = arr[end];
                arr[end] = arr[start];
                arr[start] = temp;
                start++;
                end--;
            }
            return new string(arr);
        }
    }
}