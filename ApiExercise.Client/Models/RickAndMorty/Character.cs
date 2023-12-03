using ApiExercise.Client.Models.RickAndMorty;

namespace ApiExercise.Client.Models.Character;

public class Character
{
  //Character from Rick and Morty API
  public int Id { get; set; }
  public string Name { get; set; }
  public string Status { get; set; }
  public string Species { get; set; }
  public string Type { get; set; }
  public string Gender { get; set; }
  public Location Origin { get; set; }
  public Location Location { get; set; }
  public string Image { get; set; }
  public IEnumerable<string> Episode { get; set; }
  public string Url { get; set; }
  public DateTimeOffset Created { get; set; }


  public string SayHello()
  {
    return $@"Hola mi nombre es {Name} y soy de la especie ""{Species}"". He aparecido en {Episode.Count()} episodios.
Actualmente mi estado vital es ""{Status}"". Yo nací en {Origin.Name} y actualmente me encuentro en {Location.Name}.
Para ver una foto mia puedes ir a {Image}.";
  }
}
