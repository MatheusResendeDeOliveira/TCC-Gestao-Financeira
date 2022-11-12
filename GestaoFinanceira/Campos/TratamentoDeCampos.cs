using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace GestaoFinanceira.Campos;

public class TratamentoDeCampos
{
    public void ApenasValorNumerico(object sender, KeyPressEventArgs e)
    {
        TextBox txt = (TextBox)sender;
        if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
        {
            if (e.KeyChar == ',')
            {
                e.Handled = (txt.Text.Contains(','));
            }
            else
                e.Handled = true;
        }
    }
}
