using System;
using System.Collections.Generic;
using POO_e_Encapsulamento.Models;

class Program
{
    static List<Cliente> clientes = new List<Cliente>();
    static List<Produto> produtos = new List<Produto>();
    static List<Venda> vendas = new List<Venda>();


    static void Main()
    {
        int opcao;

        do
        {
            Console.Clear();
            Console.WriteLine("==== SISTEMA DE VENDAS ====");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Realizar Venda");
            Console.WriteLine("4 - Listar Vendas");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("Escolha uma opção: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida! Pressione qualquer tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            switch (opcao)
            {
                case 1:
                    CadastrarCliente();
                    break;
                case 2:
                    CadastrarProduto();
                    break;
                case 3:
                    RealizarVenda();
                    break;
                case 4:
                    ListarVendas();
                    break;
                case 0:
                    Console.WriteLine("Saindo do sistema...");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            if (opcao != 0) ;
            {
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu");
                Console.ReadKey();
            }
        } while (opcao != 0);
    }

    static void CadastrarCliente()
    {
        Console.Clear();
        Console.WriteLine("==== CADASTRO DE CLIENTES ====");
        Console.WriteLine("Informe o nome do cliente: ");
        string nome = Console.ReadLine();
        Console.WriteLine("CPF ");
        string cpf = Console.ReadLine();
        Console.WriteLine("Telefone: ");
        string telefone = Console.ReadLine();

        clientes.Add(new Cliente(nome, cpf, telefone));
    }

    static void CadastrarProduto()
    {
        Console.Clear();
        Console.WriteLine("==== CADASTRO DE PRODUTO ====");
        Console.WriteLine("Nome do Produto: ");
        string nomeProduto = Console.ReadLine();
        Console.WriteLine("Preço: ");
        decimal preco = Convert.ToDecimal(Console.ReadLine());

        while (!decimal.TryParse(Console.ReadLine(), out preco) || preco < 0)
        {
            Console.WriteLine("Preço inválido. Digite novamente: ");
        }

        produtos.Add(new Produto(nomeProduto, preco));
        Console.WriteLine("Produto cadastrado com sucesso!");
    }

    static void RealizarVenda()
    {
        Console.Clear();
        Console.WriteLine("==== REALIZAR VENDAS ====");

        if (clientes.Count == 0 || produtos.Count == 0)
        {
            Console.WriteLine("É necessário ter ao menos 1 cliente e 1 produto cadastrado");
            return;
        }

        Console.WriteLine("Escolhe o cliente (digite o número): ");
        for (int i = 0; i < clientes.Count; i++)
            Console.WriteLine($"{i} - {clientes[i].Nome} ({clientes[i].Cpf}) {clientes[i].Telefone}");

        int indiceCliente;
        if (!int.TryParse(Console.ReadLine(), out indiceCliente) || indiceCliente < 0 || indiceCliente >= clientes.Count)
        {
            Console.WriteLine("Cliente Inválido");
            return;
        }

        Venda venda = new Venda(clientes[indiceCliente]);

        string opcao;

        do
        {
            Console.WriteLine("Escolha o produto para adicionar à venda (digite o número): ");
            for (int i = 0; i < produtos.Count; i++)
                Console.WriteLine($"{i} - {produtos[i].NomeProduto} - R$ {produtos[i].Preco}");

            int indiceProduto;
            if (!int.TryParse(Console.ReadLine(), out indiceProduto) || indiceProduto < 0 || indiceProduto >= produtos.Count)
            {
                Console.WriteLine("Produto Inválido");
            }
            else
            {
                venda.Produtos.Add(produtos[indiceProduto]);
                Console.WriteLine("Produto Adicionado!");
            }

            Console.WriteLine("Deseja adicionar outro produto? (s/n)");
            opcao = Console.ReadLine().ToLower();
        } while (opcao == "s");

        vendas.Add(venda);
        Console.WriteLine($"Venda concuida! Total: R$ {venda.CalcularTotal()}");
    }

    static void ListarVendas()
    {
        Console.Clear();
        Console.WriteLine("==== LISTA DE VENDAS ====");

        if (vendas.Count == 0)
        {
            Console.WriteLine("Nenhuma venda realizada");
        }
        else
        {

            foreach (var venda in vendas)
            {
                Console.WriteLine($"Cliente: {venda.Cliente.Nome} - Total: R$ {venda.CalcularTotal()}");
            }
        }
    }
}