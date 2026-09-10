// Day 03: Conditions
// Condition ka use decision lene ke liye hota hai.

int marks = 72;

if (marks >= 90)
{
    Console.WriteLine("Grade: A");
}
else if (marks >= 60)
{
    Console.WriteLine("Grade: B");
}
else if (marks >= 40)
{
    Console.WriteLine("Grade: C");
}
else
{
    Console.WriteLine("Result: Fail");
}

bool hasPassed = marks >= 40;
Console.WriteLine($"Passed: {hasPassed}");
