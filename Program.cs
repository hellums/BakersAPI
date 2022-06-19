using Microsoft.AspNetCore.Builder;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.UseHttpsRedirection();

app.MapGet("/type/{breadType}/weight/{weight}", (string breadType, int weight) =>
{
    int mass = weight;
    float waterPercent;
    float yeastPercent;
    float saltPercent;
    float sugarPercent;
    float fatPercent;

    switch (breadType)
    {
        case "sandwich":
            waterPercent = 63.0F;
            yeastPercent = 1.2F;
            saltPercent = 1.0F;
            sugarPercent = 3.5F;
            fatPercent = 8.0F;
            break;
        case "focaccia":
            waterPercent = 90.0F;
            yeastPercent = .75F;
            saltPercent = 3.5F;
            sugarPercent = 0.0F;
            fatPercent = 9.4F;
            break;
        case "ciabatta":
            waterPercent = 82.0F;
            yeastPercent = 0.4F;
            saltPercent = 2.2F;
            sugarPercent = 0.0F;
            fatPercent = 0.0F;
            break;
        case "french":
            waterPercent = 66.0F;
            yeastPercent = 1.25F;
            saltPercent = 2.0F;
            sugarPercent = 0.0F;
            fatPercent = 0.0F;
            break;
        case "buns":
            waterPercent = 66.0F;
            yeastPercent = 2.0F;
            saltPercent = 1.5F;
            sugarPercent = 2.5F;
            fatPercent = 5.0F;
            break;
        case "pizza":
            waterPercent = 59.0F;
            yeastPercent = 1.25F;
            saltPercent = 2.0F;
            sugarPercent = 0.0F;
            fatPercent = 0.0F;
            break;
        default:
            waterPercent = 65.0F;
            yeastPercent = 1.2F;
            saltPercent = 2.0F;
            sugarPercent = 2.0F;
            fatPercent = 2.0F;
            break;
    }

    float TotalPercent = 1 + (waterPercent + yeastPercent + saltPercent + sugarPercent + fatPercent) / 100;
    float Flour = (mass / TotalPercent);

    var bread = new Dough
        (
            (string) breadType,
            (int) mass,
            (int) Flour,
            (int) ( Flour * (waterPercent / 100) ),
            (int) ( Flour * (yeastPercent / 100) ),
            (int) ( Flour * (saltPercent / 100) ),
            (int) ( Flour * (sugarPercent / 100) ),
            (int) ( Flour * (fatPercent / 100) )
        );
    return (bread);

});

app.MapGet("/api", () =>
{
    return("Instructions: Replace /api in URL with /type/ciabatta/weight/1000 (other types: sandwich, focaccia, french, pizza, or buns; weight is in grams)");
});

app.Run();

internal record Dough(string Type, int Grams, int Flour, int Water, int Yeast, int Salt, int Sugar, int Oil) 
{ 
}
