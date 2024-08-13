using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class FrmCalculadora : Form
    {
        double n1, n2, total;
        

        public FrmCalculadora()
        {
            InitializeComponent();
            txtTotal.ReadOnly = true;
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            total = n1 + n2;

            txtTotal.Text = total.ToString();
        }

        private void btnSubtrc_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            total = n1 - n2;

            txtTotal.Text = total.ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            total = n1 * n2;

            txtTotal.Text = total.ToString();
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(textBox1.Text);
            n2 = double.Parse(textBox2.Text);

            if (n2 != 0)
            {
                total = n1 / n2;
            }
            else
            {
                MessageBox.Show("Não é permitida a divisão por zero");
                txtTotal.Clear();
                textBox1.Clear();
                textBox2.Clear();
            }

            txtTotal.Text = total.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            textBox1.Clear();
            textBox2.Clear();
        
        }
    }
}
