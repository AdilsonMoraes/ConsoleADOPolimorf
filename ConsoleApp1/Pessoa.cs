using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadPessoa
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }

    //create table Pessoa(
    //    PessoaID numeric(1,0) identity primary key not null,
    //    Nome varchar(100) not null,
    //    Rg varchar(9) not null,
    //    Cpf varchar(15) not null,
    //    Email varchar(100) not null,
    //    Telefone varchar(12) not null
    //);

    //INSERT INTO PESSOA(NOME, RG, CPF, EMAIL, TELEFONE) VALUES('TESTE 123', '496520684', '35302570874','TESTE@GMAIL.COM', '115646-3325')
}
