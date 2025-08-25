using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_e_Encapsulamento.Models
{
    public class Cliente
    {
        public Cliente(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public string Nome { get; set; }
            
        public string Cpf { get; set; }
        public string Telefone { get; set; }
    }
}