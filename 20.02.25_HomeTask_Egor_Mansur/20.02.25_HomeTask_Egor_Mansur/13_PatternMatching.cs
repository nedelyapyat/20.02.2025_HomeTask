using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._25_HomeTask_Egor_Mansur
{
    internal class _13_PatternMatching
    {
        public static void Execute()
        {
            Console.Write("Введите значение (целое число, строку или ничего): ");
            string input = Console.ReadLine();

            object value = string.IsNullOrEmpty(input) ? (object)null : (object)input;
            if (int.TryParse(input, out int intValue))
            {
                value = intValue;
            }

            switch (value)
            {
                case int i:
                    Console.WriteLine("Целое число: " + i);
                    break;
                case string s:
                    Console.WriteLine("Строка: " + s);
                    break;
                case null:
                    Console.WriteLine("Объект равен null.");
                    break;
                default:
                    Console.WriteLine("Неизвестный тип данных.");
                    break;
            }
        }
    }
}
