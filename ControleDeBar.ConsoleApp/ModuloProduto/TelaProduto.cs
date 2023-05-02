using ControleDeBar.ConsoleApp.Compartilhado;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeBar.ConsoleApp.ModuloProduto
{
    public class TelaProduto : TelaBase
    {
        public TelaProduto(RepositorioProduto repositorioProduto)
        {
            this.repositorioBase = repositorioProduto;
            nomeEntidade = "Produto";
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Produto produto in registros)
            {
                Console.WriteLine(produto.id);
                Console.WriteLine(produto.NomeProduto);
                Console.WriteLine(produto.Valor);
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            Console.WriteLine("Digite o nome do produto");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Digite o valor do produto ");
            string valorProduto = Console.ReadLine();   

            return new Produto(nomeProduto, valorProduto);
        }


    }
}
