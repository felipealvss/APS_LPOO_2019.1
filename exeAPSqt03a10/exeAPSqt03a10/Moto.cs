using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exeAPSqt10
{
    class Moto
    {
        private string marca;
        private string modelo;
        private string cor;
        private int marcha;
        private const int menorMarcha = 0; // Menor marcha
        private const int maiorMarcha = 5; // Maior marcha
        private Boolean ligada;

        // Método Construct
        public Moto(string marca, string modelo, string cor, int marcha, Boolean ligada)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
            this.marcha = marcha;
            this.ligada = ligada;
        }

        // Métodos próprios da Classe
        public void marchaAcima() // Acima
        {
            if (marcha < maiorMarcha)
            {
                setMarcha(marcha + 1);
            }
        }
        public void marchaAbaixo() // Abaixo
        {
            if (marcha > menorMarcha)
            {
                setMarcha(marcha - 1);
            }
        }
        public void ligarMoto() // Ligar moto
        {
            this.ligada = true;
        }
        public void desligarMoto() // Desligar moto
        {
            this.ligada = false;
        }

        // Métodos Set
        public void setMarca(string marca)
        {
            this.marca = marca;
        }
        public void setModelo(string modelo)
        {
            this.modelo = modelo;
        }
        public void setcor(string cor)
        {
            this.cor = cor;
        }
        public void setMarcha(int marcha)
        {
            this.marcha = marcha;
        }
        public void setLigado(Boolean ligada)
        {
            this.ligada = ligada;
        }

        // Métodos 'imprimir', substitutos do método Get
        public string imprimirMarca()
        {
            return this.marca;
        }
        public string imprimirModelo()
        {
            return this.modelo;
        }
        public string imprimirCor()
        {
            return this.cor;
        }
        public int imprimirMarcha()
        {
            return this.marcha;

        }
        public bool imprimirLigada()
        {
            return this.ligada;
        }

    }
}
