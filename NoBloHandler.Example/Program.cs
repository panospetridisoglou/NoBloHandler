using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using NoBloHandler.Core;
using NoBloHandler.Core.Abstractions;
using NoBloHandler.Example.BussinessLayer;
using NoBloHandler.Example.DomainLayer;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<CustomersRepository>();
builder.Services.AddNoBloHandlers(Assembly.GetAssembly(typeof(NoBloHandler.Example.BussinessLayer.GetCustomersRequest)));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

var summaries = new[]
{
	"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", async ([FromServices] INoBloHandler<GetCustomersRequest,object> handler) =>
{
	await handler.HandleAsync(new GetCustomersRequest() { },default);

	var forecast = Enumerable.Range(1, 5).Select(index =>
		new WeatherForecast
		(
			DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
			Random.Shared.Next(-20, 55),
			summaries[Random.Shared.Next(summaries.Length)]
		))
		.ToArray();
	return forecast;
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
	public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
