using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._02._25_HomeTask_Egor_Mansur
{
    internal class _2_SymbolAnalysis
    {
        public static void Execute()
        {
            Console.Write("Введите символ: ");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (ch)
            {
                case char c when char.IsDigit(c):
                    Console.WriteLine("Это цифра.");
                    break;
                case char c when char.IsLetter(c):
                    Console.WriteLine("Это буква.");
                    break;
                default:
                    Console.WriteLine("Это специальный символ.");
                    break;
            }
        }
    }
}
