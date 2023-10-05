using System;
using System.Net.Http;

class Program
{
    static void Main()
    {
        try
        {
            // Create an instance of HttpClient
            using (HttpClient client = new HttpClient())
            {
                // Attempt to make a request to a non-existing web resource
                HttpResponseMessage response = client.GetAsync("http://nonexistentwebsite.com").Result;

                // Check if the response status code indicates success (2xx)
                if (response.IsSuccessStatusCode)
                {
                    // Process the response here if needed
                    Console.WriteLine("Request was successful!");
                }
                else
                {
                    // Handle the non-successful response (e.g., display an error message)
                    Console.WriteLine($"Error: {response.StatusCode} - {response.ReasonPhrase}");
                }
            }
        }
        catch (AggregateException aggEx)
        {
            // Handle the aggregate exception and inspect inner exceptions
            foreach (var innerEx in aggEx.InnerExceptions)
            {
                Console.WriteLine($"An error occurred: {innerEx.Message}");
            }
        }
        catch (Exception ex)
        {
            // Handle other exceptions
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        Console.WriteLine("Program completed.");
        Console.ReadKey();
    }
}
