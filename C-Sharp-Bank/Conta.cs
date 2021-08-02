using System;

namespace C_Sharp_Bank {
    class Conta {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; private set; }
        private double taxaSaque = 5.00;

        public Conta(int numero, string titular) {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double saldo) : this(numero, titular) {
            Saldo = saldo;
        }

        public void Deposito(double valor) {
            if (valor > 0) {
                Saldo += valor;
            } else {
                Console.WriteLine("Não é possível realizar o depósito de um valor negativo.");
            }
        }

        public void Saque(double valor) {
            if (valor > 0 && Saldo > valor) {
                Saldo -= (valor + taxaSaque);
            } else {
                Console.WriteLine("Não é possível realizar este saque.");
            }
        }
    }
}
