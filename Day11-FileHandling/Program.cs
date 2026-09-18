// Day 11: File Handling
// File handling ka use text file mein data save aur read karne ke liye hota hai.

string filePath = "student.txt";
string studentDetails = "Name: Dinesh\nCourse: C#\nStatus: Learning";

File.WriteAllText(filePath, studentDetails);

string savedDetails = File.ReadAllText(filePath);

Console.WriteLine("Saved student details:");
Console.WriteLine(savedDetails);

Console.WriteLine($"File exists: {File.Exists(filePath)}");
