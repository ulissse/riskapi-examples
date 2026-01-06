using System.Text;
using System.Text.Json;

var apiKey = Environment.GetEnvironmentVariable("YOUR_API_KEY");
if (string.IsNullOrWhiteSpace(apiKey))
{
    Console.Error.WriteLine("Missing env var: YOUR_API_KEY");
    return;
}

using var http = new HttpClient();
http.DefaultRequestHeaders.Add("X-API-Key", apiKey);

var payload = JsonSerializer.Serialize(new { url = "https://example.com" });
var res = await http.PostAsync(
    "https://riskapi.analyses-web.com/risk-score",
    new StringContent(payload, Encoding.UTF8, "application/json")
);

Console.WriteLine(await res.Content.ReadAsStringAsync());
