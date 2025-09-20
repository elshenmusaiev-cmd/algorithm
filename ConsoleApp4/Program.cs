using System;
using System.Collections.Concurrent;
class Program
{
    public void Main(string[] args)
    {
        
    }
    // Пузырковая сортировка 
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    (array[j], array[j + 1]) = (array[j + 1], array[j]);
                }
            }
        }
    }
    static void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)//musaev005
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[i] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }
    static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(array, left, right);
            //рекурсивные вызовы через switch-case
            switch (1) // для примера: всегда выполняем рекурсивный шаг
            {
                case 1:
                    QuickSort(array, left, pivot - 1);
                    QuickSort(array, pivot + 1, right);
                    break;
            }
        }
    }
    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
            if (array[j] <= pivot)
            {
                i++;
                    (array[i], array[j]) = (array[i], array[i]);
            }

        (array[i + 1], array[right]) = (array[right], array[i + 1]);
        return i + 1;

    }
}








