using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16.Bubble_Sort
{
    public class BubbleSort
    {
        public int[] BubbleSortMethod(int[] array)
        {
            int temp = 0;

            for (int pointer = 0; pointer < array.Length; pointer++)
            {
                for (int sort = 0; sort < array.Length - 1; sort++)
                {
                    if (array[sort] > array[sort + 1])
                    {
                        temp = array[sort];
                        array[sort] = array[sort + 1];
                        array[sort + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}
