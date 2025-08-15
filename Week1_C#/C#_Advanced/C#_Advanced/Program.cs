using C__Advanced;
// Don’t repeat your sself

int percentage = -10;
if (percentage.IsBetween(0, 100))   //NumberHelpers.IsNumberBetweenRange(percentage,
{
    Console.WriteLine($"Percenyage is valid ");
}
else
{
    Console.WriteLine("Percentage is not valid");
}
//Static method return parameter => this in first parameter



Console.Write("Enter Value:");
var input = Console.ReadLine();

Console.WriteLine(input.RemoveWhiteSpaces().Reverse()); // Method chaining
