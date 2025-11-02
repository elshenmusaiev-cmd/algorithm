using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp4.SortingMethods;

namespace ConsoleApp4
{
    class SortSelector
    {
        public static ISortAlgorithm ChooseAlgorithm(int choise)
        {
            return choise switch
            {
                1 => new BubbleSort(),
                2 => new InsertionSort(),
                3 => new QuickSort(),
                _ => throw new ArgumentException()
            };

        }

        public static void ShowAlgorithms()
        {
            Console.WriteLine("Выберите алгоритм сортировки");
            Console.WriteLine("1- Пузырковая сортировка");
            Console.WriteLine("2- Сортировка вставками");
            Console.WriteLine("3- Быстрая сортирповка");
        }
    }
}
