using System;
using System.Net.Http;
using System.Threading.Tasks;

class ApiManager
{
    public static async Task FetchDataFromApi()
    {
        string url = "https://jsonplaceholder.typicode.com/posts"; // Sample API
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Data from API:");
                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine($"Error: {response.StatusCode}");
            }
        }
    }
}
