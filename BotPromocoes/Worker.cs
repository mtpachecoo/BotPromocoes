using BotPromocoes.Models;
using BotPromocoes.Services;
using BotPromocoes.Services.Interfaces;

namespace BotPromocoes
{
    public class Worker(ILogger<Worker> logger, IBuscadorPromocoes buscadorPromocoes) : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {

                logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                await buscadorPromocoes.BuscarPromocoes();

                await Task.Delay(1000, stoppingToken);
            }

                
        }
    }
}
