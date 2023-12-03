using System.Text.Json;
using ApiExercise.Common;

namespace ApiExercise.Client.Services;

public class PokedexApiService
{
    private readonly HttpClient _httpClient;

    public PokedexApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("http://localhost:5153");
    }

    public async Task<PokedexEntry> GetPokedexEntryAsync(int id)
    {
        var response = await _httpClient.GetAsync($"/{id}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var entry = JsonSerializer.Deserialize<PokedexEntry>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        return entry;
    }
}
