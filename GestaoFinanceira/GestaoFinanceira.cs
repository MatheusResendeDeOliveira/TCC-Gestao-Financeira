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
        if (!PodeAdicionarLancamento())
        {
            MessageBox.Show("Algum dos campos não foi preenchido!");
            return;
        }

        Movimentacoes lancamento = new Movimentacoes();
        lancamento.DataLancamento = Convert.ToDateTime(msktxtDataLancamento.Text);
        lancamento.TipoDeMovimentacao = cbbTipoDeMovimentacao.SelectedIndex.ToString();
        lancamento.Valores = Convert.ToDouble(txValorLancamento.Text);
        lancamento.Descricao = txDescricao.Text;

        mapeador.InserirLancamento(lancamento);
        CarregarLancamentosComFiltro(lancamento.DataLancamento.Month, lancamento.DataLancamento.Year);
        LimparCampos();
    }

    public void LimparCampos()
    {
        msktxtDataLancamento.Text = "";
        txValorLancamento.Text = "";
        txDescricao.Text = "";
    }

    private bool PodeAdicionarLancamento() =>
        msktxtDataLancamento.Text == ""
            ? false
            : txValorLancamento.Text == ""
                ? false
                : txDescricao.Text == ""
                    ? false
                    : true;

    private void btnNovoTipoDeMovimentacao_Click(object sender, EventArgs e)
    {
        frmTipoDeLancamento cadastro = new();
        cadastro.ShowDialog();
    }

    private void btnFiltrar_Click(object sender, EventArgs e)
    {
        if (txAno.Text == "")
        {
            MessageBox.Show("O campo ano é de preenchimento obrigatório.");
            return;
        }

        int ano = Convert.ToInt16(txAno.Text);
        int mes = cbbMes.SelectedIndex + 1;
        CarregarLancamentosComFiltro(mes, ano);
    }

    public void CarregarLancamentosComFiltro(int mes, int ano)
    {
        List<Movimentacoes> lancamentos = mapeador.BuscarLancamentos(mes, ano);
        this.dgvLancamentos.DataSource = lancamentos;

        foreach (DataGridViewColumn column in dgvLancamentos.Columns)
        {
            if (column.DataPropertyName == "DataLancamento")
                column.HeaderText = "Data de Lancamento";

            if (column.DataPropertyName == "TipoDeMovimentacao")
                column.HeaderText = "Movimentação";

            if (column.DataPropertyName == "Valores")
                column.HeaderText = "Valor gasto";

            if (column.DataPropertyName == "Descricao")
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        double despesas = 0;
        double salario = Convert.ToDouble(txtSalario.Text);

        foreach (Movimentacoes movimentacoes in lancamentos)
        {
            despesas += movimentacoes.Valores;
            salario -= movimentacoes.Valores;
        }

        lblDespesasMensais.Text = "R$ " + despesas.ToString();
        lblSalarioRestante.Text = "R$ " + salario.ToString();
    }

    private void btnSalvarSalario_Click(object sender, EventArgs e)
    {
        double salario = Convert.ToDouble(txtInsiraSalario.Text);
        mapeador.InserirSalario(salario);
        CarregaInformacoes();
        txtInsiraSalario.Text = "";
    }
}