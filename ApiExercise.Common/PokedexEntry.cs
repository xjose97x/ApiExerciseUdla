namespace ApiExercise.Common;

public class PokedexEntry
{
  public int PokedexNumber { get; set; }
  public string Name { get; set; }
  public IEnumerable<string> Type { get; set; }

  public string SayHello()
  {
    return $@"Hola mi nombre es {Name} y soy de tipo ""{string.Join(", ", Type)}"".";
  }
}
