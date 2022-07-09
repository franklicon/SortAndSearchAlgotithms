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

        /// <summary>
        /// Local Insertion Sort.
        /// </summary>
        /// <param name="array">A finite interger array.</param>
        /// <returns>An int array containing the elements of the array "array" in ascending order</returns>
        /// This algorithm uses as an auxiliary data structure a linked list.
        /// Time complexity: O(n^2).
        public int[] LocalInsertionSort(int[] array)
        {
            var n = array.Length - 1;
            var list = new LinkedList<int>();
            var lastItem = new LinkedListNode<int>(array[0]);
            list.AddFirst(lastItem);
            bool isValueInserted;
            for(var i=1; i<=n; i++)
            {
                isValueInserted = false;
                if(lastItem.Value < array[i])
                {
                    while(lastItem.Next != null)
                    {
                        lastItem = lastItem.Next;
                        if(lastItem.Value > array[i])
                        {
                            var newListNodeA = new LinkedListNode<int>(array[i]);
                            list.AddBefore(lastItem, newListNodeA);
                            lastItem = newListNodeA;
                            isValueInserted = true;
                            break;
                        }
                    }
                    if (isValueInserted)
                    {
                        continue;
                    }
                    var newListNodeB = new LinkedListNode<int>(array[i]);
                    list.AddAfter(lastItem, newListNodeB);
                    lastItem = newListNodeB;
                }
                else
                {
                    while(lastItem.Previous != null)
                    {
                        lastItem = lastItem.Previous;
                        if(lastItem.Value < array[i])
                        {
                            var newListNodeA = new LinkedListNode<int>(array[i]);
                            list.AddAfter(lastItem, newListNodeA);
                            lastItem = newListNodeA;
                            isValueInserted = true;
                            break;
                        }
                    }
                    if (isValueInserted)
                    {
                        continue;
                    }
                    var newListNodeB = new LinkedListNode<int>(array[i]);
                    list.AddBefore(lastItem, newListNodeB);
                    lastItem = newListNodeB;
                }
            }
            return list.ToArray();
        }
    }
}
