using SearchAndSortAlgorithms.Algorithms;

// ---------------------- Search Algorithms ---------------------

var searchAlgorithms = new SearchAlgorithms();
var intArray = new int[10] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

// Linear Search.
Console.WriteLine(searchAlgorithms.LinearSearch(intArray, 4)); // False.
Console.WriteLine(searchAlgorithms.LinearSearch(intArray, 19)); // True
