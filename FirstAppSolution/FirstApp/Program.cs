using FirstApp.Models;

Console.WriteLine("Starting Up The Api");
var builder = WebApplication.CreateBuilder(args);
//Configuration for the API Will go here.

Console.WriteLine("About to Start the Api");
var app = builder.Build();
//GET /sayhi
app.MapGet("/sayhi", () =>
{
    Console.WriteLine("Got a request!");
    return Results.Ok("Yep! Hello, Good to See You");
});


app.MapGet("/status", () =>
{
    var response = new StatusResponseModel(DateTime.Now, "looks Good", "Operating Normally");
    return Results.Ok(response);
});

app
    
app.Run(); //Blocking call - this will  start server and run FOREVER ( until we kill it!)
Console.WriteLine("Api is going down. Goodbye...");

