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
    public class TelaConta : TelaBase
    {
        private RepositorioConta repositorioConta;
        private TelaGarcom telaGarcom;
        private TelaPedido telaPedido;
        private RepositorioGarcom repositorioGarcom;
        private RepositorioPedido repositorioPedido;
        public TelaConta(RepositorioConta repositorioConta, RepositorioGarcom repositorioGarcom, RepositorioPedido repositorioPedido,
            TelaGarcom telaGarcom, TelaPedido telaPedido)
        {
            this.repositorioBase = repositorioConta;
            this.repositorioConta = repositorioConta;
            this.repositorioPedido = repositorioPedido;
            this.repositorioGarcom = repositorioGarcom;

            this.telaPedido = telaPedido;
            this.telaGarcom = telaGarcom;

            nomeEntidade = "Conta";
        }

        public TelaConta(RepositorioConta repositorioConta)
        {
            this.repositorioConta = repositorioConta;
            nomeEntidade = "Conta";
        }

        public override string ApresentarMenu()
        {
            Console.Clear();

            Console.WriteLine("Cadastro de Emprestimos \n");

            Console.WriteLine("Digite 1 para Abrir Nova Conta");
            Console.WriteLine("Digite 2 para Visualizar Conta");
            Console.WriteLine("Digite 3 para Abrir Conta");
            Console.WriteLine("Digite 4 para Fechar Conta");
            Console.WriteLine("Digite 6 para Editar Conta");
            Console.WriteLine("Digite 7 para Excluir Coonta");

            Console.WriteLine("Digite s para Sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

        public void AbrirNovaConta()
        {
            base.InserirNovoRegistro();
        }

        public void FecharConta()
        {

            ArrayList contaEmAberto = repositorioConta.SelecionarContaEmAberto();

            if (contaEmAberto.Count == 0)
            {
                MostrarMensagem("Nenhuma conta cadastrado", ConsoleColor.DarkYellow);
                return;
            }

            Console.WriteLine("Digite o id da conta");
            int id = Convert.ToInt32(Console.ReadLine());

            Conta conta = repositorioConta.SelecionarPorId(id);

            conta.Fechar();
        }


        public override void InserirNovoRegistro()
        {
            bool temRegistros = repositorioPedido.TemRegistros();

            if (temRegistros == false)
            {
                MostrarMensagem("Cadastre ao menos um pedido para cadastrar uma conta", ConsoleColor.DarkYellow);
                return;
            }

            base.InserirNovoRegistro();
        }

        protected override void MostrarTabela(ArrayList registros)
        {
            foreach (Conta conta in registros)
            {
                string status = conta.estaAberto ? "Aberto" : "Fechado";
                Console.WriteLine(conta.id);
                Console.WriteLine(conta.Pedido);
                Console.WriteLine(conta.Total);
                Console.WriteLine(conta.Garcom.NomeGarcom);
                Console.WriteLine(conta.Pedido.id);
            }
        }

        public void VisualizarContaEmAberto()
        {
            ArrayList contaEmAberto = repositorioConta.SelecionarContaEmAberto();

            if(contaEmAberto.Count == 0)
            {
                Console.WriteLine("Nenhuma conta cadastrada");
                return;
            }
        }

        protected override EntidadeBase ObterRegistro()
        {
            telaPedido.VisualizarRegistros(false);

            Console.WriteLine("Digite id do pedido");
            int idPedido = Convert.ToInt32(Console.ReadLine());
            Pedido pedido = repositorioPedido.SelecionarPorId(idPedido);

            telaGarcom.VisualizarRegistros(false);
            Console.WriteLine("Digite id do garcom");
            int idGarcom = Convert.ToInt32(Console.ReadLine());
            Garcom garcom = repositorioGarcom.SelecionarPorId(idGarcom);

            Console.WriteLine("Valor total:");
            string valorTotal = Console.ReadLine();

            Conta conta = new Conta(garcom, pedido, valorTotal);

            return conta;



        }
    }
}
