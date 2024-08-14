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
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            double peso, altura, imc;

            peso = double.Parse(txtPeso.Text);
            altura = double.Parse(txtAltura.Text);

            imc = Math.Round(peso / (altura * altura), 2);

            if (imc < 16.9)
            {
                lblInformacao.Text = ("Muito abaixo do peso.");
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                lblInformacao.Text = ("Abaixo do peso.");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                lblInformacao.Text = ("IMC normal.");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                lblInformacao.Text = ("Você está acima do peso.");
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                lblInformacao.Text = ("Obesidade grau I.");
            }
            else if (imc >= 35 && imc <= 40)
            {
                lblInformacao.Text = ("Obesidade grau II.");
            }
            else
            {
                lblInformacao.Text = ("Obesidade grau III.");
            }
            txtIMC.Text = ("O seu IMC é " + imc).ToString();
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Clear();
            txtIMC.Clear();
        }
    }
}