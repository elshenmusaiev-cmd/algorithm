using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.SortingMethods
{
    internal abstract class SortAlgorithmBase : ISortAlgorithm
    {
        public int[] SavedArray { get; set; }

        public abstract int[] Sort(int[] array);

        public override string ToString()
        {
            return string.Join(",", SavedArray);
        }
    }
}
