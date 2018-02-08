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

//INSERT INTO PESSOA(NOME, RG, CPF, EMAIL, TELEFONE) VALUES('TESTE 123', '496520684', '35302570874','TESTE@GMAIL.COM', '115646-3325')
}
