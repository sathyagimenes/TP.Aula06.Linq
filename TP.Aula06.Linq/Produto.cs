using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP.Aula06.Linq
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }


        public override string ToString()
        {
            return $"Id: {Id} | Nome: {Nome} | Valor: R$ {Valor}";
        }

    }
}
