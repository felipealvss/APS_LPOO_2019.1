using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeAPSqt02
{
    class Aluno
    {
        private string nomeCompleto;
        private string matricula;
        private long cpf;

        // Construtor #1
        public Aluno(string nomeCompleto, string matricula)
        {
            this.nomeCompleto = nomeCompleto;
            this.matricula = matricula;
        }

        // Construtor #2
        public Aluno(string nomeCompleto, long cpf)
        {
            this.nomeCompleto = nomeCompleto;
            this.cpf = cpf;
        }

        // Métodos Set, recebem valor para atribuição
        public void setNomeCompleto(string nomeCompleto)
        {
            this.nomeCompleto = nomeCompleto;
        }
        public void setMatricula(string matricula)
        {
            this.matricula = matricula;
        }
        public void setCpf(long cpf)
        {
            this.cpf = cpf;
        }

        // Métodos 'imprimir', substitutos do Get
        public string imprimirNomeCompleto()
        {
            return this.nomeCompleto;
        }
        public string imprimirMatricula()
        {
            return this.matricula;
        }
        public long imprimirCpf()
        {
            return this.cpf;
        }
    }
}
