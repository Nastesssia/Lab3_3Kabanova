using System;

namespace Kabanova3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.3 Вариант 6
            try
            {
                Console.WriteLine("Введите n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите x:");
                double x = double.Parse(Console.ReadLine());
                double S = 0;
                for (int i = 1; i <= n; i++)
                {
                    long F = 1;
                    for (int j = 1; j < i - 1; j++) F *= j;
                    S += Math.Cos((i - 1) * (Math.PI / 4)) / (i - 1) * F;
                }
                Console.WriteLine("S={0:F2}", S);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
