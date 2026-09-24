using System;
using System.IO;

string folderPath = "PracticeFiles";

if (Directory.Exists(folderPath))
{
    string[] files = Directory.GetFiles(folderPath, "*.txt");

    Console.WriteLine($"Total .txt files: {files.Length}");

    foreach (string file in files)
    {
        Console.WriteLine(Path.GetFileName(file));
    }
}
else
{
    Console.WriteLine("PracticeFiles folder does not exist.");
}
