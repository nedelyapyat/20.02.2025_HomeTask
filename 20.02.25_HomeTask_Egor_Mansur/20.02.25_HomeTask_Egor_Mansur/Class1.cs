using System.Numerics;
using static System.Console;

namespace _20._02._25_HomeTask_Egor_Mansur
{
    public class Class1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                WriteLine("Введите номер задания (от 1 до 15) или 0 для выхода:");
                if (int.TryParse(ReadLine(), out int taskNumber))
                {
                    if (taskNumber == 0) break;

                    switch (taskNumber)
                    {
                        case 1:
                            _1_EvenOdd.Execute();
                            break;
                        case 2:
                            _2_SymbolAnalysis.Execute();
                            break;
                        case 3:
                            _3_StringToNumber.Execute();
                            break;
                        case 4:
                            _4_SumNumFrom1toN.Execute();
                            break;
                        case 5:
                            _5_NumbersProductWithWhile.Execute();
                            break;
                        case 6:
                            _6_Explicit_ImplicitTypeConversion.Execute();
                            break;
                        case 7:
                            _7_OverflowCheck.Execute();
                            break;
                        case 8:
                            _8_ArrayMaxValue.Execute();
                            break;
                        case 9:
                            _9_BitOperations.Execute();
                            break;
                        case 10:
                            _10_SimplrCalculatorOnSwitch.Execute();
                            break;
                        case 11:
                            _11_BinaryStringToDecimalNum.Execute();
                            break;
                        case 12:
                            _12_ValidatingDoWhileInput.Execute();
                            break;
                        case 13:
                            _13_PatternMatching.Execute();
                            break;
                        case 14:
                            _14__MultiplicationTable.Execute();
                            break;
                        case 15:
                            _15_FromStringToDateTime.Execute();
                            break;
                        default:
                            WriteLine("Некорректный номер задания.");
                            break;
                    }
                }
                else
                {
                    WriteLine("Некорректный ввод. Пожалуйста, введите число.");
                }
            }
        }
    }
}
