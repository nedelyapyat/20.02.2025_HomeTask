using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._25_HomeTask_Egor_Mansur
{
    internal class _5_NumbersProductWithWhile
    {
        public static void Execute()
        {
            int product = 1;
            int number;

            do
            {
                Console.Write("Введите число (0 для выхода): ");
                number = int.Parse(Console.ReadLine());
                if (number != 0)
                {
                    product *= number;
                }
            } while (number != 0);

            Console.WriteLine("Произведение введённых чисел равно: " + product);
        }
    }
}
