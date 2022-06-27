using SearchAndSortAlgorithms.Algorithms;
using SearchAndSortAlgorithms.Problems;

// ---------------------- Search Algorithms ---------------------

var searchAlgorithms = new SearchAlgorithms();
var searchAlgorithmsProblems = new SearchAlgorithmsProblems();
var intSearchArray = new int[10] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
var cyclicSequenceA = new int[16] { 14, 16, 19, 21, 23, 27, 1, 3, 4, 5, 7, 8, 9, 11, 12, 13 };
var cyclicSequenceB = new int[9] { 14, 16, 18, 2, 4, 6, 8, 10, 12 };

// Linear Search.
Console.WriteLine(searchAlgorithms.LinearSearch(intSearchArray, 4)); // False.
Console.WriteLine(searchAlgorithms.LinearSearch(intSearchArray, 19)); // True

// Binary Search.
Console.WriteLine(searchAlgorithms.BinarySearch(intSearchArray, 4)); // False.
Console.WriteLine(searchAlgorithms.BinarySearch(intSearchArray, 19)); // True

Console.WriteLine(searchAlgorithmsProblems.CyclicSequence(cyclicSequenceA)); //6
Console.WriteLine(searchAlgorithmsProblems.CyclicSequence(cyclicSequenceB)); //3

// ---------------------- Search Algorithms ---------------------

var sortAlgorithms = new SortAlgorithms();
var intArrayToSortA = new int[10] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
var intArrayToSortB = new int[10] { 9, 7, 8, 5, 6, 0, 3, 2, 1, 4 };

// Bubble Sort.
Console.WriteLine(string.Join(",", sortAlgorithms.BubbleSort(intArrayToSortA)));
Console.WriteLine(string.Join(",", sortAlgorithms.BubbleSort(intArrayToSortB)));