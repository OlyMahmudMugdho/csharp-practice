namespace Arrays
{
    class JaggedArray
    {
        public static void Main(string[] args)
        {
            int[][] nums = new int[2][];
            nums[0] = new int[2];
            nums[1] = new int[2];

            nums[0] = new int[] { 7, 6, 9, 10 };
            nums[1] = new int[] { 8, 10, 3, 4 };

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums[i].Length; j++)
                {
                    Console.Write(nums[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}