// Day 07: Constructors
// Constructor object create hote hi initial values set karne ke kaam aata hai.

Student student = new Student("Dinesh", "C#");
student.DisplayDetails();

class Student
{
    public string Name { get; set; }
    public string Course { get; set; }

    public Student(string name, string course)
    {
        Name = name;
        Course = course;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Student: {Name}");
        Console.WriteLine($"Course: {Course}");
    }
}
