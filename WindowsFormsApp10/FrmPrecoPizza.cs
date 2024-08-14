using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    public partial class FrmPrecoPizza : Form
    {
        public FrmPrecoPizza()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double preco = 0;
            preco = Convert.ToDouble(txtPreco.Text);

            if (ckBox1.Checked && ckBox2.Checked)
            {
                preco += 20.98;
            }
            else if (ckBox1.Checked)
            {
                preco += 12.90;
            }
            else if (ckBox2.Checked)
            {
                preco += 7.99;
            }
            

            txtResultado.Text = preco.ToString();
        }
    }
}
