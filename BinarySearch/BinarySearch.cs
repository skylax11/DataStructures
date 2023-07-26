using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.BinarySearch
{
    public class BinarySearch
    {
        public int[] Array { get; set; }
        public int BinarySearchFunction(int[] intArray, int value)
        {
            int start = 0;
            int end = intArray.Length;
            while (start < end)
            {
                int midpoint = (start + end) / 2;
                if (intArray[midpoint] == value)
                {
                    return midpoint;
                }
                else if (intArray[midpoint] < value)
                {
                    start = midpoint + 1;
                }
                else
                {
                    end = midpoint;
                }
            }
            return -1;
        }
    }
}
