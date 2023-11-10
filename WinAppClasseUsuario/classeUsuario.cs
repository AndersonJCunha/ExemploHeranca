using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinAppClasseUsuario
{    public class classeUsuario
    {
        //declaração dos atributos
        public string nome { get; set; }aaaaaaa
        public string matricula { get; set; }  
        public DateTime dataNasc {  get; set; }    
        public string endereco { get; set; }   
        public int idade { get; set; }     
        //método construtor para a classe
        public classeUsuario()
        {
            this.nome = "";
            this.matricula = "";
            this.dataNasc = DateTime.Today;
            this.endereco = "";
            this.idade = 0;
        }


        //métodos set e get
        //para os atributos: nome, matricula, endereço, dataNasc
      
    }
}
