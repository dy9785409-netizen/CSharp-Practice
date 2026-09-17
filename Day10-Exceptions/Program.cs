// Day 10: Exceptions
// Exception handling ka use unexpected error ko safely handle karne ke liye hota hai.

string userInput = "0";

try
{
    int number = int.Parse(userInput);
    int result = 100 / number;

    Console.WriteLine($"Result: {result}");
}
catch (FormatException)
{
    Console.WriteLine("Please enter a valid number.");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Number ko zero se divide nahi kar sakte.");
}
finally
{
    Console.WriteLine("Program finished.");
}
