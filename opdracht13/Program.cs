namespace opdracht13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            for (int i = 0; i < num.Length; i++)
            {
                int getal;

                while (true)
                {
                    Console.Write("Voer een getal in: ");
                    string? invoerString = Console.ReadLine();

                    if (int.TryParse(invoerString, out getal))
                    {
                        break;
                    }
                }

                num[i] = getal;
            }

            foreach (int getal in num)
            {
                Console.WriteLine(getal);
            }
        }
    }
}