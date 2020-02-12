using System;
using System.Collections.Generic;
using System.Text;

namespace BrincandoComC.model {
    class Funcionario {
        private int idFuncionario;
        private string nome;
        private int salario;

        public int IdFuncionario {
            get {
                return idFuncionario;
            }
            set { idFuncionario = value; 
            }
        }

        public string Nome { get {
                return nome;
            }
            set { nome = value; 
            } 
        }

        public int Salario { get {
                return salario; 
            } set { 
                salario = value; 
            }
        }

        public Funcionario(int idFuncionario, string nome, int salario) {
            this.idFuncionario = idFuncionario;
            this.nome = nome;
            this.salario = salario;
        }

        public Funcionario() {

        }

        public Funcionario aumentarSalario(Funcionario selecionado, int porcentagem) {
            salario = (selecionado.Salario * (porcentagem / 100)) + selecionado.Salario;
            selecionado.Salario = salario;
            return selecionado;
            
        }


    }
}
