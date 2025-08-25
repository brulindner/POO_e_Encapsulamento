using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_e_Encapsulamento.Models
{
    public class Produto
    {
        public Produto(string nomeProduto, decimal preco)
        {
            NomeProduto = nomeProduto;
            Preco = preco;
        }

        public string NomeProduto { get; set; }
        public decimal Preco { get; set; }
    }
}