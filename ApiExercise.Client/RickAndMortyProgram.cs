using ApiExercise.Client.Services;

namespace ApiExercise.Client;

public static class RickAndMortyProgram
{
  public static async Task RunAsync()
  {
    HttpClient httpClient = new();
    RickAndMortyApiService rickAndMortyApiService = new(httpClient);

    while(true)
    {
      Console.WriteLine("Introduce el id del personaje de Rick and Morty que quieres ver:  (del 1 al 826. 0 para salir)");
      var id = Console.ReadLine().Trim();
      if (id == "0")
      {
        break;
      }
      if (int.TryParse(id, out int idInt))
      {
        var character = await rickAndMortyApiService.GetCharacterAsync(idInt);
        Console.WriteLine(character.SayHello());
      }
      else
      {
        Console.WriteLine("El id introducido no es válido");
      }
    }
  }
}
