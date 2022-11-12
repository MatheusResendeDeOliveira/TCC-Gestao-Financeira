using System.Data.Common;

namespace GestaoFinanceira.Mapeador;
public interface IDBHelper
{
    DbConnection CrieConexao(string? charset = null);
}