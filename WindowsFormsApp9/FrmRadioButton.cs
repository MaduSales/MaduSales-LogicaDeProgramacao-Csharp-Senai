using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp9
{
    public partial class FrmRadioButton : Form
    {
        public FrmRadioButton()
        {
            InitializeComponent();
        }

        private void btnEscolher_Click(object sender, EventArgs e)
        {
            if (rbtnJava.Checked)
            {
                txtResposta.Text = ("Você selecionou Java!");
            }
            else if (rbtnCsharp.Checked)
            {
                txtResposta.Text = ("Você selecionou Csharp!");
            }
            else if (rbtnPhyton.Checked)
            {
                txtResposta.Text = ("Você selecionou Phyton!");
            }
        }
    }
}
