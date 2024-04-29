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

    public async Task<string> CallApiAsync(
        string url, 
        bool formatOutput = true,
        HttpAction action = HttpAction.GET)
    {
        var response = await client.GetAsync(url);

        if (response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            if (formatOutput)
            {
                var jsonElement = JsonSerializer.Deserialize<JsonElement>(json);
                json = JsonSerializer.Serialize(jsonElement,
                    new JsonSerializerOptions { WriteIndented = true });
            }
            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }

    public bool IsValidUrl(string url)
    {
        if(string.IsNullOrEmpty(url)) return false;

        // Step 1; Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) 
        // Parse the url and create uri and returns true
        // Step 2: Checks if url is https or not
        return Uri.TryCreate(url, UriKind.Absolute, out Uri uriOutput) &&
            (uriOutput.Scheme == Uri.UriSchemeHttps);
    }
}
