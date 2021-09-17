using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class ContaCorrente : ContaBancaria
    {
        public decimal ValorTaxManutencao { get; private set; }
        public decimal Limite { get; private set; }
        public ContaCorrente(Cliente cliente, decimal limite) : base(cliente)
        {
            ValorTaxManutencao = 0.05M;
            Limite = limite;
        }
        public override void Sacar(decimal valor, string senha)
        {
            if (Senha != senha)
            {
                throw new Exception("Senha invalida.");
            }
            if ((Saldo + Limite) < valor)
            {
                throw new Exception("Saldo insuficiente.");
            }
            Saldo -= valor;
        }
    }
}
