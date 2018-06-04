using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBlabla
{
    class Gerente : Pessoa
    {

        protected int cod;

        public Gerente(int cod, string nome, int cpf, int identidade, string endereco) : base(nome, cpf, identidade, endereco)
        {

            this.cod = cod;

        }
    }
}
