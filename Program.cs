//*******************************************************************************************
// *Практическая работа №9                                                                  *
//* Выполнил: Абдуллаев Э.С., группа 2-ИСПд                                                 *
//* Задание:  массив = 10 найти кол-во и сумму элементов, значения которых кратны М         *
//*******************************************************************************************
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Pr_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool c = true;
            while (c)
            {
                try
                {
                    Console.Clear();
                    Console.Title = "Практическая работа №9";
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Здравствуйте!");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    int count = 0;
                    int sum = 0;
                    int[] A = new int[10];
                    Console.WriteLine("Введите 10 целых чисел для массива:");
                    for (int i = 0; i < A.Length; i++)
                    {
                        Console.Write($"Элемент {i + 1}: ");
                        A[i] = Convert.ToInt32(Console.ReadLine());
                    }
                    int M;
                    while (true)
                    {
                        Console.Write("Введите значение M: ");
                        M = Convert.ToInt32(Console.ReadLine());

                        if (M == 0)
                        {
                            Console.WriteLine("Не верное значение");
                        }
                        else
                        {
                            break;
                        }
                    }
                    foreach (int num in A)
                    {
                        if (num != 0 && num % M == 0)
                        {
                            count++;
                            sum += num;
                        }
                    }
                    Console.WriteLine($"Количество элементов кратных M: {count}");
                    Console.WriteLine($"Сумма элементов: {sum}");
                    Console.WriteLine("Хотите выполнить новый расчет?");
                    Console.WriteLine("1 - новый расчет");
                    Console.WriteLine("0 - выход из программы");
                    string w = Console.ReadLine();
                    switch (w)
                    {
                        case "1":
                            Console.WriteLine("Новый расчет:");
                            Console.WriteLine("Нажмите Enter для продолжения...");
                            Console.ReadKey();
                            continue;
                        case "0":
                            c = false;
                            break;
                        default:
                            Console.WriteLine("Неизвестная команда");
                            Console.Clear();
                            Console.ReadKey();
                            break;
                    }
                }
                catch (IndexOutOfRangeException iEx)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Произошла ошибка: {iEx.Message}");
                    Console.ResetColor();
                    continue;
                }
                catch (FormatException fEx)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка:{fEx.Message}");
                    Console.ResetColor();
                    continue;
                }
                catch (OverflowException oEx)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Ошибка: {oEx.Message}");
                    Console.ResetColor();
                    continue;
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                    Console.ResetColor();
                    continue;
                }
                Console.Clear();
                Console.WriteLine("Программа завершена, нажмите любую клавишу для выхода");
                Console.ReadKey();
            }
        }
    }
}
