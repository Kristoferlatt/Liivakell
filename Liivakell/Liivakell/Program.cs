using System.Drawing;

namespace liivakell
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liivakell");
            int row = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l < (row - i) * 2 - 1; l++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
            for (int i = 2; i <= row; i++)
            {
                for (int j = row; j > i; j--)
                {
                    Console.Write(" ");
                }
                for (int l = 0; l < i * 2 - 1; l++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");

            }
        }
    }
}
