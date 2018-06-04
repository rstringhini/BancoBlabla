using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBlabla
{
    public class ContaCorrente
    {

        protected Object sync;
        protected float saldo;
        protected float poupanca;
        protected float limite;
        protected float fatura;
        protected Pessoa pessoa;

        public ContaCorrente(Pessoa pessoa)
        {

            this.pessoa = pessoa;
            
            this.sync = new Object(); // objeto para sincronizar deposito e saque (1 acesso por vez)

            
        }

        private bool Deposito(float quantia)
        {

            lock (sync)
            {
                saldo += quantia;
                return true;
            }
    
        }

        private float Saque(float quantia)
        {
            lock (sync)
            {
                if (quantia > saldo) return 0;

                saldo -= quantia;
                return quantia;
            }
        }



    }
}
