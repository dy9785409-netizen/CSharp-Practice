// Day 02: Operators
// Operators ka use calculation aur values compare karne ke liye hota hai.

int firstNumber = 20;
int secondNumber = 6;

int sum = firstNumber + secondNumber;
int difference = firstNumber - secondNumber;
int product = firstNumber * secondNumber;
int quotient = firstNumber / secondNumber;
int remainder = firstNumber % secondNumber;

bool isGreater = firstNumber > secondNumber;
bool isEqual = firstNumber == secondNumber;
bool bothNumbersPositive = firstNumber > 0 && secondNumber > 0;

Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Difference: {difference}");
Console.WriteLine($"Product: {product}");
Console.WriteLine($"Quotient: {quotient}");
Console.WriteLine($"Remainder: {remainder}");
Console.WriteLine($"First number is greater: {isGreater}");
Console.WriteLine($"Numbers are equal: {isEqual}");
Console.WriteLine($"Both numbers are positive: {bothNumbersPositive}");
