using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcIMC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                double Peso, Altura, imc;
                Peso = Convert.ToDouble(textPeso.Text);
                Altura = Convert.ToDouble(textAltura.Text);
                imc = Peso / (Altura * Altura);
                if (imc < 20)
                    lblResultado.Text = "abaixo do peso \nSeu imc:" + imc;
                else

                  if (imc >= 20 && imc < 25)
                    lblResultado.Text = "peso normal \nSeu imc:" + imc;
                else
                if (imc >= 25 && imc < 30)
                    lblResultado.Text = "sobre peso \nSeu imc:" + imc;
                else
                if (imc >= 30 && imc < 40)
                    lblResultado.Text = "obeso \nSeu imc:" + imc;
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

