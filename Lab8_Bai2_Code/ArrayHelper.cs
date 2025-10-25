namespace Lab8_Bai2_Code
{
    public class ArrayHelper
    {
        public static int FindMax(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty.");
            }
            return array.Max();
        }

        public static int FindMin(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array must not be null or empty.");
            }
            return array.Min();
        }
    }
}
