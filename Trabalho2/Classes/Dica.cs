using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho2.Classes
{
    class Dica
    {
        private string titulo;
        private string conteudo;
        

        public Dica()
        {

        }

        public Dica(string titulo, string conteudo)
        {
            this.titulo = titulo;
            this.conteudo = conteudo;
            
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public string Conteudo { get => conteudo; set => conteudo = value; }
        
    }

    
}
