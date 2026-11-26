namespace opdracht16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nummer1 = VraagGetal("Voer het eerste getal in:");
            double nummer2 = VraagGetal("Voer het tweede getal in:");
            string keuze = VraagKeuze();

            if (keuze == "1")
            {
                OptellenEnAftrekken(nummer1, nummer2);
            }
            else if (keuze == "2")
            {
                OptellenEnVermenigvuldigen(nummer1, nummer2);
            }
            else if (keuze == "3")
            {
                OptellenEnDelen(nummer1, nummer2);
            }
        }

        static double VraagGetal(string vraag)
        {
            while (true)
            {
                Console.WriteLine(vraag);
                string invoer = Console.ReadLine();

                if (double.TryParse(invoer, out double getal))
                {
                    return getal;
                }
                else
                {
                    Console.WriteLine("Voer een geldig getal in.");
                }
            }
        }

        static string VraagKeuze()
        {
            Console.WriteLine("1 = optellen & aftrekken");
            Console.WriteLine("2 = optellen & vermenigvuldigen");
            Console.WriteLine("3 = optellen & delen");

            while (true)
            {
                string keuze = Console.ReadLine();

                if (keuze == "1" || keuze == "2" || keuze == "3")
                {
                    return keuze;
                }
                else
                {
                    Console.WriteLine("Ongeldige keuze. Voer 1, 2 of 3 in");
                }
            }
        }

        static void OptellenEnAftrekken(double nummer1, double nummer2)
        {
            Console.WriteLine("Optellen: " + (nummer1 + nummer2));
            Console.WriteLine("Aftrekken: " + (nummer1 - nummer2));
        }

        static void OptellenEnVermenigvuldigen(double nummer1, double nummer2)
        {
            Console.WriteLine("Optellen: " + (nummer1 + nummer2));
            Console.WriteLine("Vermenigvuldigen: " + (nummer1 * nummer2));
        }

        static void OptellenEnDelen(double nummer1, double nummer2)
        {
            Console.WriteLine("Optellen: " + (nummer1 + nummer2));
            Console.WriteLine("Delen: " + (nummer1 / nummer2));
        }
    }
}