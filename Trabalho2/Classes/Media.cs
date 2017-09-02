using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2.Classes
{
    class Media
    {
        private Double nota;
        private Double peso;

        public double Nota { get => nota; set => nota = value; }
        public double Peso { get => peso; set => peso = value; }

        public Media(double nota, double peso)
        {
            this.nota = nota;
            this.peso = peso;
        }

        public Media(double nota)
        {
            this.nota = nota;
            
        }
    }

    
}
