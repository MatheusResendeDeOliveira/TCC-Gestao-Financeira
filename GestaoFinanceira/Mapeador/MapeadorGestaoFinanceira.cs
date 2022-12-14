using FirebirdSql.Data.FirebirdClient;
using GestaoFinanceira.Gerenciamento;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoFinanceira.Mapeador;

public class MapeadorGestaoFinanceira
{
    private static readonly MapeadorGestaoFinanceira instanciaFireBird = new();

    private MapeadorGestaoFinanceira() { }

    public static MapeadorGestaoFinanceira getInstancia()
    {
        return instanciaFireBird;
    }

    public FbConnection getConexao()
    {
        string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
        return new FbConnection(conn);
    }

    public List<Movimentacoes> BuscarLancamentos(int mes, int ano)
    {
        using (DbConnection conexao = getInstancia().getConexao())
        {
            try
            {
                conexao.Open();
                List<Movimentacoes> movimentacoes = new();
                using DbCommand cmd = conexao.CreateCommand();
                cmd.CommandText =
                    $@"SELECT DATAGASTOS, TIPOMOVIMENTACAO, VALORES, DESCRICAO FROM TBDADOS
                      WHERE MES = {mes} AND ANO ={ano}";

                using DbDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Movimentacoes movimentacao = new();
                    movimentacao.Valores = dr.GetInt16("valores");
                    movimentacao.DataLancamento = dr.GetDateTime("DATAGASTOS");
                    movimentacao.Descricao = dr.GetString("DESCRICAO");
                    Movimentacao tipoMovimentacao = (Movimentacao)dr.GetInt16("TIPOMOVIMENTACAO");
                    movimentacao.TipoDeMovimentacao = tipoMovimentacao.ToString();
                    movimentacoes.Add(movimentacao);
                }

                return movimentacoes;
            }
            catch (FbException fbex)
            {
                MessageBox.Show(fbex.Message, "Erro");
                return new List<Movimentacoes>();
            }
            finally
            {
                conexao.Close();
            }
        }
    }

    public void InserirLancamento(Movimentacoes movimentacao)
    {
        using (DbConnection conexao = getInstancia().getConexao())
        {
            try
            {
                conexao.Open();
                using DbCommand cmd = conexao.CreateCommand();
                cmd.CommandText =
                    $@"INSERT INTO TBDADOS(DATAGASTOS, TIPOMOVIMENTACAO, VALORES, DESCRICAO, MES, ANO) 
                       VALUES ('{movimentacao.DataLancamento.Year}-{movimentacao.DataLancamento.Month}-{movimentacao.DataLancamento.Day}',
                        {movimentacao.TipoDeMovimentacao}, {movimentacao.Valores}, '{movimentacao.Descricao}', {movimentacao.DataLancamento.Month}, {movimentacao.DataLancamento.Year})";

                cmd.ExecuteNonQuery();
            }
            catch (FbException fbex)
            {
                MessageBox.Show(fbex.Message, "Erro");
                return;
            }
            finally
            {
                conexao.Close();
                MessageBox.Show("Lancamento salvo com sucesso!");
            }
        }
    }

    public Salario InformacoesTela()
    {
        using (DbConnection conexao = getInstancia().getConexao())
        {
            try
            {
                conexao.Open();
                using DbCommand cmd = conexao.CreateCommand();
                cmd.CommandText = "SELECT * FROM TBSALARIO";

                using DbDataReader dr = cmd.ExecuteReader();

                Salario salario = new();

                while (dr.Read())
                {
                    salario.salario = dr.GetFloat("SALARIO");
                }

                return salario;
            }
            catch (FbException fbex)
            {
                MessageBox.Show("Erro de acesso ao MySQL : " + fbex.Message, "Erro");
                return new Salario();
            }
            finally
            {
                conexao.Close();
            }
        }
    }

    public void InserirSalario(double salario)
    {
        using (DbConnection conexao = getInstancia().getConexao())
        {
            try
            {
                conexao.Open();
                using DbCommand cmd = conexao.CreateCommand();
                cmd.CommandText = "DELETE FROM TBSALARIO";
                cmd.ExecuteNonQuery();

                cmd.CommandText = $@"INSERT INTO TBSALARIO(SALARIO) VALUES({salario})";
                cmd.ExecuteNonQuery();

                MessageBox.Show("Salario atualizado com sucesso!");
            }
            catch (FbException fbex)
            {
                MessageBox.Show(fbex.Message, "Erro");
                return;
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}