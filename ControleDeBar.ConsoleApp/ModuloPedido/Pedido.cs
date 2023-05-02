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
    public class Pedido : EntidadeBase
    {
        public string TotalPedido { get; set; }
        public Produto Produto { get; set; }
        public string QuantidadeProduto { get; set; }
        public Pedido(Produto produto)
        {
            this.Produto = produto;
            
            
        }

        public Pedido(Produto produto, string quantidadeProduto, string totalProduto)
        {
            this.Produto = produto;
            this.TotalPedido = totalProduto;
            this.QuantidadeProduto = quantidadeProduto;


        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Pedido pedidoAtualizado =  (Pedido)registroAtualizado;

            
            this.Produto = pedidoAtualizado.Produto;
            this.TotalPedido = pedidoAtualizado.TotalPedido;
            this.QuantidadeProduto = pedidoAtualizado.QuantidadeProduto;
        }

        public void AdicionarQuantidadeProduto(int quantidade)
        {
            this.QuantidadeProduto += quantidade;
        }

        public void AdicionarTotalProduto( )
        {
            int pedido = 0;
            this.TotalPedido += pedido;
        }

       
    }
}
