using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoBlabla.Proxy;
using BancoBlabla.Template_Method;

namespace BancoBlabla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Factory Method
            Console.WriteLine(" ----  Faactory Method ---- ");
            IBanco banco = new BancoBanrisul();
            IConta conta = banco.CriaConta();
            conta.exibirDados();

            IBanco banco2 = new BancoCaixa();
            IConta conta2 = banco2.CriaConta();
            conta2.exibirDados();

            //Proxy Method
            Console.WriteLine(Environment.NewLine + " ----  Proxy Method ---- ");
            Funcionario funcionario = new Funcionario("Romulo", "Gerente");
            Funcionario funcionario1 = new Funcionario("Daniel", "Atendente de caixa");

            Console.WriteLine(funcionario.getSaldo());
            Console.WriteLine(funcionario1.getSaldo());

            Console.ReadKey();

            //Template Method
            Console.WriteLine(Environment.NewLine + " ----  Template Method ---- ");
            ListarClientes listarClientes = new ListarClientes(ModoDeBusca.porNome);
            listarClientes.addCliente("Romulo");
            listarClientes.addCliente("Ana");
            listarClientes.addCliente("Daniela");

            Console.WriteLine("Listar por nome:");
            listarClientes.exibirClientes();

            Console.WriteLine(Environment.NewLine + "Listar por idade:");
            listarClientes.SetModo(ModoDeBusca.porIdade);
            listarClientes.exibirClientes();

            //Strategy
            Console.WriteLine(Environment.NewLine + " ----  Strategy ---- ");
            Console.WriteLine(funcionario.getNome() + "- salario com imposto: " + funcionario.CalculoSalarioJuros());
            //vai printar saldo 0 pois o ele é um atendente de caixa, e não pode acessar o saldo
            Console.WriteLine(funcionario1.getNome() + "- salario com imposto: " + funcionario1.CalculoSalarioJuros());

            Console.ReadKey();
        }
    }
}
