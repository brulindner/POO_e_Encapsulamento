using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_e_Encapsulamento.Models
{
    public class Venda
    {
        public Cliente Cliente { get; set; }

        public List<Produto> Produtos { get; set; }

        public Venda(Cliente cliente)
        {
            Cliente = cliente;
            Produtos = new List<Produto>();
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var produto in Produtos)
            {
                total += produto.Preco;
            }

            return total;
        }
    }
}