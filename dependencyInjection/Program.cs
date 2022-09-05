using dependencyInjection.Models;
using dependencyInjection.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// AddTransient
//      Created each time they are requested, used for lightweight and stateless services
//      Create a new instance each time
// AddScope
//      Created once per request, if the client call a new instance this use the same 
//      object created, but if a new request (another client) calls it, it will generete a
//      new object reference
// AddSingleton
//      Created the first time they are requested, end everything is going to use the same instance
//      it includes another calls, is the same object reference to all the calls 
builder.Services.AddTransient<IMessage, PhoneMessage>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
