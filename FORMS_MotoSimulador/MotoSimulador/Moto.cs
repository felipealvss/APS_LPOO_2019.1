using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotoSimulador
{
    class Moto
    {
        private string marca;
        private string modelo;
        private int marcha;
        private const int menorMarcha = 0; // Constante definida: Menor marcha
        private const int maiorMarcha = 5; // Constante definida: Maior marcha
        private Boolean ligada;

        /* Métodos Construtores */
        public Moto()
        {

        } // Sem parâmetros

        public Moto(string marca, string modelo, int marcha, Boolean ligada)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.marcha = marcha;
            this.ligada = ligada;
        } // com parâmetros

        /* Métodos próprios da Classe */
        public void marchaAcima() // Acima
        {
            if (marcha < maiorMarcha)
            {
                definirMarcha(marcha + 1);
            }
        }
        public void marchaAbaixo()// Abaixo
        {
            if(marcha > menorMarcha)
            {
                definirMarcha(marcha - 1);
            }
        }
        public void ligarMoto() // Ligar moto
        {
            definirLigada(true);
        }
        public void desligarMoto() // Desligar moto
        {
            definirLigada(false);
        }
        
        public string[] catalogo(string marca)//Catalogo para ordenação de marcas
        {
            string[] honda = new string[]
                             {
                                "Honda CB 300 R",
                                "Honda CG 160",
                                "Honda NXR 160 Bros",
                                "Honda POP 110i"
                             };
            string[] yamaha = new string[]
                             {
                                "YS 250 Fazer",
                                "XT 660",
                                "Xj6 N",
                                "Xtz 250 Lander",
                                "YBR 125 Factor"

                             };
            string[] suzuki = new string[]
                             {
                                "Gsr 150i",
                                "Boulevard",
                                "Hayabusa",
                                "Gsx R 750",
                                "Gs 120"
                             };
            string[] bmw = new string[]
                             {
                                "F 800",
                                "R 1200",
                                "G 310",
                                "S 1000",
                                "K 1600"
                             };
            string[] harleyDavidson = new string[]
                             {
                                "Sportster 883",
                                "Softail",
                                "Touring",
                                "Softail Deluxe",
                                "Sportster 1200"
                             };
            string[] def = new string[]
                             {
                                "",
                             };

            if (marca == "Honda")
            {
                return honda;      
            }else if(marca == "Yamaha")
            {
                return yamaha;
            }
            else if (marca == "Suzuki")
            {
                return suzuki;
            }
            else if (marca == "BMW")
            {
                return bmw;
            }
            else if (marca == "Harley-Davidson")
            {
                return harleyDavidson;
            }
            else
            {
                return def;
            }
            
        }
        

        /* Métodos 'Definir', substitutos do método Set */
        public void definirMarca(string marca)
        {
            this.marca = marca;
        }
        public void definirModelo(string modelo)
        {
            this.modelo = modelo;
            
        }
        public void definirMarcha(int marcha)
        {
            this.marcha = marcha;
        }
        public void definirLigada(Boolean ligada)
        {
            this.ligada = ligada;
        }

        /* Métodos 'imprimir', substitutos do método Get */
        public string imprimirMarca()
        {
            return this.marca;
        }
        public string imprimirModelo()
        {
            return this.modelo;
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
