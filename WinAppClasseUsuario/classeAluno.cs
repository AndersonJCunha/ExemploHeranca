using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinAppClasseUsuario
{
    public class classeAluno:classeUsuario
    {
        public string turma {  get; set; } 
        public double nota1 { get; set; }  
        public double nota2 { get; set; }  
        public double media {  get; set; } 

        public classeAluno()
        {
            this.turma = "";
            this.nota1 = 0;
            this.nota2 = 0;
            this.media = 0;
        }

       
        //método para calcular a media
        public void calculaMedia()
        {
            this.media = (this.nota1 + this.nota2) / 2;
        }
        //método para retornar a média
        public double retornaMedia()
        {
            return this.media;
        }
        //método para verificar a aprovação
        public string verificaAprovacao()
        {
            if (this.media >= 7)
                return "Aprovado";
            else
                return "Reprovado";
        }

    }
}
