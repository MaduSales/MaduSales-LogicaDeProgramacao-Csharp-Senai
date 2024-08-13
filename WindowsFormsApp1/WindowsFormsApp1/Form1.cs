using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1º Passo - Declarar as variáveis
            double n1, n2, total;


            // 2º Passo - Receber os valores (ENTRADA)
            n1 = double.Parse(txtValor1.Text); // "Text" é onde a informação digitada, é exibida (infelizmente não é em Value)
            n2 = double.Parse(txtValor2.Text);


            // 3º Passo - Processamento
            total = n1 + n2;


            // 4º Passo - Saída
            txtTotal.Text = total.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Botão Limpar
            txtValor1.Clear();
            txtValor2.Clear(); //Método que o Csharp fornece para limpagem
            txtTotal.Clear();
        }
    }
}

