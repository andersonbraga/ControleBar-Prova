using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public Produto(string NomeProduto, string Valor)
        {
            this.NomeProduto = NomeProduto;
            this.Valor = Valor; 
        }

        public string NomeProduto { get; set; }
        public string Valor { get; set; }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Produto produtoAtualizado = (Produto)registroAtualizado;

            this.NomeProduto = produtoAtualizado.NomeProduto;
            this.Valor = produtoAtualizado.Valor;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if(string.IsNullOrEmpty(NomeProduto.Trim()))
            {
                erros.Add($"o nome do produto é obrigatorio {NomeProduto}");
            }
            if (string.IsNullOrEmpty(Valor.Trim()))
            {
                erros.Add($"o valor do produto é obrigatorio {Valor}");
            }

            return erros;
        }
    }


}
