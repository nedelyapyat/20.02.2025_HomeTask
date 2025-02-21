using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._25_HomeTask_Egor_Mansur
{
    internal class _11_BinaryStringToDecimalNum
    {
        public static void Execute()
        {
            Console.Write("Введите двоичное число: ");
            string binaryString = Console.ReadLine();

            try
            {
                int decimalValue = Convert.ToInt32(binaryString, 2);
                Console.WriteLine("Десятичное значение: " + decimalValue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат двоичного числа.");
            }
        }
    }
}
