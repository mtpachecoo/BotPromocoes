using BotPromocoes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotPromocoes.Services.Interfaces
{
    interface IPublicadorWhatsApp
    {   
        public Task PublicarGrupo(List<Promocao> promocoes);

    }
}
