using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoBlabla.Proxy;
namespace BancoBlabla.Template_Method
{
    public abstract class OrdenadorTemplate
    {
        public abstract bool isPrimeiro(Cliente cliente1, Cliente cliente2);

        public List<Cliente> ordenarCliente(List<Cliente> clientes)
        {
            List<Cliente> ordenados = new List<Cliente>();
            ordenados.AddRange(clientes);

            for(int i = 0; i < ordenados.Count; i++)
            {
                for(int j = i; j < ordenados.Count; j++)
                {
                    if(isPrimeiro(ordenados[i], ordenados[j]))
                    {
                        Cliente temp = ordenados[j];
                        ordenados[j] = ordenados[i];
                        ordenados[i] = temp;
                    }
                }
            }

            return ordenados;
        }
    }
}
