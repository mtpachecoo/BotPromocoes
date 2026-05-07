using BotPromocoes.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BotPromocoes.Services.Interfaces
{
    public interface IPublicadorWhatsApp
    {   
        public Task PublicarGrupo(List<Promocao> promocoes);

    }
}
