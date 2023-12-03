using ApiExercise.Server.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<PokedexService>();

var app = builder.Build();


app.UseHttpsRedirection();



app.MapGet("/{id}", (int id, PokedexService pokedexService) =>
{
  var pokedexEntry = pokedexService.GetPokedexEntry(id);
  if (pokedexEntry == null)
  {
    return Results.NotFound();
  }
  return Results.Ok(pokedexEntry);
});

app.Run();
