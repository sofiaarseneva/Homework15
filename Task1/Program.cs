using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Прогрессии!\n\n");
            try
            {
                Console.WriteLine("Введите начальное значение: ");
                int startValue = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите шаг прогрессии: ");
                int step = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Выберите прогрессию - \n1 - арифметическая, 2 - геометрическая");
                int typeProgression = Convert.ToInt32(Console.ReadLine());

                switch (typeProgression)
                {
                    case 1:
                        {
                            ArithProgression arithProgression = new ArithProgression(step, startValue);
                            arithProgression.SetStart(startValue);

                            Console.WriteLine("Нажимайте соответствующую клавишу для выполнения нужного действия:");
                            Console.WriteLine("Enter - следующее значение ряда, Tab - сброс на начальное значение, любая клавиша - выход");
                            ConsoleKey pressedKey = Console.ReadKey().Key;

                            while (pressedKey == ConsoleKey.Enter || pressedKey == ConsoleKey.Tab)
                            {
                                switch (pressedKey)
                                {
                                    case ConsoleKey.Enter:
                                        {
                                            Console.WriteLine("Следующее число ряда с шагом {0} равно {1}", step, arithProgression.GetNext());
                                            break;
                                        }
                                    case ConsoleKey.Tab:
                                        {
                                            arithProgression.Reset();
                                            Console.WriteLine("Значение сброшено на начальное и равно {0}", startValue);
                                            break;
                                        }
                                }
                                pressedKey = Console.ReadKey().Key;
                            }
                            break;
                        }
                    case 2:
                        {
                            GeomProgression geomProgression = new GeomProgression(step, startValue);
                            geomProgression.SetStart(startValue);

                            Console.WriteLine("Вводите соответствующую букву для нужного действия:");
                            Console.WriteLine("Enter - следующее значение ряда, Tab - сброс на начальное значение, Esc - выход");
                            ConsoleKey pressedKey = Console.ReadKey().Key;

                            while ((pressedKey == ConsoleKey.Enter || pressedKey == ConsoleKey.Tab) && pressedKey != ConsoleKey.Escape)
                            {
                                switch (pressedKey)
                                {
                                    case ConsoleKey.Enter:
                                        {
                                            Console.WriteLine("Следующее число ряда с шагом {0} равно {1}", step, geomProgression.GetNext());
                                            break;
                                        }
                                    case ConsoleKey.Tab:
                                        {
                                            geomProgression.Reset();
                                            Console.WriteLine("Значение сброшено на начальное и равно {0}", startValue);
                                            break;
                                        }
                                }
                                pressedKey = Console.ReadKey().Key;
                            }
                            break;
                        }
                    default:
                        {
                            throw new Exception("Данный вид прогрессии не определен!");
                        }
                }
                Console.WriteLine("\nДля выхода из программы нажмите еще раз любую клавишу!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
                Console.ReadKey();
            }
        }
    }
}
