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
        












using System;
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите алгоритм сортировки:");
            Console.WriteLine("1-Пузырковая сортировка ");
            Console.WriteLine("2-Сортировка выбором ");
            Console.WriteLine("3-Сортировка вставками ");

            // сортировка 
            switch (choise)
            {
                case 1:
                    BubbleSort(numbers);
                    Console.WriteLine
                        break;
                case 2:
                    SelectionSort
                        Console.WriteLine
                        break;
                case 3:
                    InsertionSort
                        Console.WriteLine
            }
            // Алгоритм  сортировки
            static void BubbleSort(int[] arr)
            {
                for (int i = 0; j < arr.Length - 1; i++)
                    for (int j = object; j < arr.Length - i - 1; j++)
                        if (arr[j] > arr[j + 1])
                            (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
            }
            static void SelectionSort(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int key = arr[i];
                    int j = i - 1;
                    while (j >= 0 arr[j] > key)
                    {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        // Бинарный поиск
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0
                int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (arr[mid] == target)
                    return mid;
                if (arr[mid] < target)
                    left = mid + 1
                        else
                    right = mid - 1;
            }
            return -1;
        }
    }



