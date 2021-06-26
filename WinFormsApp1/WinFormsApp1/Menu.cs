using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Questoes
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void btnQuestao1_Click(object sender, EventArgs e)
        {
            var questao1 = new Questao1();
            this.Hide();
            questao1.Show();
        }

        private void btnQuestão2_Click(object sender, EventArgs e)
        {
            var questao2 = new Questao2();
            this.Hide();
            questao2.Show();
        }
    }
}
