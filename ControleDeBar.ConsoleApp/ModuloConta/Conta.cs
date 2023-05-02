using ControleDeBar.ConsoleApp.Compartilhado;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloPedido;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class Conta : EntidadeBase
    {
        public Garcom Garcom { get; set; }
        public Pedido Pedido { get; set; }

        public string Total { get; set; }


        public Conta(Garcom garcom, Pedido pedido, string total)
        {
            this.Garcom = garcom;
            this.Pedido = pedido;
            this.Total = total;
            estaAberto = true;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Conta contaAtualizada = (Conta)registroAtualizado;

            this.Pedido = contaAtualizada.Pedido;
            this.Garcom = contaAtualizada.Garcom;
            this.Total = contaAtualizada.Total;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if (string.IsNullOrEmpty(Total))
                erros.Add("O campo \"Garcom\" é obrigatório");
            return erros;
        }

        public bool estaAberto;
        public void Fechar()
        {
            if (estaAberto)
            {
                estaAberto = false;
               
            }
        }

    
    }
}
