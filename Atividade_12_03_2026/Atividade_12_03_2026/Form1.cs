using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_12_03_2026
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numeroUsuario = int.Parse(textBox1.Text);

            if (numeroUsuario > 0)
            {
                txtCampo.Text = "O número é positivo.";
            }
            else if (numeroUsuario < 0)
            {
                txtCampo.Text = "O número é negativo.";
            }
            else
            {
                txtCampo.Text = "O número é zero.";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                string meses = textBox1.Text.ToLower();

                string dias31 = "31";
                string dias28 = "28";
                string dias30 = "30";


                if (meses == "01" || meses == "janeiro" || meses == "Janeiro" || meses == "JANEIRO" 
                    || meses == "03" || meses == "março" || meses == "Março" || meses == "MARÇO" 
                    || meses == "05" || meses == "maio" || meses == "Maio" || meses == "MAIO" 
                    || meses == "07" || meses == "julho" || meses == "Julho" || meses == "JULHO"
                    || meses == "08" || meses == "agosto" || meses == "Agosto" || meses == "AGOSTO"
                    || meses == "10" || meses == "outubro" || meses == "Outubro" || meses == "OUTUBRO"
                    || meses == "12" || meses == "dezembro" || meses == "Dezembro" || meses == "DEZEMBRO")
                {
                    txtCampo.Text = " O mês escolhido tem " + dias31 + " dias.";
                }
                if (meses == "02" || meses == "fevereiro" || meses == "Fevereiro" || meses == "FEVEREIRO")
                {
                    txtCampo.Text = " O mês escolhido tem " + dias28 + " dias.";
                }
                else if (meses == "04" || meses == "abril" || meses == "Abril" || meses == "ABRIL"
                    || meses == "06" || meses == "junho" || meses == "Junho" || meses == "JUNHO"
                    || meses == "09" || meses == "setembro" || meses == "Setembro" || meses == "SETEMBRO"
                    || meses == "11" || meses == "novembro" || meses == "Novembro" || meses == "NOVEMBRO")
                {
                    txtCampo.Text = " O mês escolhido tem " + dias30 + " dias.";
                }
                
            }
            else
            {
                MessageBox.Show(" Insira a informação para obter o  resultado");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double n1 = double.Parse(textBox1.Text);
            double n2 = double.Parse(textBox2.Text);
            double n3 = double.Parse(textBox3.Text);

            double resultado;

            if (n1 >= n2 && n1 >= n3)
            {
                resultado = n1;
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                resultado = n2;
            }
            else
            {
                resultado = n3;
            }

            txtCampo.Text = "O maior número é: " + resultado;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            string letra = textBox1.Text;

            //validar se é maiusculo ou minusculo
            if (letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u") 
            {
                txtCampo.Text = "A letra é uma vogal.";
            }
            else
            {
                txtCampo.Text = "A letra é uma consoante.";
            }
        }
    }
}
