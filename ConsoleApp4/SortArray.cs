using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class SortArray
    {
        public List<int> Collection { get; set; }

        public SortArray(List<int> array) 
        {
            Collection = array;
        }

        public override string ToString()
        {
            return string.Join(",", Collection);
        }
    }
}
