using ApiExercise.Client;

Console.WriteLine("Bienvenido a la aplicacion cliente de prueba de APIs de Miguel Brito y José I. Escudero");

while(true)
{
  Console.WriteLine("Introduce el número de la API que quieres probar: (1 para Rick and Morty, 2 para Pokemon, 0 para salir)");
  var apiIndex = Console.ReadLine().Trim();

  if (apiIndex == "0")
  {
    break;
  }

  if (int.TryParse(apiIndex, out int apiIndexInt))
  {
    switch (apiIndexInt)
    {
      case 1:
        await RickAndMortyProgram.RunAsync();
        break;
      case 2:
        await PokedexProgram.RunAsync();
        break;
      default:
        Console.WriteLine("El número introducido no es válido");
        break;
    }
  }
  else
  {
    Console.WriteLine("El número introducido no es válido");
  }
}

Console.WriteLine("Gracias por usar la aplicación cliente de prueba de APIs de Miguel Brito y José I. Escudero");
