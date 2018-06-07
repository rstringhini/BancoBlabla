using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBlabla.Proxy
{
    public class Funcionario : Cliente
    {
        protected String funcao;

        public Funcionario(String nome, String funcao) : base(nome)
        {
            this.funcao = funcao;
        }

        public override double getSaldo()
        {
            if (Permissao())
                return base.getSaldo();

            return 0f;
        }

        public override String getSenha()
        {
            if (Permissao())
                return base.getSenha();

            return null;
        }

        private bool Permissao()
        {
            return funcao.Equals("Gerente");
        }
    }
}
