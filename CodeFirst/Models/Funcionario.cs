using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
    public class Funcionario
    {
        public int FuncionarioID { get; set; }
        public string Cargo { get; set; }
        public string Nivel { get; set; }
        public int TempoDeCasaEmAnos { get; set; }
        public double SalarioInicial { get; set; }
        public int QtdeBonus { get; set; }
        public DateTime DataAdmissao { get; set; }
        public int PessoaID { get; set; }
    }
}