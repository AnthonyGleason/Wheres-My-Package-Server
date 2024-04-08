using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/",()=>
{
    return "You have successfully connected to the Where's My Package API";
});

app.Run();