using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaculadoraCompostaSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text != "")
            { 
            double M;
            double P = Convert.ToDouble(Principal.Text);
            double i = Convert.ToDouble(Taxa.Text) / 100;
            double n = Convert.ToDouble(Periodo.Text);
            M = P * (1 + (i * (n / 30)));
            Montante.Text = M.ToString("0.00");

            }else
            {
                MessageBox.Show("Digite os campos para ter o resultado! ");
            }
        }

        private void Principal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Taxa_TextChanged(object sender, EventArgs e)
        {

        }

        private void Periodo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Montante_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
