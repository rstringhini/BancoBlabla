using BancoBlabla.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBlabla.Strategy
{
    public class CalculoJuros : ICalculoJuros
    {
        public double CalculaJuros(Cliente conta)
        {
            if (conta.getSaldo() > 1500)
                return conta.getSaldo() * 0.85;

            return conta.getSaldo() * 0.9;
        }
    }
}
