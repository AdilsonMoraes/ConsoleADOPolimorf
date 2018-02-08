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

    //CREATE TABLE FUNCIONARIO(
        //FUNCIONARIOID NUMERIC(1,0) IDENTITY PRIMARY KEY NOT NULL,
        //CARGO VARCHAR(100) NOT NULL,
        //NIVEL VARCHAR(100) NOT NULL,
        //TEMPODECASAEMANOS NUMERIC(1,0) NOT NULL,
        //SALARIOINICIAL NUMERIC(9,2) NOT NULL,
        //QTDEBONUS NUMERIC(1,0) NOT NULL,
        //DATAADMISSAO DATETIME NOT NULL,
        //PESSOAID NUMERIC(1,0) REFERENCES PESSOA(PESSOAID)
    //);


//INSERT INTO FUNCIONARIO(CARGO, NIVEL, TEMPODECASAEMANOS, SALARIOINICIAL, QTDEBONUS, DATAADMISSAO, PESSOAID)
//VALUES('COORDENADOR', 'SENIOR', 4, 6.000, 0, GETDATE(), 1 )



}