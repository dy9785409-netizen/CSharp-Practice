// Day 08: Collections
// Collection ka use multiple values ko ek saath store karne ke liye hota hai.

List<string> courseNames = new List<string>
{
    "C#",
    "ASP.NET Core",
    "SQL Server"
};

Console.WriteLine("Available courses:");

foreach (string courseName in courseNames)
{
    Console.WriteLine(courseName);
}

courseNames.Add("Entity Framework Core");
Console.WriteLine($"Total courses: {courseNames.Count}");

class CourseCatalog
{
    public List<string> Courses { get; set; } = new List<string>();
}
