using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAcademia.Domínio
{
    class Aluno : Pessoa
    {
        public string Turno { get; set; }
        public string Modalidade { get; set; }
        public bool pago { get; set; }

        public Aluno(string nome, string telefone, string cpf, string turno, string modalidade)
        {
            Nome = nome;
            Telefone = telefone;
            CPF = cpf;
            Turno = turno;
            Modalidade = modalidade;
            pago = false;
        }

        public override string ToString()
        {
            if(pago)

            return $"{Nome} - {Modalidade} - pago";

            else
            
            return $"{Nome} - {Modalidade} - não pago";

        }
    }
}
