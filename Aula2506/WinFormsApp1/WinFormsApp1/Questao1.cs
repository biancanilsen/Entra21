using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Questoes
{
    public partial class Questao1 : Form
    {
        int quantidadeMinima = 0;
        int quantidadeMaxima = 0;
        int estoqueMedio = 0;

        public Questao1()
        {
            InitializeComponent();
            
        }

        private void txtQuantidadeMinima_TextChanged(object sender, EventArgs e)
        {
            quantidadeMinima = int.Parse(txtQuantidadeMinima.Text);
        }

        private void txtQuantidadeMaxima_TextChanged(object sender, EventArgs e)
        {
            quantidadeMaxima = int.Parse(txtQuantidadeMaxima.Text);
            txtEstoqueMedio.Text = CalcularEstoqueMedio(quantidadeMinima, quantidadeMaxima).ToString();
        }
        private int CalcularEstoqueMedio(int qtm, int qtma)
        {
            estoqueMedio = (qtm + qtma) / 2;
            return estoqueMedio;
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            var voltarMenu = new Menu();
            this.Hide();
            voltarMenu.Show();
        }

    





        //Faça um programa para calcular o estoque médio de uma peça, sendo que:
        //ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2
    }
}
