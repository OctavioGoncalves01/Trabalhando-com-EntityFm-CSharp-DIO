using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModuloApi.Entities
{

    //Classe que ira representar nossa tabela
    public class Contato
    {
        public int Id {get; set;}
        public string Nome {get; set;}
        public string Telefone {get; set;}
        public bool Ativo {get; set;}

        
    }
}