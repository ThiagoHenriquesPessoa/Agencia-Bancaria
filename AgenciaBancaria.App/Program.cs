﻿using AgenciaBancaria.Dominio;
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
                    "Thiago",
                    "06825786490",
                    "02543026",
                    endereco);
                ContaCorrente conta = new ContaCorrente(cliente);

                Console.WriteLine("conta: " +conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

                conta.Abrir("Abcde123");

                Console.WriteLine("conta: " + conta.Situacao + ": " + conta.NumeroConta + "-" + conta.DigitoVerificador);

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
