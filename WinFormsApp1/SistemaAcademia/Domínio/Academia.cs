using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Domínio
{
    class Academia
    {
        public string Nome { get; set; }
        public List<Aluno> Alunos { get; private set; }

        public Academia()
        {
            Alunos = new List<Aluno>();
        }
        public void AdicionaAluno(Aluno aluno)
        {
           Alunos.Add(aluno);
        }
        public void AdicionaAluno(string nome, string turma, string modalidade, bool paga)
        {
            Alunos.Add(new Aluno(nome, turma, modalidade, paga));
        }
        public void RemoveAluno(Aluno aluno)
        {
            Alunos.Remove(aluno);
        }
        public void SalvaAluno(Aluno aluno)
        {
            foreach (var aluno1 in alunoss)
            {
                if (aluno.Nome.Equals(aluno.Nome))
                {
                    aluno1.Turma =alunos.Turma;
                    aluno1.Paga = alunos.Paga;
                }
}

