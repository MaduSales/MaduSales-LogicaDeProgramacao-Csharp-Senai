using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            operacao = btnSoma.Text; ;
        }

        private void btnSubtrc_Click(object sender, EventArgs e)
        {
            operacao = btnSubtrc.Text; ;
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operacao = btnMult.Text;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            operacao = btnDivisao.Text;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double v1, v2, total;

            v1 = Convert.ToDouble(txtValor1.Text);
            v2 = Convert.ToDouble(txtValor1.Text);

            if (operacao.Equals("+"))
            {
                total = v1 + v2;
            }
            else if (operacao.Equals("-"))
            {
                total = v1 - v2;
            }
            else if (operacao.Equals("x"))
            {
                total = v1 * v2;
            }
            else
            {
                total = v1 / v2;
            }

            txtResultado.Text = total.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
