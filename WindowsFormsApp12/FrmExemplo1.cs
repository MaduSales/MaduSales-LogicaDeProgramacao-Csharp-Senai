using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12
{
public partial class FrmExemplo1 : Form
{
public FrmExemplo1()
{
    InitializeComponent();
}

private void btnVerificar_Click(object sender, EventArgs e)
{
    string cor;
    cor = txtCor.Text.ToUpper();

    switch (cor)
    {
        case "VERDE":
            MessageBox.Show("Você escolheu VERDE");
            break;

        case "AZUL":
            MessageBox.Show("Você escolheu AZUL");
            break;

        case "VERMELHO":
             MessageBox.Show("Você escolheu VERMELHO");
             break;

             default:
                MessageBox.Show("Essa cor não está disponível");
                break;
    }
}
}
}
