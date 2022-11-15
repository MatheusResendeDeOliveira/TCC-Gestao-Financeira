using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Gerenciamento;
public enum Movimentacao
{
    Comida = 1,
    Carro = 2,
    Compras = 3,
    Lazer = 4
}

public enum Mes
{
    Janeiro = 1,
    Fevereiro = 2,
    Março = 3,
    Abril = 4,
    Maio = 5,
    Junho = 6,
    Julho = 7,
    Agosto = 8,
    Setembro = 9,
    Outubro = 10,
    Novembro = 11,
    Dezembro = 12,
}

public class Enumerador
{
    public List<Movimentacao> TipoDeMovimentacao() =>
        new()
        {
            Movimentacao.Comida,
            Movimentacao.Carro,
            Movimentacao.Compras,
            Movimentacao.Lazer
        };

    public List<Mes> Meses() =>
        new()
        {
            Mes.Janeiro,
            Mes.Fevereiro,
            Mes.Março,
            Mes.Abril,
            Mes.Maio,
            Mes.Junho,
            Mes.Julho,
            Mes.Agosto,
            Mes.Setembro,
            Mes.Outubro,
            Mes.Novembro,
            Mes.Dezembro,
        };
}