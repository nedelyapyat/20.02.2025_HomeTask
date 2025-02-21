using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._25_HomeTask_Egor_Mansur
{
    internal class _3_StringToNumber
    {
        public static void Execute()
        {
            Console.Write("Введите строку, содержащую числовое значение: ");
            string input = Console.ReadLine();

            try
            {
                int number = int.Parse(input);
                Console.WriteLine("Преобразованное число: " + number);
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат строки.");
            }
        }
    }
}
