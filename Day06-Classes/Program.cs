// Day 06: Classes
// Class ka use related data aur behavior ko ek unit mein organize karne ke liye hota hai.

Student student = new Student
{
    Name = "Dinesh",
    Course = "C#",
    IsEnrolled = true
};

student.DisplayDetails();

class Student
{
    public string Name { get; set; } = string.Empty;
    public string Course { get; set; } = string.Empty;
    public bool IsEnrolled { get; set; }

    public void DisplayDetails()
    {
        Console.WriteLine($"Student: {Name}");
        Console.WriteLine($"Course: {Course}");
        Console.WriteLine($"Enrolled: {IsEnrolled}");
    }
}
