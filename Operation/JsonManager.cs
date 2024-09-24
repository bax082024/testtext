using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class JsonManager
{
    public static void WriteJsonToFile(string filePath, List<Person> people)
    {
        string jsonData = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(filePath, jsonData);
        Console.WriteLine("JSON data written to file.");
    }

    public static List<Person> ReadJsonFromFile(string filePath)
    {
        if (File.Exists(filePath))
        {
            string jsonData = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Person>>(jsonData);
        }
        else
        {
            Console.WriteLine("JSON file does not exist.");
            return new List<Person>();
        }
    }
}
