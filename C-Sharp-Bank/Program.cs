using System;
using System.Globalization;

namespace C_Sharp_Bank {
    class Program {
        static void Main(string[] args) {
            Console.Write("Informe o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Informe o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());

            double saldo = 0;

            if (depositoInicial == 's' || depositoInicial == 'S') {
                Console.Write("Informe o valor de depósito inicial: R$ ");
                saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            Conta c1 = new Conta(numero, titular, saldo);
            
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta {c1.Numero}, Titular: {c1.Titular}, Saldo: R$ {c1.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.Write("Informe o valor do depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Deposito(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta {c1.Numero}, Titular: {c1.Titular}, Saldo: R$ {c1.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine();
            Console.Write("Informe o valor do saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Saque(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta {c1.Numero}, Titular: {c1.Titular}, Saldo: R$ {c1.Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
