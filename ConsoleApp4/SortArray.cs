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

        public SortArray()
        {
            Collection = new List<int>();
        }

        public override string ToString()
        {
            return string.Join(",", Collection);
        }

        public void ReadFromString(string input)
        {
            string[] inputArray = input?.Split(' ');
            List<int> numbers = new List<int>();

            foreach(string element in inputArray)
            {
                if(int.TryParse(element, out int result))
                {
                    numbers.Add(result);
                }
            }

            Collection = numbers;
        }

    }
}
