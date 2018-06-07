using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBlabla
{
    public class ContaCorrente : IConta
    {
        public void exibirDados() => Console.WriteLine("Conta Corrente.");
    }
}
