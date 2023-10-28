using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoradeIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Coletar dados:
            double n1 = double.Parse(txtAltura.Text);
            double n2 = double.Parse(txtPeso.Text);
            //Fazer o calculo:
            double resultado = (n2 / (n1 * n1));
            txtIMC.Text = resultado.ToString();
            //Classificação de tabela:
     if (resultado>= 40 )
            {
                txtTabela.Text = "Obesidade III";
            }
     else if (resultado>= 35)
            {
                txtTabela.Text = "Obesidade II";
            }
     else if (resultado>= 30)
            {
                txtTabela.Text = "Obesidade I";
            }
            else if (resultado >= 25)
            {
                txtTabela.Text = "Levimente acima do peso";
            }
            else if (resultado >= 18.6)
            {
                txtTabela.Text = "Peso ideal";
            }
            else 
            {
                txtTabela.Text = "Abaixo do peso";
            }


        }
    }
}
