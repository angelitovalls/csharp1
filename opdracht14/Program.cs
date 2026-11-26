namespace opdracht14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabel = { { 10, 20 }, { 30, 40 }, { 50, 60 } };
            Console.WriteLine(tabel[2, 1]);
            Console.WriteLine(tabel[0, 0] + tabel[1, 1]);

            //De output is 60, 50 omdat tabel[2, 1] = 60 en tabel[0, 0] + tabel[1, 1] = 10 + 40 = 50
        }
    }
}
