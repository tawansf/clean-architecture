using CleanArc.Api;
using CleanArc.Api.Endpoints;
using CleanArc.Application;
using CleanArc.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services
            .AddApplication()
            .AddPresentation()
            .AddInfrastructure(builder.Configuration);
            
var app = builder.Build();

app.MapUserEndpoints();

app.Run();