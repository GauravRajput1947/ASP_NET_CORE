var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Welcome to Asp.net core series");
//});//these are middleWare(Call back function)
//using of app run method

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Welcome to Gaurav Chauhan Vlogs\n");
    await next(context);
});

app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Welcome to Asp.net core series");
    await next(context);
});

app.Run(); //from this line sever start and host on our application
