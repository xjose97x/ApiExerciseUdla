using System.Text.Json;
using ApiExercise.Common;

namespace ApiExercise.Server.Services;

public class PokedexService
{
  private readonly IEnumerable<PokedexEntry> _pokedexEntries;

  public PokedexService()
  {
    var pokedexJson = File.ReadAllText("Assets/pokedex.json");
    _pokedexEntries = JsonSerializer.Deserialize<IEnumerable<PokedexEntry>>(pokedexJson, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
  }

  public PokedexEntry GetPokedexEntry(int id)
  {
    return _pokedexEntries.FirstOrDefault(x => x.PokedexNumber == id);
  }
}
