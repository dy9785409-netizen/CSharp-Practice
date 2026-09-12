// Day 05: Methods
// Method ka use kisi kaam ko ek jagah define karke zaroorat par call karne ke liye hota hai.

string studentName = "Dinesh";
int firstNumber = 12;
int secondNumber = 8;

GreetStudent(studentName);

int total = AddNumbers(firstNumber, secondNumber);
Console.WriteLine($"Total: {total}");

DisplayResult(total);

// Ye method student ko greeting message dikhata hai.
static void GreetStudent(string name)
{
    Console.WriteLine($"Hello, {name}!");
}

// Ye method do numbers ko add karke result return karta hai.
static int AddNumbers(int numberOne, int numberTwo)
{
    return numberOne + numberTwo;
}

// Ye method result ke basis par simple message print karta hai.
static void DisplayResult(int value)
{
    if (value >= 20)
    {
        Console.WriteLine("Result is 20 or more.");
    }
    else
    {
        Console.WriteLine("Result is less than 20.");
    }
}
