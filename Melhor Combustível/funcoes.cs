using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melhor_Combustível
{
    class funcoes
    {
        float valGasolina = 0, consEtanol, consGasolina = 0;
        public float fnc_calcular(float gasolina, bool opcao)
        {
            float porcentagem = 0.7f;
            try
            {
                valGasolina = gasolina;
                if (opcao)
                {
                    frmConsumo consumo = new frmConsumo();
                    consumo.ShowDialog();
                    if (consumo.DialogResult == System.Windows.Forms.DialogResult.OK)
                    {

                        consEtanol = consumo.consEtanol;
                        consGasolina = consumo.consGasolina;
                    }
                    consumo.Dispose();
                    if(consEtanol == 0 || consGasolina == 0)
                    {
                        porcentagem = -1;
                    }
                    else
                    {
                        porcentagem = consEtanol / consGasolina;
                    }
                }

                float calculo = valGasolina * porcentagem;
                return calculo;
            }
            catch(Exception e)
            {
                return -0.1f;
            }
        }
    }
}
