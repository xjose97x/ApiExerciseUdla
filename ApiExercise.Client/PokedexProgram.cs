using ApiExercise.Client.Services;

namespace ApiExercise.Client;

public static class PokedexProgram
{
  public static async Task RunAsync()
  {
    HttpClient httpClient = new();
    PokedexApiService pokedexApiService = new(httpClient);

    while(true)
    {
      Console.WriteLine("Introduce el id del pokemon que quieres ver:  (del 1 al 151. 0 para salir)");
      var id = Console.ReadLine().Trim();
      if (id == "0")
      {
        break;
      }
      if (int.TryParse(id, out int idInt))
      {
        var pokemon = await pokedexApiService.GetPokedexEntryAsync(idInt);
        Console.WriteLine(pokemon.SayHello());
      }
      else
      {
        Console.WriteLine("El id introducido no es válido");
      }
    }
  }
}
