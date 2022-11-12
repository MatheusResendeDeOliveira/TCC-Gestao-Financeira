using GestaoFinanceira.Campos;
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
        AplicarMascara(txtInsiraSalarioBruto);
        CarregaInformacoes();
    }

    public void CarregaInformacoes()
    {
        this.dataGridView1.DataSource = mapeador.BuscarLancamentos();
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
}