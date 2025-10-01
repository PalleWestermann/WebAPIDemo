

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.

//var app = builder.Build();

//// Configure the HTTP request pipeline.

//app.UseHttpsRedirection();

//// Routing
//// https://localhost:7134/shirts

//// "/shirts"
//app.MapGet("/shirts", () =>
//{
//    return "Reading all the shirts";
//});

//app.MapGet("/shirts/{id}", (int id) =>
//{
//    return $"Reading shirt with ID: {id}";
//});

//app.MapPost("/shirts", () =>
//{
//    return "Creating a shirt."; // Normally an argument with a shirt would be there.
//});

//app.MapPut("/shirts/{id}", (int id) =>
//{
//    return $"Updating shirt with ID: {id}";
//});

//app.MapDelete("/shirts/{id}", (int id) =>
//{
//    return $"Deleting shirt with ID: {id}";
//});

//app.Run();

