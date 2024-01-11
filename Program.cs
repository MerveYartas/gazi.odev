namespace gazi.odev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("How many numbers do you want to sort?");
            byte count = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter starting number:");
            byte start = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter end number:");
            byte end = byte.Parse(Console.ReadLine());

            List<int> sonuc1 = new List<int>();

            for (int i = 0; i < count; i++)
            {
                int mrv;
                do
                {
                    mrv = rnd.Next(start, end + 1);
                } while (sonuc1.Contains(mrv));
                sonuc1.Add(mrv);

            }

            Console.WriteLine(String.Join(" ", sonuc1));

        }
    }
}