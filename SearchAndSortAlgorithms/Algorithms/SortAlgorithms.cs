using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSortAlgorithms.Algorithms
{
    /// <summary>
    /// Implementation of some sort algorithms.
    /// </summary>
    public class SortAlgorithms
    {
        /// <summary>
        /// Bubble Sort.
        /// </summary>
        /// <param name="array">A finite interger array.</param>
        /// <returns>The array "array" in ascending order.</returns>
        /// Time complexity: O(n^2).
        public int[] BubbleSort(int[] array)
        {
            var n = array.Length - 1;
            for(var i=0; i<n; i++)
            {
                for (var j = 0; j < n - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }

        /// <summary>
        /// Selection Sort.
        /// </summary>
        /// <param name="array">A finite interger array.</param>
        /// <returns>The array "array" in ascending order.</returns>
        /// Time complexity: O(n^2).
        public int[] SelectionSort(int[] array)
        {
            var n = array.Length - 1;
            for(var i=0; i<n; i++)
            {
                var min = array[i];
                var aux = i;
                for(var j=i; j<n; j++)
                {
                    if(array[j] < min)
                    {
                        min = array[j];
                        aux = j;
                    }
                }
                var temp = array[i];
                array[i] = min;
                array[aux] = temp;
            }
            return array;
        }

        /// <summary>
        /// Insertion Sort.
        /// </summary>
        /// <param name="array">A finite interger array.</param>
        /// <returns>The array "array" in ascending order.</returns>
        /// Time complexity: O(n^2).
        public int[] InsertionSort(int[] array)
        {
            var n = array.Length - 1;
            for(var i=0; i<n; i++)
            {
                for(var j=0; j<i; j++)
                {
                    if(array[i] < array[j])
                    {
                        var temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                        break;
                    }
                }
            }
            return array;
        }
    }
}
