namespace PregovorMasiv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //deklarirame masiv ot 5 elementa
            //masiv ot 5 inta
            int[] numbers = new int[5];
            //vtri masv s 13 imena
            string[] imena = new string[13];
            //vavedee chislata na 1 red razdeleni sus space
            numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            //vavedete imenata  s cikul
            for (int i = 0; i < imena.Length; i++)
            {
                imena[i]=(Console.ReadLine());
            }
            //otpechatvane po 3 vazmojni nachina
            Console.WriteLine(string.Join(" " , imena ));

            foreach (string i in imena)
            {
                Console.WriteLine(i);
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(imena[i]);
            }
        }
    }
}
