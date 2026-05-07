using BotPromocoes;
using BotPromocoes.Models;
using BotPromocoes.Services;
using BotPromocoes.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHttpClient<IBuscadorPromocoes, BuscadorMercadoLivre>();
builder.Services.AddHostedService<Worker>();


var host = builder.Build();
host.Run();
