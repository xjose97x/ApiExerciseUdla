using System.Text.Json;
using ApiExercise.Client.Models.Character;

namespace ApiExercise.Client.Services;

public class RickAndMortyApiService
{
    private readonly HttpClient _httpClient;

    public RickAndMortyApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri("https://rickandmortyapi.com/api/");
    }

    public async Task<Character> GetCharacterAsync(int id)
    {
        var response = await _httpClient.GetAsync($"character/{id}");
        response.EnsureSuccessStatusCode();
        var content = await response.Content.ReadAsStringAsync();
        var character = JsonSerializer.Deserialize<Character>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        return character;
    }
}
