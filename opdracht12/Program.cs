namespace opdracht12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kies een naam");

            String[] namen = { "Kerem", "Daan", "Klaas", "Piet", "Kerem" };¶

            foreach (string naam in namen)
            {
                Console.WriteLine(naam);
            }


        }
    }
}
