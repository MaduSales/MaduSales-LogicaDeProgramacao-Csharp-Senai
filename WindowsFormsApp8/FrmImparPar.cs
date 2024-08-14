using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
    public partial class FrmImparPar : Form
    {
        public FrmImparPar()
        {
            InitializeComponent();
        }

        private void btnDescobrir_Click(object sender, EventArgs e)
        {
            int numero = 0;

            numero = Convert.ToInt32(txtNumero.Text);

            if (numero % 2 == 0)
            {
                txtResultado.Text = ($"O número {numero} é ímpar").ToString();
            }
            else
            {
                txtResultado.Text = ($"O número {numero} é par").ToString();
            }
        }
    }
}
