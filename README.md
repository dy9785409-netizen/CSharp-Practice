# CSharp-Practice

C# aur .NET seekhne ke liye practice examples, Roman Hindi explanations aur exercises.

## Day 01 — Variables aur data types

Example: [Program.cs](Day01-Variables/Program.cs)

### Run kaise karein

.NET 8 SDK ya compatible newer SDK installed hona chahiye.

```bash
git clone https://github.com/dy9785409-netizen/CSharp-Practice.git
cd CSharp-Practice
dotnet run --project Day01-Variables
```

Visual Studio mein Day01-Variables/Day01-Variables.csproj open karke bhi run kar sakte hain.

### Code samjho

- `string studentName`: student ka naam text mein store karta hai.
- `int age`: poora number store karta hai.
- `decimal courseFee`: decimal amount store karta hai; literal ke end mein `m` lagta hai.
- `bool isEnrolled`: true ya false store karta hai.
- `double marks`: fractional marks store karta hai.
- `marks >= 40`: condition check karke bool result deta hai.
- `$"...{studentName}..."`: string interpolation se variable ki value text mein aati hai.
- `Console.WriteLine`: console mein output dikhata hai.
- `F2`: number ko do decimal places ke saath format karta hai.
- `condition ? value1 : value2`: condition true ho to value1, otherwise value2.

### Expected output

Decimal separator computer ki culture setting ke according badal sakta hai.

```text
Student: Dinesh
Age: 23
Course fee: 15000.00
Enrolled: True
Marks: 78.5
Result: Pass
```

### Khud practice karo

1. Naam aur age ko apni values se replace karo.
2. Marks 35 karke run karo: Result Fail aana chahiye.
3. Marks 40 karke run karo: Result Pass aana chahiye.
4. Ek string variable courseName add karke print karo.

## Agle topics

Operators, if/else, loops, methods, classes, constructors, collections, LINQ aur exception handling.

Examples ko run karke aur exercises solve karke learning aage badhao.
