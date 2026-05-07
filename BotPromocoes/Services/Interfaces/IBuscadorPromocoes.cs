using BotPromocoes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotPromocoes.Services.Interfaces
{
    interface IBuscadorPromocoes
    {
        public Task<List<Promocao>> BuscarPromocoes();
    }
}
