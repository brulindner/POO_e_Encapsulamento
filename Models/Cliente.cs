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
            if (string.IsNullOrWhiteSpace(nome))
            {
                throw new ArgumentException("O nome do cliente não pode ser vazio", nameof(nome));
            }
            if (string.IsNullOrWhiteSpace(cpf))
            {
                throw new ArgumentException("O CPF não pode ser vazio", nameof(cpf));
            }

            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        public string Nome { get; set; }

        public string Cpf { get; private set; }
        public string Telefone { get; set; }

        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Telefone: {Telefone}";
        }
    }
}