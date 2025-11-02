using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using ConsoleApp4.SortingMethods;

namespace ConsoleApp4
{
    class Program
    {
        public void Main()
        {
            Console.WriteLine("Enter values");

            string input = Console.ReadLine();
            string selectedAlgorithm = Console.ReadLine();

            // TODO: Создать отдельный класс для преобразования прочитанного массива
            string[] inputArray = input?.Split(' ').ToArray();
            int[] numbers = new int[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)
            {
                int.TryParse(inputArray[i], out numbers[i]);
            }

            // SortSelector

            // Sort

            // Console.WriteLine();

            // TODO: Прочитать число для поиска

            // Console.WriteLine()

            Console.ReadLine();
        }
    }
    
}
        












