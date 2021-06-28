using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Questoes
{
    public partial class Questao2 : Form
    {
        double cotacaoDolar = 0.0;
        double valorEmDolaresConvercao = 0.0;
        double converterValor = 0.0;
      
        public Questao2()
        {
            InitializeComponent();
        }


        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            var voltarMenu = new Menu();
            this.Hide();
            voltarMenu.Show();
        }

        private void txtCotacaoDolar_TextChanged(object sender, EventArgs e)
        {
            cotacaoDolar = double.Parse(txtCotacaoDolar.Text);
        }

        private void txtValorEmDolaresConvercao_TextChanged(object sender, EventArgs e)
        {
            valorEmDolaresConvercao = double.Parse(txtValorEmDolaresConvercao.Text);
            txtValorEmDolaresConvertido.Text = ConverterParaReal(cotacaoDolar, valorEmDolaresConvercao).ToString();
        }

        private double ConverterParaReal(double cod, double vdc)
        {
            converterValor = (cotacaoDolar * valorEmDolaresConvercao);
            return converterValor;
        }
        //private double ConverterParaReal(double vad, double var)
    }
    /*Faça um programa que:

- Leia a cotação do dólar

- Leia um valor em dólares

- Converta esse valor para Real

- Mostre o resultado*/
}
