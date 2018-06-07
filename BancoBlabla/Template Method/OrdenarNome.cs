using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoBlabla.Proxy;

namespace BancoBlabla.Template_Method
{
    public class OrdenarNome : OrdenadorTemplate
    {
        public override bool isPrimeiro(Cliente cliente1, Cliente cliente2)
        {
            if(String.Compare(cliente1.getNome(), cliente2.getNome(), true) > 0)
            {
                return true;
            }

            return false;
        }
    }
}
