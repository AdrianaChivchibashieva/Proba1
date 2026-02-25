using System.Threading.Channels;

namespace find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vavejdane i tursene");


            List<string> imena = new List<string>();
            imena.Add("Dimitar");
            imena.Add("10");
            imena.Add("Petar");
            Console.WriteLine("Vavedi 3 neshta ot klaviaturata ");   
            imena.Add(Console.ReadLine());
            imena.Add(Console.ReadLine());
            imena.Add(Console.ReadLine());  
            Console.WriteLine("Vavedi imena ... end za krai");
            string stringInput = Console.ReadLine();

            while (stringInput != "END")
            {
                imena.Add(stringInput);
                stringInput = Console.ReadLine();
            }
            //if (imena.Contains("Dimitar"))
            //{
            //    Console.WriteLine("Dimitar e vaveden");
            //}
            if (imena.IndexOf("Dimo") != -1) //(imena.Contains("Dimo"))
            {
                Console.WriteLine($"Dimo e na {imena.IndexOf("Dimo")} mqsto v spisaka");
            }
            else
            {
                Console.WriteLine("Dimo ne e vaveden");
            }

            Console.WriteLine($"Dimo go ima i na {imena.LastIndexOf("Dimo")} mqsto v spisaka");

            Console.WriteLine(string.Join(", ", imena));

        }
    }
}
