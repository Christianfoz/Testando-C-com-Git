using BrincandoComC.model;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace BrincandoComC {
    class Program {
        static void Main(string[] args) {
            /* char opcao;
            int depositar = 0, sacar = 0;
            Conta conta = new Conta();
            Console.WriteLine("Entre com o numero de sua conta");
            conta.NumeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta");
            conta.Titular = Console.ReadLine();
            Console.WriteLine("Havera depósito inicial?");
            opcao = char.Parse(Console.ReadLine());
            switch (opcao) {
                case 's':
                case 'S':
                    Console.WriteLine("Quanto quer depositar?");
                    conta.Saldo = int.Parse(Console.ReadLine());
                    break;
                case 'n':
                case 'N':
                    break;
                default:
                    Console.WriteLine("Use apenas s/n");
                    break;
            }
            Console.WriteLine("Dados da conta");
            Console.WriteLine("Conta: {0} , Titular: {1} , Saldo : {2}", conta.NumeroConta, conta.Titular, conta.Saldo);
            Console.WriteLine("Entre com um valor pra depositar");
            depositar = int.Parse(Console.ReadLine());
            conta.depositar(depositar);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine("Conta: {0} , Titular: {1} , Saldo : {2}", conta.NumeroConta, conta.Titular, conta.Saldo);
            Console.WriteLine("Entre com um valor pra sacar");
            sacar = int.Parse(Console.ReadLine());
            conta.sacar(sacar);
            Console.WriteLine("Dados da conta atualizados");
            Console.WriteLine("Conta: {0} , Titular: {1} , Saldo : {2}", conta.NumeroConta, conta.Titular, conta.Saldo);

            */

            /*

            int qtde,id,porcentagem,a;
            List<Funcionario> funcionarios = new List<Funcionario>();
            Console.WriteLine("Deseja adicionar quantos funcionarios?");
            qtde = int.Parse(Console.ReadLine());
            for(int i = 0; i < qtde; i++) {
                Funcionario f = new Funcionario();
                Console.WriteLine("Empregado " + (i + 1));
                Console.WriteLine("Id");
                f.IdFuncionario = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome");
                f.Nome = Console.ReadLine();
                Console.WriteLine("Salario");
                f.Salario = int.Parse(Console.ReadLine());
                funcionarios.Add(f);
                Console.WriteLine("--------------------------------");
            }

            Console.WriteLine("Entre com o id do funcionario a receber aumento");
            id = int.Parse(Console.ReadLine());
            Funcionario selecionado = funcionarios.Find(x => x.IdFuncionario == id);
            if (selecionado == null) {
                Console.WriteLine("Funcionario nao encontrado");
            }
            Console.WriteLine("Porcentagem de aumento: ");
            porcentagem = int.Parse(Console.ReadLine());
            selecionado = selecionado.aumentarSalario(selecionado, porcentagem);
            funcionarios.Remove(funcionarios.Find(x => x.IdFuncionario == id));
            funcionarios.Add(selecionado);
            Console.WriteLine("Lista atualizada de funcionarios");
            foreach(Funcionario f in funcionarios) {
                Console.WriteLine("Id : " + f.IdFuncionario + ", " + f.Nome + ", " + f.Salario);
            }

         */

            int linhas, colunas, k = 0;
            Console.WriteLine("Quantas linhas tem?");
            linhas = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantas colunas tem?");
            colunas = int.Parse(Console.ReadLine());
            int[,] mat = new int[linhas, colunas];
            for (int i = 0; i < linhas; i++) {
                for(int j = 0; j < colunas; j++) {
                    Console.WriteLine("["+i+"]"+"["+j +"]");
                    mat[i, j] = int.Parse(Console.ReadLine());  
                }
            }
            Console.WriteLine("Matriz");
            for (int i = 0; i < linhas; i++) {
                Console.WriteLine();
                for (int j = 0; j < colunas; j++) {
                    Console.Write(mat[i,j] + " ");
                    if(mat[i,j] < 0) {
                        k++;
                    }
                }
            }

            Console.WriteLine("\nDiagonal Principal");
            for (int i = 0; i < linhas; i++) {
                for (int j = 0; j < colunas; j++) {
                    if(i == j) {
                        Console.Write(mat[i, j] + " ");
                    }
                }
            }

            Console.WriteLine("\nQuantidade de numeros negativos: " + k);
            Console.WriteLine();
        }

        

    }
}
