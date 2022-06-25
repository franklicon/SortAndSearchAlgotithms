using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortAlgorithms.Problems
{
    /// <summary>
    /// Problems that are solved applying the Binary Search strategy.
    /// </summary>
    public class SearchAlgorithmsProblems
    {
        /// <summary>
        /// Cyclic Sequence.
        /// A sequence S = x0, x1,..., xn is cyclically ordered if the smallest number in
        /// the sequence is the element xi for some unknown i and the sequence S' is ordered 
        /// in ascending order with S' = xi, xi+1,...,xn, x0, x1,...,xi-1.
        /// For example: S = {14, 16, 19, 21, 23, 27, 1, 3, 4, 5, 7, 8, 9, 11, 12, 13} is a ciclically 
        /// ordered sequence with i = 6.
        /// </summary>
        /// <param name="array">A finite interger array cyclically ordered.</param>
        /// <returns>The index of the smallest element.</returns>
        public int CyclicSequence(int[] array)
        {
            var left = 0;
            var right = array.Length - 1;
            while(left <= right)
            {
                var mid = (left + right) / 2;
                if(left == right)
                {
                    return left;
                }
                if(array[mid] < array[right])
                {
                    right = mid;
                }
                else
                {
                    left = mid+1;
                }
            }
            return default;
        }
    }
}
