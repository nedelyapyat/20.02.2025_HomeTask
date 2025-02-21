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
                            SymbolAnalysis.Execute();
                            break;
                        case 3:
                            StringToNumber.Execute();
                            break;
                        case 4:
                            SumNumFrom1toN.Execute();
                            break;
                        case 5:
                            NumbersProductWithWhile.Execute();
                            break;
                        case 6:
                            ExplicitImplicitTypeConversion.Execute();
                            break;
                        case 7:
                            OverflowCheck.Execute();
                            break;
                        case 8:
                            ArrayMaxValue.Execute();
                            break;
                        case 9:
                            BitOperations.Execute();
                            break;
                        case 10:
                            SimpleCalculatorOnSwitch.Execute();
                            break;
                        case 11:
                            BinaryStringToDecimalNum.Execute();
                            break;
                        case 12:
                            ValidatingDoWhileInput.Execute();
                            break;
                        case 13:
                            PatternMatching.Execute();
                            break;
                        case 14:
                            MultiplicationTable.Execute();
                            break;
                        case 15:
                            StringToDateTime.Execute();
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
