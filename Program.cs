using AspNetCore.WebAPI.Repositories;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder(args);

var firebaseUrl = builder.Configuration["Firebase:Url"]
    ?? throw new InvalidOperationException(
        "Firebase URL не найден в User Secrets");

builder.Services.AddSingleton(
    new FirebaseStudentRepository(firebaseUrl));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();

    app.MapScalarApiReference(options =>
    {
        options.Title = "API студентів";
        options.WithTheme(ScalarTheme.DeepSpace);
    });
}

//app.UseHttpsRedirection();

app.MapControllers();

app.Run();