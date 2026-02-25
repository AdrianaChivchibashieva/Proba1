namespace Ocenki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rezultati ot testa: ");
            string input = Console.ReadLine();

            int[] results = Console.ReadLine().Split(' ').
                Select(int.Parse).ToArray();

            for (int i = 0; i < results.Length; i++)
            {
                results[i] = int.Parse(Console.ReadLine());
                input += results[i];
            }

            int max = results[0];
            int min = results[0];

            for (int i = 1; i < results.Length; i++)
            {
                if (results[i] > max)
                {
                    max = results[i];
                }
                if (results[i] < min)
                {
                    min = results[i];
                }
            }

           

            Console.WriteLine($"Nai-visok rezultat: {max}");
            Console.WriteLine($"Nai-nisuk rezultat: {min}");
            //Console.WriteLine($"Sreden rezultat: {average}");
           // Console.WriteLine($"Broi rezultati nad sreden: {countAbove}");

            
        }
    }
}
