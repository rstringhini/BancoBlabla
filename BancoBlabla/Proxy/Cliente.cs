using BancoBlabla.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoBlabla.Proxy
{
    public class Cliente
    {
        protected ICalculoJuros calculo;
        private String nome;
        private int idade;
        private double saldo;
        private String senha;

        public Cliente(String nome)
        {
            this.idade = nome.Length + 20;
            this.nome = nome;
            this.saldo = (new Random((int)DateTime.Now.Ticks).NextDouble()*50) + 100;
            this.calculo = new CalculoJuros();
        }

        //funcao para usar no Strategy
        public double CalculoSalarioJuros() => calculo.CalculaJuros(this);

        //funcao do proxy e template method
        public int getIdade() => idade;
        public virtual double getSaldo() => saldo;        
        public virtual String getSenha() => senha;
        public String getNome() => nome;
    }
}
