using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WinAppClasseUsuario
{
    public class classeProfessor:classeUsuario
    {
        public int cargaHoraria {  get; set; } 
        public string tipo {  get; set; }  


        public classeProfessor()
        {
            this.cargaHoraria = 0;
            this.tipo = "";
        }

     
        //método para atribuir valor ao tipo
        public void Tipo()
        {
            if (this.cargaHoraria >= 50)
            {
                this.tipo = "Dedicação Integral";
            }
            else
            {
                this.tipo = "Convidado";
            }
        }

      
    }
}
