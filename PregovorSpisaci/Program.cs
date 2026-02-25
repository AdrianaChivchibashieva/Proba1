namespace PregovorSpisaci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            List<string> imena = Console.ReadLine().Split( ).ToList();
            int input = int.Parse( Console.ReadLine() );
            while (input != 0)
            {
                numbers.Add( input );
                input = int.Parse(Console.ReadLine());
            }
            //output
            foreach (int i in numbers) 
            { 
                Console.Write( i );
            }
        }
    }
}
