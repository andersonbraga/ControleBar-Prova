using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloGarcom
{
    public class Garcom : EntidadeBase
    {
        public string NomeGarcom { get; set; }

        public Garcom(string nomeGarcom)
        {
            this.NomeGarcom = nomeGarcom;
        }

        public override void AtualizarInformacoes(EntidadeBase registroAtualizado)
        {
            Garcom garcomAtualizado = (Garcom)registroAtualizado;

            this.NomeGarcom = garcomAtualizado.NomeGarcom;
        }

        public override ArrayList Validar()
        {
            ArrayList erros = new ArrayList();

            if(string.IsNullOrEmpty(NomeGarcom.Trim()))
            {
                erros.Add("O campo \"NomeGarcom\" é obrigatório");
            }
            return erros;
        }
    }
}
