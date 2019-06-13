namespace CodeSignalSolutions.Solutions
{
    public class ArrayComplexElementsProduct
    {
        int[] arrayComplexElementsProduct(int[] real, int[] imag)
        {

            for (var i = 1; i < real.Length; i++)
            {
                var currentReal = real[i - 1] * real[i] - imag[i - 1] * imag[i];
                var currentImag = real[i - 1] * imag[i] + real[i] * imag[i - 1];
                real[i] = currentReal;
                imag[i] = currentImag;

            }

            return new int[] { real[real.Length - 1], imag[imag.Length - 1] };
        }
    }
}