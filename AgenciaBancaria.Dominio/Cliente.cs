using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public Endereco Endereco { get; private set; }


        public Cliente(string nome, string cpf, string rg, Endereco endereco)
        {
            Nome = nome.ValidacaoString();
            CPF = cpf.ValidacaoString();
            RG = rg.ValidacaoString();
            Endereco = endereco ?? throw new Exception("Propriedade deve esta preenchida.");
        }     
                
    }
}
