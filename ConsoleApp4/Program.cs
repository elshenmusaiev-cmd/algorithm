using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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

            SortArray sortArray = new SortArray();
            sortArray.ReadFromString(input);

            Console.WriteLine(SortSelector.ShowAlgorithms());
            string selectedAlgorithm = Console.ReadLine();
            ISortAlgorithm sortAlgorithm = SortSelector.ChooseAlgorithm(selectedAlgorithm);

            sortAlgorithm.Sort(sortArray.Collection.ToArray());
            Console.WriteLine(sortAlgorithm.ToString());
            Console.ReadLine();
            string searchInput = Console.ReadLine();





        }
    }
}