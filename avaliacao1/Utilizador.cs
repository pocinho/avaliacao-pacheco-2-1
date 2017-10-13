using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avaliacao1
{
    class Utilizador
    {
        public string Nome { get; set; }
        public string Pass { get; set; }
        public Utilizador(string nome, string pass)
        {
            Nome = nome;
            Pass = pass;
        }
    }
}
