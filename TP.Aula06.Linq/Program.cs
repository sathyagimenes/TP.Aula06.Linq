using static System.Console;
using System.Linq;

namespace TP.Aula06.Linq
{

    class Program
    {
        private static List<Produto> listaProdutos = new(){
            new Produto{Id = 2, Nome = "Camiseta", Valor = 52, Ativo = true},
            new Produto{Id = 8, Nome = "Guarda-Chuva", Valor = 19, Ativo = true},
            new Produto{Id = 4, Nome = "Celular", Valor = 8500, Ativo = true},
            new Produto{Id = 3, Nome = "Arroz", Valor = 21, Ativo = false},
            new Produto{Id = 1, Nome = "Geladeira", Valor = 1900, Ativo = true},
            new Produto{Id = 9, Nome = "Panela", Valor = 41, Ativo = true},
            new Produto{Id = 5, Nome = "Chinelo", Valor = 11, Ativo = false},
            new Produto{Id = 7, Nome = "TV", Valor = 2350, Ativo = true},
            new Produto{Id = 6, Nome = "Patins", Valor = 66, Ativo = true},
        };

        //Questão 1
        // Utilizando a fonte de dados disponibilizada, crie um método que
        // retorne uma lista de produtos cuja última letra do nome é a vogal "O".
        public static List<Produto> RetornaProdutoFinalLetraO()
        {
            return listaProdutos.Where(prod => prod.Nome.ToLower().EndsWith("o")).ToList();
        }

        //Questão 2
        // Utilizando a fonte de dados disponibilizada,crie um método que
        // retorne a quantidade de produtos cujo valor é menor que 50 reais.
        public static int RetornaQuantidadeProdutoMenorQue50()
        {
            return listaProdutos.Where(prod => prod.Valor < 50).Count();
        }

        // Questão 3
        // Utilizando a fonte de dados disponibilizada, crie um método que
        // retorne a média de preço dos produtos inativos.
        public static string RetornaMediaProdutosInativos()
        {
            return listaProdutos.Where(prod => prod.Ativo == false).Average(prod => prod.Valor).ToString();
        }

        //Questão 4
        //Utilizando a fonte de dados disponibilizada, crie um método que retorne o
        //primeiro produto com valor inferior à 10 reais.Retorne nulo se não existir.
        public static string RetornaPrimeiroProdutosMenor10()
        {
            try
            {
                return listaProdutos.FirstOrDefault(prod => prod.Valor < 10).ToString();
            }
            catch (Exception)
            {
                return "null";
            }
        }

        //Questão 5
        // Utilizando a fonte de dados disponibilizada, crie um método que ordene os
        // produtos por Nome, em ordem decrescente, e retorne o último elemento da lista.
        public static Produto RetornaUltimoProduto()
        {
            return listaProdutos.OrderByDescending(prod => prod.Nome).LastOrDefault();
        }

        //Questão 6
        // Utilizando a fonte de dados disponibilizada, crie um método que permita a
        // alteração dos valores dos produtos. Esse método irá receber o Id e o novo
        // valor e irá realizar a atualização. Caso o Id não exista, exiba uma mensagem.
        public static void AlterarValor(int id, decimal valor)
        {
            try
            {
                Produto prod = listaProdutos.Where(prod => prod.Id == id).SingleOrDefault();
                prod.Valor = valor;
                WriteLine("Alteração realizada com sucesso");
            }
            catch (Exception)
            {
                WriteLine($"Id {id} não encontrado");
            }
        }

        static void Main(string[] args)
        {
            WriteLine("Questão 1: ");
            var resultado = RetornaProdutoFinalLetraO();
            foreach (var res in resultado)
            {
                WriteLine(res);
            }
            WriteLine("Questão 2: " + RetornaQuantidadeProdutoMenorQue50());
            WriteLine("Questão 3: " + RetornaMediaProdutosInativos());
            WriteLine("Questão 4: " + RetornaPrimeiroProdutosMenor10());
            WriteLine("Questão 5: " + RetornaUltimoProduto().ToString());
            WriteLine("Questão 6: ");
            Write("Qual o id? ");
            int id = Convert.ToInt32(ReadLine());
            Write("Qual o valor? ");
            decimal valor = Convert.ToDecimal(ReadLine());
            AlterarValor(id, valor);
        }
    }
}
