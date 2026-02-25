namespace inputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            //Vavejdane ot klaviaturata dokato ne se vavejde 0
            int num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                numbers.Add(num);
                num = int.Parse(Console.ReadLine());
            }

            // numbers.Add(5);
            // numbers.Add(10);
            // numbers.Add(6);
            // numbers.Add(12);
            // numbers.Add(13);
            //// Console.WriteLine(numbers.Count);
            // numbers.Insert(1, 11);
            // numbers.Insert(4, 7);
            // numbers.Insert(5, 9);
            // numbers.Insert(3, 2);
            // Console.WriteLine(numbers.Count);


            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            for (int index = 0; index < numbers.Count; index++)
            {
                Console.WriteLine($"{index}---> {numbers[index]}");
            }

        }
    }
}
