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
        public static  void Main()
        {
            while (true)
            {
                SortArray sortArray = new SortArray();
                string input = string.Empty;

                while (sortArray.Collection.Count == 0) 
                {
                    Console.WriteLine("Enter values");

                    input = Console.ReadLine();
                  

                    sortArray.ReadFromString(input);
                }
                if (input?.Trim() == "-1")
                {
                    break;

                }
                Console.WriteLine(SortSelector.ShowAlgorithms());
                string selectedAlgorithm = Console.ReadLine();
                ISortAlgorithm sortAlgorithm = SortSelector.ChooseAlgorithm(selectedAlgorithm);

                sortAlgorithm.Sort(sortArray.Collection.ToArray());
                Console.WriteLine(sortAlgorithm.ToString());
                
                string searchInput = Console.ReadLine();
                int result = -1;
                while (!int.TryParse(searchInput, out result))
                {

                    searchInput = Console.ReadLine();
                    continue;
                }
                
                int index = sortAlgorithm.SavedArray.ToList().FindIndex(x => x == result);
                Console.WriteLine(index.ToString());
                Console.WriteLine();




                // новый код пишется здесь 
            }




        }
    }
}