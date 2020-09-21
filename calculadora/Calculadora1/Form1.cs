using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1
{
    public partial class Form1 : Form
    {

        string operador;
        int a = 0;
        bool validar = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumerador(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            txtDisplay.Text = txtDisplay.Text + bt.Text;

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "";
            label1.Text = "";
            a = 0;
            validar = false;
            txtDisplay.Focus();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                a = a + Convert.ToInt32(txtDisplay.Text);
                label1.Text = Convert.ToString(a) + "+";
                txtDisplay.Text = "";
                operador = "+";
                txtDisplay.Focus();
            }
            else
            {
                label1.Text = txtDisplay.Text + btnAdicao.Text;
                a = Convert.ToInt32(txtDisplay.Text);
                txtDisplay.Text = "";
                operador = "+";
                validar = true;
                txtDisplay.Focus();

            }

        }


        private void btnSubracao(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txtDisplay.Focus();
                a = a - Convert.ToInt32(txtDisplay.Text);
                label1.Text = Convert.ToString(a) + "-";
                txtDisplay.Text = "";
                operador = "-";
                txtDisplay.Focus();
            }
            else
            {
                label1.Text = txtDisplay.Text + btnSubtracao.Text;
                a = Convert.ToInt32(txtDisplay.Text);
                txtDisplay.Text = "";
                operador = "-";
                validar = true;
                txtDisplay.Focus();
            }
        }



        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txtDisplay.Focus();
                a = a * Convert.ToInt32(txtDisplay.Text);
                label1.Text = Convert.ToString(a) + "*";
                txtDisplay.Text = "";
                operador = "*";
                validar = false;
                txtDisplay.Focus();
            }
            else
            {
                label1.Text = txtDisplay.Text + btnMultiplicar.Text;
                a = Convert.ToInt32(txtDisplay.Text);
                txtDisplay.Text = "";
                operador = "*";
                validar = true;
                txtDisplay.Focus();

            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (validar == true)
            {
                txtDisplay.Focus();
                a = a / Convert.ToInt32(txtDisplay.Text);
                label1.Text = Convert.ToString(a) + "/";
                txtDisplay.Text = "";
                operador = "/";
                txtDisplay.Focus();
            }
            else
            {
                label1.Text = txtDisplay.Text + btnDividir.Text;
                a = Convert.ToInt32(txtDisplay.Text);
                txtDisplay.Text = "";
                operador = "/";
                validar = true;
                txtDisplay.Focus();

            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (operador == "+")
            {
                label1.Text = label1.Text + txtDisplay.Text + "=";
                if (txtDisplay.Text != "")
                {
                    txtDisplay.Text = Convert.ToString(a + Convert.ToInt32(txtDisplay.Text));
                }
                else
                {
                    txtDisplay.Text = Convert.ToString(a);
                }
            }
            else if (operador == "-")
            {
                label1.Text = label1.Text + txtDisplay.Text + "=";
                if (txtDisplay.Text != "")
                {
                    txtDisplay.Text = Convert.ToString(a - Convert.ToInt32(txtDisplay.Text));
                }
                else
                {
                    txtDisplay.Text = Convert.ToString(a);
                }
            }
            else if (operador == "*")
            {
                label1.Text = label1.Text + txtDisplay.Text + "=";
                if (txtDisplay.Text != "")
                {
                    txtDisplay.Text = Convert.ToString(a * Convert.ToInt32(txtDisplay.Text));
                }
                else
                {
                    txtDisplay.Text = Convert.ToString(a);
                }
            }
            else if (operador == "/")
            {
                label1.Text = label1.Text + txtDisplay.Text + "=";
                if (txtDisplay.Text != "")
                {
                    txtDisplay.Text = Convert.ToString(a / Convert.ToInt32(txtDisplay.Text));
                }
                else
                {
                    txtDisplay.Text = Convert.ToString(a);
                }
            }
            
        }

    }

    
}

