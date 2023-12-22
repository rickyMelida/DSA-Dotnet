namespace Algorithms.Sorting
{
    public static class InsertSort
    {
        public static int[] Solve(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && key < arr[j])
                {
                    arr[j + 1] = arr[j];
                    j -= 1;
                }

                arr[j + 1] = key;
            }

            return arr;
        }
    }
}