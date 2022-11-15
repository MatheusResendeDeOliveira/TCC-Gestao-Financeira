using GestaoFinanceira.Campos;
using GestaoFinanceira.Gerenciamento;
using GestaoFinanceira.Mapeador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoFinanceira;

public partial class GestaoFinanceira : Form
{
    readonly TratamentoDeCampos _MascaraDinheiro = new();
    BindingSource bs = new();
    MapeadorGestaoFinanceira mapeador = MapeadorGestaoFinanceira.getInstancia();

    public GestaoFinanceira()
    {
        InitializeComponent();
        AplicarMascara(txtInsiraSalario);
        CarregaInformacoes();
    }

    public void CarregaInformacoes()
    {
        Enumerador enumerador = new();

        this.cbbTipoDeMovimentacao.DataSource = enumerador.TipoDeMovimentacao();
        this.cbbMes.DataSource = enumerador.Meses();
        Salario salario = mapeador.InformacoesTela();
        txtSalario.Text = salario.salario.ToString();
    }

    public void AplicarMascara(TextBox txt)
    {
        txt.KeyPress += _MascaraDinheiro.ApenasValorNumerico;
    }

    private void btnAdicionarLancamento_Click(object sender, EventArgs e)
    {
        MapeadorGestaoFinanceira a = MapeadorGestaoFinanceira.getInstancia();
        bs.DataSource = msktxtDataLancamento.Text;
        dataGridView1.DataSource = bs;
    }

    private void btnNovoTipoDeMovimentacao_Click(object sender, EventArgs e)
    {
        frmTipoDeLancamento cadastro = new();
        cadastro.ShowDialog();
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
        List<Movimentacoes> lancamentos = mapeador.BuscarLancamentos();

        this.dataGridView1.DataSource = lancamentos;
    }
}