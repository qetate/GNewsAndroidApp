using GNewsAndroidApp.Models;
using Newtonsoft.Json;

namespace GNewsAndroidApp.Services
{
    public class GNewsAPI
    {
        // Method to retrieve news for a specific category
        public async Task<GNews> GetNews(string category)
        {
            // API key for GNews API
            const string API_KEY = "b1b440f036b143e5cee73ca64d2db4a6";

            // Create an instance of HttpClient
            var httpClient = new HttpClient();

            // Send a GET request to the GNews API
            var jsonResponse = await httpClient.GetStringAsync($"https://gnews.io/api/v4/top-headlines?topic={category}&token={API_KEY}&lang=en&country=US&max=10");

            // Deserialize the JSON response into GNews object
            var jsonObjects = JsonConvert.DeserializeObject<GNews>(jsonResponse);

            return jsonObjects;
        }
    }
}