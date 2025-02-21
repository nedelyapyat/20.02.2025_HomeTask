using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._25_HomeTask_Egor_Mansur
{
    internal class _4_SumNumFrom1toN
    {
        public static void Execute()
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }

            Console.WriteLine("Сумма чисел от 1 до " + N + " равна: " + sum);
        }
    }
}
