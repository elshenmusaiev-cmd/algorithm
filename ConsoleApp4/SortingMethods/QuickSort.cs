using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.SortingMethods
{
    class QuickSort : SortAlgorithmBase
    {
        public override int[] Sort(int[] array)
        {
            if (array.Length == 0)
                throw new Exception();

            Sort(array, 0, array.Length - 1);

            return array;
        }

        private void Sort(int[] arr, int left, int right)
        {

            int i = left;
            int j = right;
            int pivot = arr[(left + right) / 2];

            while (i <= j)
            {
                while (arr[i] < pivot)
                {
                    i++;
                }

                while (arr[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    (arr[i], arr[j]) = (arr[j], arr[i]);
                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Sort(arr, left, j);
            }

            if (i < right)
            {
                Sort(arr, i, right);
            }
        }
    }
}
