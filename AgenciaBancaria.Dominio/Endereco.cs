using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Endereco
    {
        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }

        public Endereco(string logradouro, string cep, string cidade, string estado)
        {
            Logradouro = logradouro.ValidacaoString();
            CEP = cep.ValidacaoString();
            Cidade = cidade.ValidacaoString();
            Estado = estado.ValidacaoString();
        }
    }
}
