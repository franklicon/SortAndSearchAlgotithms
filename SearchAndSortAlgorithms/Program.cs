using SearchAndSortAlgorithms.Algorithms;
using SearchAndSortAlgorithms.Problems;

// ---------------------- Search Algorithms ---------------------

var searchAlgorithms = new SearchAlgorithms();
var searchAlgorithmsProblems = new SearchAlgorithmsProblems();
var intArray = new int[10] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
var cyclicSequenceA = new int[16] { 14, 16, 19, 21, 23, 27, 1, 3, 4, 5, 7, 8, 9, 11, 12, 13 };
var cyclicSequenceB = new int[9] { 14, 16, 18, 2, 4, 6, 8, 10, 12 };

// Linear Search.
Console.WriteLine(searchAlgorithms.LinearSearch(intArray, 4)); // False.
Console.WriteLine(searchAlgorithms.LinearSearch(intArray, 19)); // True

// Binary Search.
Console.WriteLine(searchAlgorithms.BinarySearch(intArray, 4)); // False.
Console.WriteLine(searchAlgorithms.BinarySearch(intArray, 19)); // True

Console.WriteLine(searchAlgorithmsProblems.CyclicSequence(cyclicSequenceA)); //6
Console.WriteLine(searchAlgorithmsProblems.CyclicSequence(cyclicSequenceB)); //3
