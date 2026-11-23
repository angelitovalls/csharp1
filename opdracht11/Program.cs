namespace opdracht11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool doorgaan = true;

            while (doorgaan)
            {
                Console.WriteLine("HOOFDMENU ");
                Console.WriteLine("1. Menu 1");
                Console.WriteLine("2. Menu 2");
                Console.WriteLine("3. Afsluiten");
                Console.Write("Maak een keuze (1-3): ");

                ConsoleKeyInfo toetsInfo = Console.ReadKey(intercept: true);
                Console.WriteLine();

                switch (toetsInfo.KeyChar)
                {
                    case '1':
                        Console.WriteLine("Menu 1");
                        break;

                    case '2':
                        Console.WriteLine("Menu 2");
                        break;

                    case '3':
                        Console.WriteLine("Programma wordt afgesloten...");
                        doorgaan = false;
                        break;

                    default:
                        Console.WriteLine("Ongeldige keuze. Voer 1, 2 of 3 in");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}