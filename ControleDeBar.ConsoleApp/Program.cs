using ControleDeBar.ConsoleApp.ModuloConta;
using ControleDeBar.ConsoleApp.ModuloGarcom;
using ControleDeBar.ConsoleApp.ModuloMesa;
using ControleDeBar.ConsoleApp.ModuloPedido;
using ControleDeBar.ConsoleApp.ModuloProduto;
using System.Collections;

namespace ControleDeBar.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RepositorioMesa repositorioMesa = new RepositorioMesa(new ArrayList());
            RepositorioProduto repoositorioProduto = new RepositorioProduto(new ArrayList());
            RepositorioGarcom repositorioGarcom = new RepositorioGarcom(new ArrayList());
            RepositorioPedido repositorioPedido = new RepositorioPedido(new ArrayList());
            RepositorioConta repositorioConta = new RepositorioConta(new ArrayList());

            TelaMesa telaMesa = new TelaMesa(repositorioMesa);
            TelaProduto telaProduto = new TelaProduto(repoositorioProduto);
            TelaGarcom telaGarcom = new TelaGarcom(repositorioGarcom);
            TelaPedido telaPedido = new TelaPedido(repositorioPedido, telaProduto, repoositorioProduto);
            TelaConta telaConta = new TelaConta(repositorioConta, repositorioGarcom, repositorioPedido,telaGarcom, telaPedido);


            TelaPrincipal principal = new TelaPrincipal();

            while (true)
            {
                string opcao = principal.ApresentarMenu();

                if (opcao == "s")
                    break;

                if (opcao == "1")
                {
                    string subMenu = telaMesa.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaMesa.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaMesa.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaMesa.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaMesa.ExcluirRegistro();
                    }
                    continue;
                }

                if (opcao == "2")
                {
                    string subMenu = telaProduto.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaProduto.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaProduto.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaProduto.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaProduto.ExcluirRegistro();
                    }
                }
                if (opcao == "3")
                {
                    string subMenu = telaGarcom.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaGarcom.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaGarcom.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaGarcom.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaGarcom.ExcluirRegistro();
                    }
                }

                if (opcao == "4")
                {
                    string subMenu = telaPedido.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaPedido.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaPedido.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaPedido.EditarRegistro();
                    }
                    else if (subMenu == "4")
                    {
                        telaPedido.ExcluirRegistro();
                    }
                }
                if (opcao == "5")
                {
                    //Console.WriteLine("Digite 1 para Abrir Nova Conta");
                    //Console.WriteLine("Digite 2 para Visualizar Conta");
                    //Console.WriteLine("Digite 3 para Abrir Conta");
                    //Console.WriteLine("Digite 4 para Fechar Conta");
                    //Console.WriteLine("Digite 6 para Editar Conta");
                    //Console.WriteLine("Digite 7 para Excluir Coonta");
                    string subMenu = telaConta.ApresentarMenu();

                    if (subMenu == "1")
                    {
                        telaConta.InserirNovoRegistro();
                    }
                    else if (subMenu == "2")
                    {
                        telaConta.VisualizarRegistros(true);
                        Console.ReadLine();
                    }
                    else if (subMenu == "3")
                    {
                        telaConta.AbrirNovaConta();
                    }
                    else if (subMenu == "4")
                    {
                        telaConta.FecharConta();
                    }
                    else if (subMenu == "5")
                    {
                        telaConta.EditarRegistro();
                    }
                    else if (subMenu == "6")
                    {
                        telaConta.ExcluirRegistro();
                    }
                }

            }
        }
    }
}