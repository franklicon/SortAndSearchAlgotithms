using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortAlgorithms.Algorithms
{
    /// <summary>
    /// Implementation of some of the basic search algorithms.
    /// </summary>
    public class SearchAlgorithms
    {
        /// <summary>
        /// Linear Search.
        /// </summary>
        /// <param name="array">A finite integer array not necessarily ordered.</param>
        /// <param name="x">The integer to find.</param>
        /// <returns>True if the interger "x" is in the integer array "array", false otherwise.</returns>
        public bool LinearSearch(int[] array, int x)
        {
            for(var i=0; i<array.Length; i++)
            {
                if(array[i] == x)
                {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Binary Search.
        /// </summary>
        /// <param name="array">A finite interger ordered array.</param>
        /// <param name="x">The interger to find.</param>
        /// <returns>True if the interger "x" is in the integer array "array", false otherwise.</returns>
        public bool BinarySearch(int[] array, int x)
        {
            var left = 0;
            var right = array.Length - 1;
            while(left <= right)
            {
                var mid = (left + right) / 2;
                if (x == array[mid])
                {
                    return true;
                }
                if(x < array[mid])
                {
                    right = mid-1;
                }
                else
                {
                    left = mid+1;
                }
            }
            return false;
        }
    }
}
