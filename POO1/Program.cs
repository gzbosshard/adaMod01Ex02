using System.Security.Cryptography.X509Certificates;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new();
            /*Validar validar = new();*/

            Console.WriteLine($"{Environment.NewLine}----- \u001b[36mCONTROLE DE ESTOQUE\u001b[0m -----{Environment.NewLine}");


            // Inserindo informações sobre o produto

            Console.Write("Digite o nome do produto: ");

            produto.Nome = Console.ReadLine();

            Validacao("preco");

            Validacao("quantidade");

            // Imprimindo as Informações

            produto.InformacoesEstoque();

            // Outras Ações

            produto.SelecionarAcao();

            // Validação

            void Validacao(string tipo)
            {

                bool validacaoPreco = false;
                bool validacaoQuantidade = false;

                switch (tipo)
                {
                    case "preco":
                        do
                        {
                            try
                            {
                                Console.Write("Digite o preço do produto (R$): ");
                                produto.Preco = double.Parse(Console.ReadLine());
                                if (produto.Preco >= 0)
                                {
                                    validacaoPreco = true;
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
                        while (!validacaoPreco);
                        break;

                    case "quantidade":
                        do
                        {
                            try
                            {
                                Console.Write("Digite a quantidade do produto: ");
                                produto.Quantidade = int.Parse(Console.ReadLine());
                                if (produto.Quantidade >= 0)
                                {
                                    validacaoQuantidade = true;
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
                        break;
                    default: Console.WriteLine("Digite um Valor válido"); break;

                }
            }


            Console.ReadKey();
        }
    }
}