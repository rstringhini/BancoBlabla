using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoBlabla.Proxy;

namespace BancoBlabla.Template_Method
{
    public class ListarClientes
    {
        protected List<Cliente> clientes;
        protected OrdenadorTemplate ordenador;

        public ListarClientes(ModoDeBusca modo)
        {
            clientes = new List<Cliente>();
            switch (modo)
            {
                case ModoDeBusca.porIdade:
                    ordenador = new OrdenarIdade();
                    break;
                case ModoDeBusca.porNome:
                    ordenador = new OrdenarNome();
                    break;
                default:
                    break;
            }
        }

        public void SetModo(ModoDeBusca modo)
        {
            ordenador = null;
            switch (modo)
            {
                case ModoDeBusca.porIdade:
                    ordenador = new OrdenarIdade();
                    break;
                case ModoDeBusca.porNome:
                    ordenador = new OrdenarNome();
                    break;
                default:
                    break;
            }
        }

        public void addCliente(String nome)
        {
            clientes.Add(new Cliente(nome));
        }

        public void exibirClientes()
        {
            List<Cliente> list = new List<Cliente>();
            list = ordenador.ordenarCliente(clientes);

            foreach(Cliente c in list)
            {
                Console.WriteLine("Nome: " + c.getNome() + "  Idade: " + c.getIdade());
            }
        }
    }
}
