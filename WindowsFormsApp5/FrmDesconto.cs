using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class FrmDesconto : Form
    {
        public FrmDesconto()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string produto;
            int qtdProduto;
            double precoUnitario, desconto, totalSemDesconto, totalComDesconto;

            produto = txtProduto.Text;
            qtdProduto = int.Parse(txtQtdComprada.Text);
            precoUnitario = double.Parse(txtPrecoUnitario.Text);
            
            totalSemDesconto = Math.Round(qtdProduto * precoUnitario, 2);

            if (qtdProduto <= 5)
            {
                desconto = totalSemDesconto * 2 / 100;
            }
            else if (qtdProduto > 5 && qtdProduto <= 10)
            {
                desconto = totalSemDesconto * 3 / 100;
            }
            else
            {
                desconto = totalSemDesconto * 5 / 100;
            }

            totalComDesconto = Math.Round(totalSemDesconto - desconto, 2);

            txtTotalSemDesconto.Text = ("R$"+ totalSemDesconto.ToString());
            txtTotalComDesconto.Text = ("R$" + totalComDesconto.ToString());
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPrecoUnitario.Clear();
            txtProduto.Clear();
            txtQtdComprada.Clear();
            txtTotalComDesconto.Clear();
            txtTotalSemDesconto.Clear();
        }
    }
}
