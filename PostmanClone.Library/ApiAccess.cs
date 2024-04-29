using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmanClone.Library;

public class ApiAccess
{
    private readonly HttpClient client = new();

    public async Task<string> CallApiAsync(string url)
    {
        var response = await client.GetAsync(url);

        if(response.IsSuccessStatusCode)
        {
            string json = await response.Content.ReadAsStringAsync();
            return json;
        }
        else
        {
            return $"Error: {response.StatusCode}";
        }
    }
}
