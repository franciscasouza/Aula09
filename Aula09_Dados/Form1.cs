using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula09_Dados
{
    public partial class Form1 : Form
    {
        int contador = 1;
        int Vjogador = 0;
        int VComputador = 0;
        Jogo jogo = new Jogo();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jogo.JogarDados();

            int valor = int.Parse(txtJogado1.Text);
            txtJogado1.TextAlign = HorizontalAlignment.Center;

            if (valor == jogo.Resultado)
            {
                Vjogador +=1;

                txtDado1.Text = jogo.Dado1.ToString();
                txtDado2.Text = jogo.Dado2.ToString();

                /*Alinhando o Texto*/
                txtDado1.TextAlign = HorizontalAlignment.Center;
                txtDado2.TextAlign = HorizontalAlignment.Center;

                txtComputador.Text = jogo.Dado1.ToString(); 

                MessageBox.Show($"Jogador Ganhou {Vjogador} de {contador} vezes");
               

            }
            else
            {
                VComputador += 1;
                txtDado1.Text = jogo.Dado1.ToString();
                txtDado2.Text = jogo.Dado2.ToString();
                txtComputador.Text = jogo.Resultado.ToString();

                /*Alinhando o Texto*/
                txtComputador.TextAlign = HorizontalAlignment.Center;
                txtDado1.TextAlign = HorizontalAlignment.Center;
                txtDado2.TextAlign = HorizontalAlignment.Center;

                MessageBox.Show($"Compuador Venceu {VComputador} de {contador} vezes");
            }

        }

        private void Jogada(object sender, MouseEventArgs e)
        {           
            contador += 1;
        }
    }
}
