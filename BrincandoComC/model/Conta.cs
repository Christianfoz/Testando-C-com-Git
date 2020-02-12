using System;
using System.Collections.Generic;
using System.Text;

namespace BrincandoComC.model {
    class Conta {
        private int numeroConta = 0;
        private int saldo = 0;
        private string titular;

        public int NumeroConta {
            get { 
                return numeroConta; 
            }
            set {
                if (numeroConta.Equals(0)) {
                    this.numeroConta = value;
                }
                else {

                }
            }
        }

        public string Titular {
            get {
                return titular;
            }
            set {
                this.titular = value;
            }
        }

        public int Saldo { get => saldo; set => saldo += value; }

        public Conta(int numeroConta, string titular, int saldo) {
            this.numeroConta = numeroConta;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public Conta(int numeroConta, string titular) {
            this.numeroConta = numeroConta;
            this.Titular = titular;
        }

        public Conta() {

        }

        public void depositar(int dinheiro) {
            saldo = saldo + dinheiro;
        }

        public void sacar(int saque) {
            saldo = (saldo - saque) - 5;
        }
    }
}
