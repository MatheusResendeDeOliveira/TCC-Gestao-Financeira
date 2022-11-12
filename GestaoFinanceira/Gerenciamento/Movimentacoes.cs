using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Gerenciamento
{
    public class Movimentacoes
    {
        public DateTime DataLancamento { get; set; }

        public float Valores { get; set; }

        public string? Descricao { get; set; }
    }
}