namespace opdracht15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uitkomst = Rekenmachine.Optellen(4, 7);
            Console.WriteLine("De som is: " + uitkomst);
        }
    }

    class Rekenmachine
    {
        public static int Optellen(int getal1, int getal2)
        {
            return getal1 + getal2;
        }
    }
}