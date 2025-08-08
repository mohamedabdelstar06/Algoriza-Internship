List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var result = numbers.Where(n % 2 = 0);

Console.WriteLine(result);