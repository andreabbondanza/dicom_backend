using System.Text.Json;
using dicom_backend.src.endpoints;
using dicom_backend.src.endpoints.common;
using dicom_backend.src.middlewares;
using dicom_backend.src.settings;
using Microsoft.Extensions.Configuration;


var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var myAppSettings = builder.Configuration.Get<DicomSettings>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

if(!app.Environment.IsDevelopment()) 
    app.Use(Middlewares.ApiKeyCheck);

app.RegisterEndpoints(new DicomV1Endpoints("v1","badge")).Run();
