using System;
using System.IO;

class FileManager
{
    public static void WriteToFile(string filePath, string content)
    {
        File.WriteAllText(filePath, content);
        Console.WriteLine("Data written to file.");
    }

    public static string ReadFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            return File.ReadAllText(filePath);
        }
        else
        {
            Console.WriteLine("File does not exist.");
            return string.Empty;
        }
    }
}
