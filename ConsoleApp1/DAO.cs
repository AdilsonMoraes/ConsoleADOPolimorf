using CadFuncionario;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace Dao
{
    public class AcessObject //Acesso a dados
    {
        public static List<Funcionario> RecuperarLista()
        {
            var ret = new List<Funcionario>();

            using (var conexao = new SqlConnection())
            {
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["principal"].ToString();
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format(
                        "SELECT Nome,     Rg,    Cpf,   Email, " +
                               "Telefone, Cargo, Nivel, SalarioInicial , " +
                               "DataAdmissao, QtdeBonus " +
                               "FROM FUNCIONARIO F INNER JOIN PESSOA P ON F.PESSOAID = P.PESSOAID");
                    var reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        ret.Add(new Funcionario
                        {
                            Nome = (string)reader["nome"],
                            Rg = (string)reader["Rg"],
                            Cpf = (string)reader["CPF"],
                            Email = (string)reader["EMAIL"],
                            Telefone = (string)reader["TELEFONE"],
                            Cargo = (string)reader["CARGO"],
                            Nivel = (string)reader["NIVEL"],
                            SalarioInicial = Convert.ToDouble(reader["SalarioInicial"])
                        });
                    }
                }
            }
            return ret;
        }
    }
}
