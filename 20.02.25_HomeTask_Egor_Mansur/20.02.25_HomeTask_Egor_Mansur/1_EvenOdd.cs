using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._25_HomeTask_Egor_Mansur
{
    internal class _1_EvenOdd
    {
        public static void Execute()
        {
            Console.Write("Введите целое число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Число чётное.");
                }
                else
                {
                    Console.WriteLine("Число нечётное.");
                }

                // Использование тернарного оператора
                string result = (number % 2 == 0) ? "Число чётное." : "Число нечётное.";
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Некорректный ввод.");
            }
        }
    }
}
