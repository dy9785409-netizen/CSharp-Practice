// Day 09: LINQ
// LINQ ka use collection se zaroori data filter aur sort karne ke liye hota hai.

using System.Linq;

List<int> marks = new List<int> { 45, 78, 32, 90, 66 };

IEnumerable<int> passedMarks = marks
    .Where(mark => mark >= 40)
    .OrderByDescending(mark => mark);

Console.WriteLine("Passed marks from highest to lowest:");

foreach (int mark in passedMarks)
{
    Console.WriteLine(mark);
}

int highestMark = marks.Max();
Console.WriteLine($"Highest mark: {highestMark}");
