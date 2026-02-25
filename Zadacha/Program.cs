namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            //Console.Write("Vavedi chisla");
            //int chislo = int.Parse(Console.ReadLine());
            //while (chislo != -1)
            //{
            //    numbers.Add(chislo);
            //    Console.WriteLine("Vavedi chislo");
            //    chislo = int.Parse(Console.ReadLine());
            //}
            //Console.Write("Vavedi chislo za tursene i iztrivane");
            //int numberToRemove = int.Parse(Console.ReadLine());
            //int index = 0;
            //while (numbers.IndexOf(numberToRemove) != -1)
            //{
            //    numbers.RemoveAt(numbers.IndexOf(numberToRemove));
            //}

            //Console.WriteLine(string.Join(" ", numbers));





            List<int> numbers = new List<int>();

                Console.WriteLine("Въведи числа: ");

            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                numbers.Add(num);
                num = int.Parse(Console.ReadLine());    
            }

            Console.Write("Въведи число за изтриване: ");
            int numberToRemove = int.Parse(Console.ReadLine());

            if (numbers.Contains(numberToRemove))
            {
                numbers.Remove(numberToRemove);
            }
            else
            {
                Console.WriteLine("Числото не е в списъка.");
            }

            Console.WriteLine("Оставащи числа:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}






        
