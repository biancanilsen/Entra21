﻿using SistemaAcademia.Domínio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaAcademia
{
    public partial class Form : System.Windows.Forms.Form
    {
        Academia academia;
        bool novo;
        public Form()
        {
            InitializeComponent();
            academia = new Academia();
        }
        private void Formulario_Load(object sender, EventArgs e)
        {
            btnAdicionar_Click(sender, e);
        }
        private void listAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAlunos.SelectedIndex >= 0)
            {
                txtNome.Text = academia.ListaAlunos[listAlunos.SelectedIndex].Nome;
                mtbTelefone.Text = academia.ListaAlunos[listAlunos.SelectedIndex].Telefone;
                mtbCPF.Text = academia.ListaAlunos[listAlunos.SelectedIndex].CPF;
                cbTurno.SelectedItem = academia.ListaAlunos[listAlunos.SelectedIndex].Turno;
                cbModalidade.SelectedItem = academia.ListaAlunos[listAlunos.SelectedIndex].Modalidade;
            }
        }
        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            txtNome.Text = "";
            mtbTelefone.Text = "";
            mtbCPF.Text = "";
            cbTurno.SelectedItem = null;
            cbModalidade.SelectedItem = null;
            novo = true;
            txtNome.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (novo)
            {
                academia.AdicionarAluno(
                    txtNome.Text,
                    mtbTelefone.Text,
                    mtbCPF.Text,
                    cbTurno.SelectedItem.ToString(),
                    cbModalidade.SelectedItem.ToString());
            }
            else
            {
                if (listAlunos.SelectedIndex >= 0)
                {
                    academia.AtualizarAluno(
                        listAlunos.SelectedIndex,
                        txtNome.Text,
                        mtbTelefone.Text,
                        mtbCPF.Text,
                        cbTurno.SelectedItem.ToString(),
                        cbModalidade.SelectedItem.ToString());
                }

            }
            novo = false;
            AtualizarListaAlunos();
        }
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (listAlunos.SelectedIndex >= 0)
            {
                academia.DeletarAluno(listAlunos.SelectedIndex);
            }
            AtualizarListaAlunos();
        }

        private void AtualizarListaAlunos()
        {
            listAlunos.Items.Clear();
            foreach (var aluno in academia.ListaAlunos)
            {
                listAlunos.Items.Add(aluno);
            }
        }

    }
}
