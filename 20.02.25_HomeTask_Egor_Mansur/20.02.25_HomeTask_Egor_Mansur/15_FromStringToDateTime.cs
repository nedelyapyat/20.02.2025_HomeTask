using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._25_HomeTask_Egor_Mansur
{
    internal class _15_FromStringToDateTime
    {
        public static void Execute()
        {
            Console.Write("Введите дату в формате dd.MM.yyyy: ");
            string dateString = Console.ReadLine();

            try
            {
                DateTime date = DateTime.ParseExact(dateString, "dd.MM.yyyy", null);
                Console.WriteLine("Преобразованная дата: " + date.ToString("d"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: неверный формат даты.");
            }
        }
    }
}
