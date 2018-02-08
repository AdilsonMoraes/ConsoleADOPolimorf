using System;
using FuncoesGenericas;
using System.Collections.Generic;
using CadFuncionario;
using Dao;

namespace ConsoleApp1
{
    class Program
    {
        public enum EnumAcao {AnulaZero, Consultar, Inserir, Excluir };

        static void Main(string[] args)
        {          
            string result = "";
            var acao = 0;

            while (result == "")
            {
                Console.WriteLine("O que deseja fazer:" + "\n" +
                                "[1 - Consultar um Funcionario], " + "\n" +
                                "[2 - Inserir um Funcionario], " + "\n" +
                                "[3 - Excluir um Funcionario]");
                result = Console.ReadLine();
            }
            acao = Convert.ToInt32(result);

            if (acao == Convert.ToInt32(EnumAcao.Inserir))
            {
                RetornaDados objDados = new RetornaDados();
                DateTime dtAdmissao = new DateTime(2018, 08, 02);

                result = "";
                while (result == "")
                {
                    Console.WriteLine("Informe o Nome: ");
                    result = Console.ReadLine();
                }
                objDados.Nome = result;

                result = "";
                while (result == "")
                {
                    Console.WriteLine("Informe o RG: ");
                    result = Console.ReadLine();
                }
                objDados.Rg = result;

                result = "";
                while (result == "")
                {
                    Console.WriteLine("Informe o CPF: ");
                    result = Console.ReadLine();
                }
                objDados.Cpf = result;

                result = "";
                while (result == "")
                {
                    Console.WriteLine("Informe o Email: ");
                    result = Console.ReadLine();
                }
                objDados.Email = result;

                result = "";
                while (result == "")
                {
                    Console.WriteLine("Informe o Telefone: ");
                    result = Console.ReadLine();
                }
                objDados.Telefone = result;

                result = "";
                while (result == "")
                {
                    Console.WriteLine("Informe o Cargo: ");
                    result = Console.ReadLine();
                }
                objDados.Cargo = result;

                result = "";
                while (result == "")
                {
                    Console.WriteLine("Informe o Nivel: ([1 - Junior], [2 - Pleno], [3 - Senior]): ");
                    result = Console.ReadLine();

                    bool validacao = Funcoes.ValidaNumero(result);
                    if (validacao == false)
                    {
                        Console.WriteLine("Informe o Nivel com Base em um Numero: ([1 - Junior], [2 - Pleno], [3 - Senior]): ");
                        result = "";
                    }
                }
                objDados.CodNivel = Convert.ToInt32(result);

                objDados.RetornaNivel();
                objDados.DataAdmissao = dtAdmissao;
                objDados.CalcularSalario();
                objDados.CalcularDissidio();
                objDados.CalcularBonus();


                Console.WriteLine("Dados Inseridos com Sucesso!");
                Console.ReadKey();

            }

            if (acao == Convert.ToInt32(EnumAcao.Consultar))
            {
                var ret = AcessObject.RecuperarLista();

                string Dados = "";
                var i = 0;

                foreach (var item in ret)
                {
                    i++;

                    if (i > 1)
                    {
                        Dados = Dados + "\n" + "\n" + "======================================" + "\n" + "\n";
                    }

                    Dados = "\n" +
                    Dados + "Nome: " + item.Nome + "\n"
                    + "Rg: " + item.Rg + "\n"
                    + "Cpf: " + item.Cpf + "\n"
                    + "Email: " + item.Email + "\n"
                    + "Telefone: " + item.Telefone + "\n"
                    + "--------------------------------------" + "\n"
                    + "Cargo: " + item.Cargo + "\n"
                    + "Nivel: " + item.Nivel + "\n"
                    + "Salario Mensal: " + item.SalarioInicial + "\n"
                    + "Data de Admissão: " + item.DataAdmissao + "\n"
                    + "Bonus por tempo de Trabalho: " + item.QtdeBonus;
                }                                                                       

                if(Dados=="")
                {
                    Dados = "Registro não Encontrado!";
                }


                Console.WriteLine(Dados);
                Console.ReadKey();
            }

            if (acao == Convert.ToInt32(EnumAcao.Excluir))
            {

            }

        }
    }
}
