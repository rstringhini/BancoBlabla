using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBlabla
{
    public class Pessoa
    {

        protected String nome;
        protected int cpf;
        protected int identidade;
        protected String endereco;


        public Pessoa(String nome, int cpf, int identidade, String endereco)
        {

            this.nome = nome;

            this.cpf = cpf;

            this.identidade = identidade;

            this.endereco = endereco;

        }

        
    }
}
