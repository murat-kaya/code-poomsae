using System;
using System.Collections.Generic;
using System.Linq;


namespace FindMissingNumbersInList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 4, 6, 8, 12, 21 };

            List<int> result = FindMissing(list);

                Console.Write(string.Join(", ", result));
            Console.Read();

        }

        public static List<int> FindMissing(int[] arr)
        {
            if (arr.Length != 0)
            {
                //Sort list first..
                var ordered = arr.Select(p => p).OrderBy(o => o).ToArray();

                List<int> missingList = new List<int>();

                for (int i = 1; i < ordered.Max()+1; i++)
                {
                    if(!arr.Contains(i))
                    {
                        missingList.Add(i);
                    }
                }
                return missingList;
            }
            return new List<int>();
        }

    }
}

**input**
 1, 4, 6, 8, 12, 21 
 
**output**
2, 3, 5, 7, 9, 10, 11, 13, 14, 15, 16, 17, 18, 19,20
