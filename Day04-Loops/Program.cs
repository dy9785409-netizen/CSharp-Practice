// Day 04: Loops
// Loop ka use kisi kaam ko baar-baar repeat karne ke liye hota hai.

Console.WriteLine("For loop:");

for (int number = 1; number <= 5; number++)
{
    Console.WriteLine($"Number: {number}");
}

Console.WriteLine("\nWhile loop:");

int countdown = 3;

while (countdown > 0)
{
    Console.WriteLine($"Countdown: {countdown}");
    countdown--;
}

Console.WriteLine("Start!");
