using System.Threading.Channels;

namespace Worklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList(); //new List<int>();
            //actions
            int positiveCount = 0;
            int negativeCount = 0;
            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine($"Chetnite chisla sa: ");
           // foreach (int chervrnoKvadratche in numbers)
           for ( int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.WriteLine(i);
                    evenCount++;
                }
            }

            Console.WriteLine($"Nechetnite chisla sa: ");
            foreach (int chervrnoKvadratche in numbers)
            {
                if (chervrnoKvadratche % 2 != 0)
                {
                    Console.WriteLine(chervrnoKvadratche);
                    oddCount++;
                }
            }

            Console.WriteLine($"Otricatelnite chisla sa: ");
            foreach (int chervrnoKvadratche in numbers)
            { 
            if (chervrnoKvadratche < 0)
                {
                    Console.WriteLine(chervrnoKvadratche);
                    negativeCount++;
                }
            }
            Console.WriteLine($"Polojitelni chisla sa: ");
            foreach (int chervrnoKvadratche in numbers)
            {
                if (chervrnoKvadratche > 0)
                {
                    Console.WriteLine(chervrnoKvadratche);
                    positiveCount++;
                }
            }
            Console.WriteLine($"Broi polojitelni chisla: {positiveCount}");
            Console.WriteLine($"Broi otriatelnite chisla: {negativeCount}");   
            Console.WriteLine($"Broi chetni chisla: {evenCount}");
            Console.WriteLine($"Broi nechetni chisla: {oddCount}");

            //output
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
