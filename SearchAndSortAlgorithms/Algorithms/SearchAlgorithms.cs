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
    }
}
