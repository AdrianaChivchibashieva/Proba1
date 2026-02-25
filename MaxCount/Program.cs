namespace MaxCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();
            byte count = 1;
            byte maxCount = 0;
            int maxElement = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    maxCount = count;
                    maxElement = numbers[i];
                }
                count = 1;
            }
            Console.WriteLine($"Max repetetElement is {maxElement} --> {maxCount} items.");
        }
    }
}
