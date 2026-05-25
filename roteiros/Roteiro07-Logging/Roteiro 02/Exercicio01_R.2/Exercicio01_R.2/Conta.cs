using System;
using System.Collections.Generic;
using System.Text;
using NLog;

namespace Exercicio01a07_R2
{
    internal class Conta
    {
        public decimal Saldo { get; private set; }

        public Conta(decimal saldo)
        {
            Saldo = saldo;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor de depósito inválido");

            Saldo += valor;
        }

        public void Sacar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("Valor de saque inválido");

            if (Saldo < valor)
                throw new Exception("Saldo insuficiente");

            Saldo -= valor;
        }

        public void Transferir(Conta destino, decimal valor)
        {
            if (destino == null)
                throw new ArgumentException("Conta destino inválida");

            Sacar(valor);
            destino.Depositar(valor);
        }
    }
}
