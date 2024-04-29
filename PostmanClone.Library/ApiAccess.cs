using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace PostmanClone.Library;

public class ApiAccess
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url)
    {
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
            var jsonPretty = JsonSerializer.Serialize(jsonElement,
                new JsonSerializerOptions { WriteIndented = true });
            return jsonPretty;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }
}
