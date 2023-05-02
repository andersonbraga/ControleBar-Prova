using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloPedido
{
    public class RepositorioPedido : RepositorioBase
    {
        public RepositorioPedido(ArrayList listaPedido)
        {
            this.listaRegistros = listaPedido;
        }

        public override Pedido SelecionarPorId(int id)
        {
            return (Pedido)base.SelecionarPorId(id);
        }

        public ArrayList SomarPedidos()
        {
            ArrayList totalPedidos = new ArrayList();

            foreach (Pedido pedido in listaRegistros)
            {
                //pedido.AdicionarTotalProduto(pedido);
                totalPedidos.Add(pedido.TotalPedido);
            }
           return totalPedidos;
        }

        


    }
}
