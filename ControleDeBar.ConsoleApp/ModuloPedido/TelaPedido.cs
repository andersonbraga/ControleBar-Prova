using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloPedido
{
    public class TelaPedido : TelaBase
    {
        private RepositorioPedido repositorioPedido;
        private TelaProduto telaProduto;
        private RepositorioProduto repositorioProduto;

        public TelaPedido(RepositorioPedido repositorioPedido)
        {
            this.repositorioPedido = repositorioPedido;
            nomeEntidade = "Pedido";
        }

        public TelaPedido(RepositorioPedido repositorioPedido,
            TelaProduto telaProduto, RepositorioProduto repositorioProduto)
        {
            this.repositorioBase = repositorioPedido;
            this.repositorioPedido = repositorioPedido;
            this.telaProduto = telaProduto;
            this.repositorioProduto = repositorioProduto;

            nomeEntidade = "Pedido";
        }

    

        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Pedido pedido in registros)
            {
                Console.WriteLine(pedido.id);
                Console.WriteLine(pedido.Produto);
                Console.WriteLine(pedido.TotalPedido);
                Console.WriteLine(pedido.QuantidadeProduto);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Produto produto = ObterProduto();
         

            Console.WriteLine("Digite o total do pedido");
            string totalPedido = Console.ReadLine();

            Console.WriteLine("Digite a quantidade dos produtos:");
            string quantidadeProduto = Console.ReadLine();
            return new Pedido(produto, quantidadeProduto, totalPedido);
        }

        private Produto ObterProduto()
        {
            telaProduto.VisualizarRegistros(false);

            Produto produto = (Produto)telaProduto.EncontrarRegistro("Digite o id do produto: ");

            Console.WriteLine();

            return produto;
        }
    }
}
