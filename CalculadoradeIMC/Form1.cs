using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
            txtIMC.Text = Math.Round(resultado,2).ToString();
            //Classificação de tabela:
if (n1 <= 0 || n2 <= 0)
                {
                txtIMC.Clear();
                MessageBox.Show("Os valores devem ser maior que 0.");
             
            }
    else if (resultado>= 40 )
            {
                txtTabela.Text = "Obesidade III";
                txtTabela.ForeColor= Color.Red;
            }
     else if (resultado>= 35)
            {
                txtTabela.Text = "Obesidade II";
                txtTabela.ForeColor = Color.OrangeRed;
            }
     else if (resultado>= 30)
            {
                txtTabela.Text = "Obesidade I";
                txtTabela.ForeColor = Color.Orange;
            }
            else if (resultado >= 25)
            {
                txtTabela.Text = "Levimente acima do peso";
                txtTabela.ForeColor = Color.Yellow;
            }
            else if (resultado >= 18.6)
            {
                txtTabela.Text = "Peso ideal";
                txtTabela.ForeColor = Color.Green;
            }
            else 
            {
                txtTabela.Text = "Abaixo do peso";
                txtTabela.ForeColor = Color.OrangeRed;
            }


        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
