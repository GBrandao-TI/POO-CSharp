using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseConta
{
    public class Conta
    {
        //declarar atributos
        public int numero;
        public string titular;
        public double saldo;


        //declaração dos métodos

        public void Sacar(double valorSaque)
        {
            saldo = saldo - valorSaque;
            //saldo -= valorSaque; 
        }

        public void Depositar(double valorDeposito)
        {
            saldo += valorDeposito;
        }

        public void MostrarAtributos()
        {
            Console.WriteLine("Número: " + numero + "\t Titular: " + titular + "\t Saldo: " + saldo);
        }
    }
}