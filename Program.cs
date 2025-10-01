//***************************************************************************
// *Практическая работа №9                                                  *
//* Выполнил: Абдуллаев Э.С., группа 2-ИСПд                                 *
//* Задание: массив А = 10.Найти кол-во и сумму элементов, кратным М        *
//***************************************************************************
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
            try 
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Title = "Практическая работа №9";
                Console.WriteLine("Здравствуйте!");
                Console.ForegroundColor = ConsoleColor.Blue;
                int count = 0;
                int sum = 0;
                int[] A = new int[10];
                Console.WriteLine("Введите 10 чисел для массива А: ");
                for (int i = 0; i < A.Length; i++)
                {
                    Console.Write($"Элемент {i + 1}:");
                    A[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Введите значения для М: ");
                int M = Convert.ToInt32(Console.ReadLine());
                foreach (int num in A)
                {
                    if (num / M >= -1)
                    {
                        count++;
                        sum += num;
                    }
                }
                Console.WriteLine($"Количество элементов: {count}");
                Console.Write($"Сумма элементов, кратных М: {sum}");
            }
            catch (IndexOutOfRangeException iEx)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Произошла ошибка: {iEx.Message}");
            }
            catch (FormatException fEx)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка:{fEx.Message}");
            }
            catch (OverflowException oEx)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Ошибка: {oEx.Message}");
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}