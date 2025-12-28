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
        public static ISortAlgorithm ChooseAlgorithm(string choice)
        {
            return choice.Trim() switch
            {
                "1" => new BubbleSort(),
                "2" => new InsertionSort(),
                "3" => new QuickSort(),
                _ => throw new ArgumentException()
            };

        }

        public static string ShowAlgorithms()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Выберите алгоритм сортировки");
            sb.AppendLine("1- Пузырковая сортировка");
            sb.AppendLine("2- Сортировка вставками");
            sb.AppendLine("3- Быстрая сортирповка");

            
            return sb.ToString();
        }
    }
}
