using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SistemaDePedidos
{
    class Loja
    {
        Pedido linkClassPedido = new();
        Estagiario linkClassEstagiario = new();
        Gerente linkClassGerente = new();

        public static List<Pedido> listaPedido = new();
        

        // Criando o Método Menu()
        public void Menu()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("   Seja bem-vindo ao C# Sistema de Pedidos:  ");
            Console.WriteLine("----------------------------------------------");            
            
            int escolha = 0;
            
            while (escolha != 5)
            {
                Console.WriteLine(" 1 - INSERIR PEDIDO:");
                Console.WriteLine(" 2 - BUSCAR PEDIDO:");
                Console.WriteLine(" 3 - REMOVER PEDIDO:");
                Console.WriteLine(" 4 - VALOR TOTAL DOS PEDIDOS");
                Console.WriteLine(" 5 - SAIR:");
                Console.WriteLine();
                Console.Write("Escolha uma das opcões acima: ");
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.Clear();
                    InserirPedido();
                    break;
                }
                else if (escolha == 2)
                {
                    Console.Clear();
                    BuscaPedido();
                    break;
                }
                else if (escolha == 3)
                {
                    Console.Clear();
                    RemoverPedido();
                    break;
                }
                else if(escolha == 4)
                {
                    CalcularPrecoTotal();
                    break;
                }
                else if (escolha == 5)
                {
                    Console.Clear();
                    Console.WriteLine("Programa finalizado, volte sempre!");
                    Environment.Exit(0);                    
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("OPÇÃO INVÁLIDA, TENTE NOVAMENTE!");
                    Console.WriteLine();
                }
            }
                       
        }
        public void InserirPedido()
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("               INSERIR PEDIDO  ");
            Console.WriteLine("----------------------------------------------");

            linkClassPedido.DataEmissao = DateTime.Now.ToString("dd-MM-yyyy");
            
            Console.Write("INFORME A DESCRIÇÃO DO PRODUTO: ");
            linkClassPedido.DescricaoDoProduto = (Console.ReadLine().ToUpper().Trim());

            Console.Write("INFORME O VALOR DO PRODUTO: R$ ");
            linkClassPedido.ValorDoProduto = float.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("1 - CONFIRMAR PEDIDO");
            Console.WriteLine("2 - APLICAR DESCONTO PADRÃO");
            Console.WriteLine("3 - APLICAR DESCONTO GERENTE");

            Console.WriteLine();
            Console.Write("Escolha uma das opcões acima: ");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                CadastrarNaLista();
            }            
            else if (opcao == 2)
            {
                linkClassPedido.ValorDoProduto = (float)linkClassEstagiario.calcularDesconto((decimal)linkClassPedido.ValorDoProduto);
                CadastrarNaLista();
            }
            else if (opcao == 3)
            {
                Console.Write(" DIGITE A SENHA GERENTE: ");
                string SenhaDigitada = (Console.ReadLine());
                if (SenhaDigitada == linkClassGerente.Senha)
                {
                    linkClassPedido.ValorDoProduto = (float)linkClassGerente.calcularDesconto((decimal)linkClassPedido.ValorDoProduto);
                    CadastrarNaLista();
                }
                else
                {                    
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine("Senha inválida, refaça o pedido");
                    Console.WriteLine("----------------------------------------------");
                    Console.WriteLine();
                    Menu();
                }

            }
            else
            {
                return;
            }
        }
        public void BuscaPedido()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("               BUSCAR PEDIDO  ");
            Console.WriteLine("----------------------------------------------");

                foreach (Pedido pedido in listaPedido)
                {
                    Console.WriteLine($"Pedido nº: {pedido.PedidoId} \nData de Emissão: {pedido.DataEmissao}" +
                        $"\nDescrição do Produto: {pedido.DescricaoDoProduto}" +
                        $"\nValor do Produto: R$ {pedido.ValorDoProduto.ToString("F2", CultureInfo.InvariantCulture)}");
                    Console.WriteLine("----------------------------------------------");
                }

            Menu();
        }
        public void RemoverPedido()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("              REMOVER PEDIDO  ");
            Console.WriteLine("----------------------------------------------");

            Console.Write("DIGITE O Nº DO PEDIDO PARA REMOVÊ-LO: ");
            linkClassPedido.IDRemove = int.Parse(Console.ReadLine());

            Pedido toRemove = null;
            foreach (Pedido id in listaPedido)
            {
                if (id.PedidoId == linkClassPedido.IDRemove)
                {
                    toRemove = id;
                    break;
                }
            }
            if (toRemove != null)
            {
                listaPedido.Remove(toRemove);
            }
            Menu();
        }
        public void CadastrarNaLista()
        {
            Console.Clear();

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("       PEDIDO REGITRADADO COM SUCESSO  ");
            Console.WriteLine("----------------------------------------------");
            //Criar objeto (pedido)
            Pedido pedido = new()
            {
                //Adicionando o que o objeto (pedido) vai receber
                PedidoId = linkClassPedido.PedidoId++,
                DataEmissao = linkClassPedido.DataEmissao,
                DescricaoDoProduto = linkClassPedido.DescricaoDoProduto,
                ValorDoProduto = linkClassPedido.ValorDoProduto
            };

            //Adicionar o pedido na lista
            listaPedido.Add(pedido);

            linkClassPedido.CalculoValorTotal += linkClassPedido.ValorDoProduto;

            Menu();
        }
        public void CalcularPrecoTotal()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"O VALOR DO TOTAL É DE R$ {linkClassPedido.CalculoValorTotal.ToString("F2", CultureInfo.InvariantCulture)}");
            Menu();
        }
}
}
