using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloConta
{
    public class RepositorioConta : RepositorioBase
    {
        public RepositorioConta(ArrayList listaConta)
        {
            this.listaRegistros = listaConta;
        }

        public override Conta SelecionarPorId(int id)
        {
            return (Conta)base.SelecionarPorId(id);
        }

        public ArrayList SelecionarContaEmAberto()
        {
            ArrayList contaEmAberto = new ArrayList();

            foreach (Conta conta in listaRegistros)
            {
                if(conta.estaAberto)
                {
                    contaEmAberto.Add(conta);
                }
                
            }
            return contaEmAberto;
        }
    }
}
