using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;


namespace Aula09_Dados
{
    public class Jogo
    {
        public int Dado1 { get; set; }
        public int Dado2 { get; set; }
        public int Resultado { get; set; }

        public void JogarDados()
        {
            int d1 = 0, d2 = 0;
            
            Random r = new Random();
           

            d1 = r.Next(6);
            d2 = r.Next(6);         

            if (d1 == 0)
            {
                while (d1 == 0)
                {
                    d1 = r.Next(6);
                }
                Resultado = SomaDados(d1, d2);
                Dado1 = d1;
                Dado2 = d2;
            }
            else if (d2 == 0)
            {
                while (d2 == 0)
                {
                    d2 = r.Next(6);
                }

                Resultado = SomaDados(d1, d2);
                Dado1 = d1;
                Dado2 = d2;

            }
            else
            {
                Resultado = SomaDados(d1, d2);
                Dado1 = d1;
                Dado2 = d2;
            }

            Resultado = SomaDados(d1, d2);
            Dado1 = d1;
            Dado2 = d2;


        }
       

        public int SomaDados(int d1, int d2)
        {          
            return d1 + d2;
        }

        
    }
}
