using System;
using System.Globalization;

namespace ContaBancaria {
    class DadosConta {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Saldo { get; private set; }

        public DadosConta(int numero, string nome) {
            Numero = numero;
            Nome = nome;
        }

        public DadosConta(int numero, string nome, double saldo) : this(numero, nome) {
            Saldo = saldo;
        }

        public void Deposito(double quant) {
            Saldo += quant;
        }

        public void Saque(double quant) {
            Saldo -= quant + 5.00;
        }

        public override string ToString() {
            return "Conta "
                + Numero
                + ", Titular: "
                + Nome
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
