using Backend_practice;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/brewery", () => new Repository().GetBreweries());
app.MapGet("/brewery/{id}", (int id) =>
{
    //create new object
    var brewery = new Repository().GetBrewery(id);//method to get a Brewery

    //ternary operator
    return brewery == null ? Results.NotFound() : Results.Ok(brewery);//like if else
});

app.Run();
