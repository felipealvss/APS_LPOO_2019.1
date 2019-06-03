using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MotoSimulador;

namespace MotoSimulador
{
    public partial class FormMotoSimulador : Form
    {
        MotoSimulador.Moto motocicleta = new Moto();
        public FormMotoSimulador()
        {
            InitializeComponent();
            
            

        }

        private void ComboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        { ///corrigir essa implementação = deixar mais dinâmica
            string item = comboBoxMarca.Text;
            comboBoxModelo.Items.Clear();
            comboBoxModelo.Items.AddRange(motocicleta.catalogo(item));

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //carrega imagem
            
            string referencia = comboBoxModelo.Text;
            Boolean checkinMoto = false;
            
            try
            {
                pictureBox1.Load("../../imagens/" + referencia + ".png");
                checkinMoto = true;
            }
            catch (Exception v)
            {
                Console.WriteLine("{0} Exception:", v);
            }
            if (checkinMoto)
            {
                botaoLigar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Escolha uma marca e modelo.");
            }
        }

        private void BotaoLigar_Click(object sender, EventArgs e)
        {
            if (motocicleta.imprimirLigada())
            {
                MessageBox.Show("A Motocicleta já está ligada!");
            }
            else
            {
                motocicleta.ligarMoto();

                if (motocicleta.imprimirLigada())
                {
                    
                    Botao_marchaDesce.Enabled = true;
                    botao_marchaSobe.Enabled = true;
                    botao_neutro.Enabled = true;
                    botaoDesligar.Enabled = true;
                    labelStatus.Text = "Ligada";
                    labelStatus.ForeColor = Color.Green;

                }
            }
        }

        private void BotaoDesligar_Click(object sender, EventArgs e)
        {
            if (!motocicleta.imprimirLigada())
            {
                MessageBox.Show("Já esta desligada!");
            }
            else
            {
                motocicleta.desligarMoto();
                Botao_marchaDesce.Enabled = false;
                botao_marchaSobe.Enabled = false;
                botao_neutro.Enabled = false;
                botaoDesligar.Enabled = false;
                labelStatus.Text = "Desligada";
                labelStatus.ForeColor = Color.Red;
            }
        }

        private void Botao_marchaSobe_Click(object sender, EventArgs e)
        {
            motocicleta.marchaAcima();
            //transpor essa definição para uma classe
            int marchaAtual = Convert.ToInt32(motocicleta.imprimirMarcha());
            labelMarcha.Text = marchaAtual.ToString();
        }

        private void Botao_marchaDesce_Click(object sender, EventArgs e)
        {
            motocicleta.marchaAbaixo();
            int marchaAtual = Convert.ToInt32(motocicleta.imprimirMarcha());
            labelMarcha.Text = marchaAtual.ToString();
        }

        private void Botao_neutro_Click(object sender, EventArgs e)
        {
            motocicleta.definirMarcha(0);
            int marchaAtual = Convert.ToInt32(motocicleta.imprimirMarcha());
            labelMarcha.Text = marchaAtual.ToString();
        }
    }
}
