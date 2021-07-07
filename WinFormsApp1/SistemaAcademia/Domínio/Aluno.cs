using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Domínio
{
    class Aluno : Pessoa
    {
        
        private string Turma { get; set; }
        private string Modalidade { get; set; }
        private bool Paga { get; set; }

        public Aluno(string nome, string turma, string modalidade, bool paga)
        {
            Nome = nome;
            Turma = turma;
            Modalidade = modalidade;
            Paga = paga;
        }
        public override string ToString()
        {
            return Nome;
        }
    }

}
