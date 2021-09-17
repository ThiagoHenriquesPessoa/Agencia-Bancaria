using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Endereco endereco = new Endereco(
                    "Rua Cloves Cavalcante de Melo",
                    "59142240", "Parnamirim",
                    "Rio Grande do Norte");
                Cliente cliente = new Cliente(
                    "",
                    "06825786490",
                    "02543026",
                    endereco);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
