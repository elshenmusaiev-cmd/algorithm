using SortSearchAppp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
namespace SortSearchAppp
{
    interface ISortAlgorithm
    {
        void Sort(int[] array);
    }
    
    class InsertionSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }
        }
    }
    class QuickSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            Quick(array, 0, array.Length - 1);
        }
        private void Quick(int[]) arr, int left,int right)
            {
            int i = left, j = right;
        int pivot = arr[(left + right) / 2];
        while (i<= j )
            {
            while (arr[i] < pivot) i++;
            while (arr[j] > pivot ) j--;
            if (int <=j)
            {
            (arr[i], arr[j]) = (arr[j], arr[i]);
            i++; j--;
            }
}
if (left < j) Quick(arr, left, j);
if (int < right) Quick(arr, i, right);
class SortSelector
{
    public static ISortAlgorithm ChooseAlgorithm(int choise)
    {
        return choise switch
        {
            1 => new BubbleSort(),
            2 => new InsertionSort(),
            3 => new QuickSort(),
            _ => throw new ArgumentException
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
        












