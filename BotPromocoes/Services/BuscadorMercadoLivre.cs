using BotPromocoes.Models;
using BotPromocoes.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotPromocoes.Services
{
    internal class BuscadorMercadoLivre : IBuscadorPromocoes
    {
        private readonly HttpClient _client;

        public BuscadorMercadoLivre(HttpClient client)
        {
            _client = client;
        }
        public async Task<List<Promocao>> BuscarPromocoes()
        {
            var json = await _client.GetStringAsync(
                "https://api.mercadolibre.com/sites/MLB/search?q=smartphone&sort=price_asc&limit=10");

            Console.WriteLine(json);

            return new List<Promocao>();
        }
    }
}
