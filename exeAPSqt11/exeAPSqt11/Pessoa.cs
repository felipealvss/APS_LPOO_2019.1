using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeAPSqt11
{
    abstract class Pessoa : Validador
    {
        //atributos
        public String nome;

        //métodos
        public string escreverNome()
        {
            return nome;
        }

        public bool validarDocumento()
        {
            return true;
        }
    }
}