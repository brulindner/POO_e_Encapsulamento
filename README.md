# 💻 POO e Encapsulamento em C#

Este repositório contém um projeto simples desenvolvido em **C#** para demonstrar os conceitos fundamentais da **Programação Orientada a Objetos (POO)**, com foco especial na aplicação do princípio de **Encapsulamento**.

## 💡 O que é o projeto?

O projeto simula um sistema básico de vendas, onde são gerenciados **Clientes**, **Produtos** e **Vendas**. O foco principal não é a funcionalidade completa de um sistema comercial, mas sim a *estrutura* e a *implementação* das classes para exemplificar:

1.  **Criação de Classes e Objetos:** Como modelar entidades do mundo real em código.
2.  **Encapsulamento:** Uso de modificadores de acesso (`public`, `private`) e propriedades (`get`/`set`) para proteger os dados e controlar o acesso aos atributos das classes.

## 🧱 Estrutura do Projeto

O projeto é composto por quatro arquivos principais que demonstram a arquitetura básica:

| Arquivo | Descrição | Conceitos de POO Abordados |
| :--- | :--- | :--- |
| `Program.cs` | Contém o ponto de entrada da aplicação, onde as classes são instanciadas, manipuladas e os resultados são exibidos no console. | Instanciação de Objetos, Chamada de Métodos. |
| `Models/Cliente.cs` | Classe que representa a entidade Cliente. | Encapsulamento (Propriedades com `get`/`set`), Construtores. |
| `Models/Produto.cs` | Classe que representa a entidade Produto. | Encapsulamento, Atributos Privados (`private`). |
| `Models/Venda.cs` | Classe que representa uma transação de Venda. | Encapsulamento, Relacionamento entre Classes (Composição). |

## ✨ Destaque: Encapsulamento

O **Encapsulamento** é um dos pilares da POO e é o foco deste projeto. Ele garante que o estado interno de um objeto seja protegido e que a manipulação de seus dados ocorra de forma controlada.

**Exemplo prático no código:**

Ao invés de acessar diretamente um campo, como `cliente.nome`, usamos **propriedades** (`get` e `set`) que podem incluir lógica de validação ou formatação.

```csharp
public class Produto
{
    // O campo real (field) é privado, garantindo que o acesso direto não é permitido.
    private decimal _preco; 

    // A propriedade pública (property) é o ponto de acesso controlado.
    public decimal Preco
    {
        get { return _preco; }
        set 
        { 
            // Exemplo de regra de negócio: o preço não pode ser negativo
            if (value < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.");
            }
            _preco = value;
        }
    }
}

🤝 Contribuições
Sinta-se à vontade para sugerir melhorias, correções ou até mesmo expandir o projeto com outros conceitos de POO (como Herança ou Polimorfismo)!
1. Faça um Fork do projeto.
2. Crie uma nova branch (git checkout -b feature/NovaFuncionalidade).
3. Faça o Commit das suas alterações (git commit -m 'feat: Adiciona Nova Funcionalidade').
4. Faça o Push para a branch (git push origin feature/NovaFuncionalidade).
5. Abra um Pull Request.
