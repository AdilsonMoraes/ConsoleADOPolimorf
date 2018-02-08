using CadPessoa;
using FuncoesGenericas;
using System;

namespace CadFuncionario
{
    public class Funcionario : Pessoa 
    {
        public int FuncionarioID { get; set; }
        public string Cargo { get; set; }
        public int CodNivel { get; set; }
        public string Nivel { get; set; }
        public int TempoDeCasaEmAnos { get; set; }
        public double SalarioInicial { get; set; }
        public int QtdeBonus { get; set; }
        public DateTime DataAdmissao { get; set; }
    }

    public abstract class Salario : Funcionario 
    {
        public abstract void CalcularSalario();
        public abstract void CalcularDissidio();
        public abstract void CalcularBonus();
        public abstract void RetornaNivel();
    }

//INSERT INTO FUNCIONARIO(CARGO, NIVEL, TEMPODECASAEMANOS, SALARIOINICIAL, QTDEBONUS, DATAADMISSAO, PESSOAID)
//VALUES('COORDENADOR', 'SENIOR', 4, 6.000, 0, GETDATE(), 1 )



}