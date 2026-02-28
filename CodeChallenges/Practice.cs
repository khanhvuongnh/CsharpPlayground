namespace CsharpPlayground.CodeChallenges
{
    internal class Practice
    {
        public static void Main()
        {
            MoveZerosToEnd([1, 0, 2, 0, 4, 0]);
            GetUniqueAges([10, 10, 20, 30, 60, 60]);
        }

        public static void MoveZerosToEnd(int[] arr)
        {
            var result = arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
            Console.WriteLine(nameof(MoveZerosToEnd));
            Console.WriteLine("INPUT: " + string.Join(", ", arr));
            Console.WriteLine("OUTPUT: " + string.Join(", ", result));
            Console.WriteLine();
        }

        public static void GetUniqueAges(int[] ages)
        {
            var result = ages.Distinct().ToArray();
            Console.WriteLine(nameof(GetUniqueAges));
            Console.WriteLine("INPUT: " + string.Join(", ", ages));
            Console.WriteLine("OUTPUT: " + string.Join(", ", result));
            Console.WriteLine();
        }
    }
}
