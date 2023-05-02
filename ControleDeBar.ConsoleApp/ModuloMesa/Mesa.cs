using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloMesa
{
    public class Mesa : EntidadeBase
    {
        // Conta Pedido Status Numero
        public string NumeroMesa { get; set; }
        public Mesa(string numeroMesa)
        {
            NumeroMesa = numeroMesa;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Mesa mesaAtualizada = (Mesa)registroAtualizado;

            this.NumeroMesa = mesaAtualizada.NumeroMesa;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

         

            if (string.IsNullOrEmpty(NumeroMesa.Trim()))
            {
                erros.Add($"o numero da mesa é obrigatorio {NumeroMesa}");
            }
            return erros;
        }
    }
}
