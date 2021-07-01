using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Questoes
{
    public partial class Cadastro_Alunos : Form
    {
        int idade = 0;
        string classificacao;

        public Cadastro_Alunos()
        {
            InitializeComponent();
        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {
            idade = int.Parse(txtIdade.Text);
            if (idade == 5 || idade == 6 || idade == 7)
            {
                classificacao = "Infantil A";
            }
            if (idade >= 8 && idade <= 11)
            {
                classificacao = "Infantil B";
            }
            if (idade >= 12 && idade <= 13)
            {
                classificacao = "Juvenil A";
            }
            if (idade >= 14 && idade <= 17)
            {
                classificacao = "Juvenil B";
            }
            if (idade >= 18)
            {
                classificacao = "Adulto";
            }
        }
        private void btnEnviat_Click(object sender, EventArgs e)
        {
            lbClassificacao.Text = (classificacao);
        }
    }
}
