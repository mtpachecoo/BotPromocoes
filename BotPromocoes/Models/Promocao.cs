using System;
using System.Collections.Generic;
using System.Text;

namespace BotPromocoes.Models
{
    public class Promocao
    {
        public string NomeProduto { get; init; }
        public decimal PrecoOriginal { get; init; }
        public decimal PrecoComDesconto { get; init; }
        public string LinkProduto { get; init; }
        public int PercentualDeDesconto => (int)((1 - (PrecoComDesconto / PrecoOriginal)) * 100);





    }
}
