using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBlabla
{
    public class BancoBanrisul : IBanco
    {
        protected List<IConta> clientes;
        public BancoBanrisul()
        {

        }
        public IConta CriaConta() => new ContaCorrente();
    }
}
