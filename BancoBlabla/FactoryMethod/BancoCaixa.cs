using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBlabla
{
    public class BancoCaixa : IBanco
    {
        public IConta CriaConta() => new ContaPoupanca();
    }
}
