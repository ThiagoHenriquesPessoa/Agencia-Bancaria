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
        public ContaCorrente(Cliente cliente) : base(cliente)
        {
            ValorTaxManutencao = 0.05M;
        }
    }
}
