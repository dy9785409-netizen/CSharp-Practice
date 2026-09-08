// Day 01: Variables aur data types
// Variable ek naam wali jagah hai jisme value store karte hain.
string studentName = "Dinesh";
int age = 23; // Example age
decimal courseFee = 15000.00m;
bool isEnrolled = true;
double marks = 78.5;

// Comparison ka result true ya false hota hai.
bool hasPassed = marks >= 40;

Console.WriteLine($"Student: {studentName}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Course fee: {courseFee:F2}");
Console.WriteLine($"Enrolled: {isEnrolled}");
Console.WriteLine($"Marks: {marks}");
Console.WriteLine($"Result: {(hasPassed ? "Pass" : "Fail")}");
