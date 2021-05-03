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
    public partial class frmConsumo : Form
    {
        public float consEtanol { get; set; }
        public float consGasolina { get; set; }
        public frmConsumo()
        {
            InitializeComponent();
        }

        public void avancar()
        {
            try
            {
                consEtanol = float.Parse(txtConsEtanol.Text);
                consGasolina = float.Parse(txtConsGasolina.Text);
                DialogResult = DialogResult.OK;
            }catch(Exception e)
            {
                DialogResult = DialogResult.Abort;
            }
            
            this.Close();
        }

        private void btnProx_Click(object sender, EventArgs e)
        {
            avancar();
        }
    }
}
