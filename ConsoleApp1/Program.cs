﻿using System;
using FuncoesGenericas;
using System.Collections.Generic;
using CadFuncionario;
using NegFuncionario;

namespace ConsoleApp1
{
    class Program
    {
        public enum EnumAcao { AnulaZero, Consultar, Inserir, Excluir };

        static void Main(string[] args)
        {
            string result = "";
            var contador = 0;
            var acao = 0;
            string Dados = "";

            #region Entrada
            while (result == "")
            {
                Console.WriteLine("O que deseja fazer:" + "\n" +
                                "    [1 - Consultar um Funcionario], " + "\n" +
                                "    [2 - Inserir um Funcionario], " + "\n" +
                                "    [3 - Excluir um Funcionario]");

                result = Console.ReadLine();
            }
            acao = Convert.ToInt32(result);
            #endregion

            if (acao == Convert.ToInt32(EnumAcao.Inserir))
            {


            }

            if (acao == Convert.ToInt32(EnumAcao.Consultar))
            {
                #region Consulta

                var ret = NegFuncionario.Consulta.ConsultaFuncionario();
                Dados = "";

                contador = 0;
                foreach (var item in ret)
                {
                    contador++; //Soma 1 sempre que passar aqui

                    if (contador > 1)
                    {
                        Dados = Dados + "\n" + "\n" + "======================================" + "\n" + "\n";
                    }
                    else
                    {
                        Dados = Dados + "\n";
                    }

                    Dados =
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

                if (Dados == "")
                {
                    Dados = "Registro não Encontrado!";
                }
                #endregion

                Console.WriteLine(Dados);
                Console.ReadKey();
            }

            if (acao == Convert.ToInt32(EnumAcao.Excluir))
            {
                #region Exclusao
                Funcionario objDados = new Funcionario();

                result = "";
                while (result == "")
                {
                    Console.WriteLine("Informe o Codigo do Funcionario: ");
                    result = Console.ReadLine();
                }
                objDados.FuncionarioID = Convert.ToInt32(result);

                var ret = NegFuncionario.Exclui.ExcluirPeloId(objDados.FuncionarioID);
                #endregion

                if (ret)
                {
                    Console.WriteLine("Funcionario Excluido com Sucesso: ");
                }
                else
                {
                    Console.WriteLine("Erro na exclusão: ");
                }

                result = Console.ReadLine();

            }

        }
    }
}
