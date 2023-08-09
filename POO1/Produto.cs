using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Produto
    {

        public string Nome;
        public double Preco;
        public int Quantidade;

        // Métodos

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // Adicionar Produtos
        public void AdicionarProdutos()
        {
            Console.WriteLine($"{Environment.NewLine}----- \u001b[36mADICIONAR PRODUTO AO ESTOQUE\u001b[0m -----{Environment.NewLine}");
            Console.Write("Quantidade de Produtos a Serem adicionados ao estoque: ");

            // Validando Input

            bool validacaoQuantidade = false;
            do
            {
                try
                {
                    Console.Write("Digite a quantidade do produto: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    if (quantidade >= 0)
                    {
                        validacaoQuantidade = true;
                        Quantidade += quantidade;
                    }
                    else
                    {
                        Console.WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                }
            }
            while (!validacaoQuantidade);

            

            double valorFinal = ValorTotalEmEstoque();
            InformacoesEstoque();

        }

        // Remover Produtos

        public void RemoverProdutos()
        {

            Console.WriteLine($"{Environment.NewLine}----- \u001b[36mREMOVER PRODUTO DO ESTOQUE\u001b[0m -----{Environment.NewLine}");

            Console.Write("Quantidade de Produtos a Serem removidos do estoque: ");

            bool validacaoQuantidade = false;
            do
            {
                try
                {
                    Console.Write("Digite a quantidade do produto: ");
                    int quantidade = int.Parse(Console.ReadLine());
                    if (quantidade >= 0)
                    {
                        validacaoQuantidade = true;
                        Quantidade -= quantidade;
                    }
                    else
                    {
                        Console.WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                }
            }
            while (!validacaoQuantidade);

            if (Quantidade < 0)
            {
                Quantidade = 0;
            }

            double valorFinal = ValorTotalEmEstoque();
            InformacoesEstoque();

        }

        // Informações em Estoque

        public void InformacoesEstoque()
        {
            Console.WriteLine($"{Environment.NewLine}----- \u001b[36mINFORMAÇÕES SOBRE O ESTOQUE\u001b[0m -----{Environment.NewLine}");

            Console.WriteLine($"Produto: {Nome}");
            Console.WriteLine($"Valor Unitário: R$ {Preco.ToString("F2")}");
            Console.WriteLine($"Quantidade: {Quantidade}");
            Console.WriteLine($"Valor total: R$ {ValorTotalEmEstoque().ToString("F2")}");
        }

        // Selecionar Ações
        public void SelecionarAcao()
        {
            bool validacao = false;
            int valorSelecionado;

            do
            {
                Console.WriteLine($"\u001b[36m{Environment.NewLine}-------- ESCOLHER PRÓXIMA AÇÃO --------\u001b[0m{Environment.NewLine}");

                Console.WriteLine($"Selecione a ação indicando o número: {Environment.NewLine}");

                Console.WriteLine("1. Ver Estoque");
                Console.WriteLine("2. Adicionar ao Estoque");
                Console.WriteLine("3. Romover do Estoque");
                Console.WriteLine("4. Sair");
                Console.WriteLine();

                /*valorSelecionado = ;*/

                if (int.TryParse(Console.ReadLine(), out valorSelecionado) && valorSelecionado > 0 && valorSelecionado < 5)
                {
                    validacao = true;
                    Console.WriteLine("");
                    Console.Clear();


                    switch (valorSelecionado)
                    {
                        case 1:
                            InformacoesEstoque();
                            break;
                        case 2:
                            AdicionarProdutos();
                            break;
                        case 3:
                            RemoverProdutos();
                            break;
                        case 4:
                            Console.WriteLine("Você saiu e o sistema foi encerrado");
                            InformacoesEstoque();
                            break;
                        default:
                            Console.WriteLine("Valor Invalido");
                            break;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine($"\u001b[31mOops, tivemos um erro! Digite um valor válido{Environment.NewLine}\u001b[0m");
                }

            }
            while (!validacao || valorSelecionado != 4);
        }
    }
}
