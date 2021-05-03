using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Melhor_Combustível
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                funcoes fnc = new funcoes();
                float valGas, valEtn;
                bool opcao;
                valEtn = float.Parse(valEtanol.Text);
                valGas = float.Parse(valGasolina.Text);
                opcao = rdbPadrao.Checked ? false : true;

                float valCalculado = fnc.fnc_calcular(valGas, opcao);
                string br = Environment.NewLine;
                if (valCalculado > 0)
                {
                    if (valCalculado > valEtn)
                        MessageBox.Show("O preço por litro da gasolina é MAIOR que o cálculo de consumo do etanol." + br + br + "Em termos financeiros, é mais rentável optar pelo Etanol!", "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else if (valCalculado < valEtn)
                        MessageBox.Show("O preço por litro da gasolina é MENOR que o cálculo de consumo do etanol." + br + br + "Em termos financeiros, é mais rentável optar pela Gasolina!", "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                        MessageBox.Show("O preço por litro da gasolina é IGUAL que o cálculo de consumo do etanol.", "Retorno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("Algum valor não foi preenchido corretamente no consumo. Favor se atentar ao preenchimento.", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                string br = Environment.NewLine;
                MessageBox.Show("Ocorreu um erro:" + br + br + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
