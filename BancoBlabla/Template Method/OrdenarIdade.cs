using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoBlabla.Proxy;

namespace BancoBlabla.Template_Method
{
    public class OrdenarIdade : OrdenadorTemplate
    {
        public override bool isPrimeiro(Cliente cliente1, Cliente cliente2)
        {
            if (cliente1.getIdade() > cliente2.getIdade())
            {
                return true;
            }

            return false;
        }
    }
}
