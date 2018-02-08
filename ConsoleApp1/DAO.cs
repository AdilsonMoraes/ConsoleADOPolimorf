using CadFuncionario;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Dao
{
    public class AcessObject //Acesso a dados
    {
        public static List<Funcionario> ConsultaFuncionario()
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
                               "DataAdmissao, QtdeBonus, TempoDeCasaEmAnos " +
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
                            QtdeBonus = Convert.ToInt32(reader["QtdeBonus"]),
                            TempoDeCasaEmAnos = Convert.ToInt32(reader["TempoDeCasaEmAnos"]),
                            DataAdmissao = Convert.ToDateTime(reader["DataAdmissao"]),
                            SalarioInicial = Convert.ToDouble(reader["SalarioInicial"])
                        });
                    }
                }
            }
            return ret;
        }

        public static bool ExcluirPeloId(int paramId)
        {
            var ret = false;

            if (paramId > 0 )
            {

                using (var conexao = new SqlConnection())
                {
                    conexao.ConnectionString = ConfigurationManager.ConnectionStrings["principal"].ConnectionString;
                    conexao.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = conexao;
                        comando.CommandText = "Delete from Funcionario where (FuncionarioId = @id)";
                        comando.Parameters.Add("@id", SqlDbType.Int).Value = paramId;

                        ret = (comando.ExecuteNonQuery() > 0); //ExecuteNonQuery quantidade de registro afetados pelo comando
                    }
                }
            }
            return ret;
        }

    }
}
