using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Oppgave 1 - File Handling
        string filePath = "data.txt";
        FileManager.WriteToFile(filePath, "Hello, this is a sample text written to the file!");
        string content = FileManager.ReadFromFile(filePath);
        Console.WriteLine("File content: ");
        Console.WriteLine(content);

        // Oppgave 2 - JSON Serialization
        string jsonFilePath = "data.json";
        List<Person> people = new List<Person>
        {
            new Person { Name = "John", Age = 30 },
            new Person { Name = "Jane", Age = 25 }
        };
        JsonManager.WriteJsonToFile(jsonFilePath, people);
        List<Person> readPeople = JsonManager.ReadJsonFromFile(jsonFilePath);
        foreach (var person in readPeople)
        {
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }

        // Oppgave 3 - Fetch Data from REST API
        await ApiManager.FetchDataFromApi();
    }
}
