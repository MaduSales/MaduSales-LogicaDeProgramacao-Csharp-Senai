using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class FrmExemplo2 : Form
    {
        public FrmExemplo2()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double valor1 = 0, valor2 = 0, total = 0;

            valor1 = Convert.ToDouble(txtValor1.Text);
            valor2 = Convert.ToDouble(txtValor2.Text);

            switch (cbbOperacao.SelectedIndex)
            {
                case 0:
                    total = valor1 + valor2;
                    break;

                case 1:
                    total = valor1 - valor2;
                    break;

                case 2: 
                    total = valor1 * valor2;
                    break;

                case 3:
                    total = valor1 / valor2;
                    break;
            }

            txtTotal.Text = total.ToString();
        }
    }
}
