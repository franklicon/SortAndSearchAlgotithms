﻿using System;
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
            for(var pass=0; pass<n; pass++)
            {
                for (var i = 0; i < n - pass; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
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
    }
}
