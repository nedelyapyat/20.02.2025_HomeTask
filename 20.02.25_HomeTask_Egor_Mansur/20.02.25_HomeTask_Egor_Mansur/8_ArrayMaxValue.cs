using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._25_HomeTask_Egor_Mansur
{
    internal class _8_ArrayMaxValue
    {
        public static void Execute()
        {
            Console.Write("Введите элементы массива через запятую: ");
            string input = Console.ReadLine();
            int[] numbers = input.Split(',').Select(int.Parse).ToArray();

            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

            Console.WriteLine("Максимальное значение в массиве: " + max);
        }
    }
}
