using CadFuncionario;
using FuncoesGenericas;

namespace ConsoleApp1
{

    public class RetornaDados : Salario 
    {
        private enum CodNiv { Junior, Pleno, Senior };

        public override void RetornaNivel()
        {

            if (CodNivel == (int)CodNiv.Junior)
            {
                Nivel = "Junior";
            }

            if (CodNivel == (int)CodNiv.Pleno)
            {
                Nivel = "Pleno";
            }

            if (CodNivel == (int)CodNiv.Senior)
            {
                Nivel = "Senior";
            }

        }

        public override void CalcularSalario()
        {
            //Salario por nivel
            switch (Nivel)
            {
                case "Junior":
                    SalarioInicial = 1500;
                    break;

                case "Pleno":
                    SalarioInicial = 1500 * 2;
                    break;

                default:
                    SalarioInicial = 1500 * 4;
                    break;
            }
        }

        public override void CalcularDissidio()
        {
            TempoDeCasaEmAnos = Funcoes.TempoDeCasaEmAnos(DataAdmissao);

            if (TempoDeCasaEmAnos >= 1)
            {
                SalarioInicial = Funcoes.CalculaDissidio(TempoDeCasaEmAnos, SalarioInicial);
            }
        }

        public override void CalcularBonus()
        {
            TempoDeCasaEmAnos = Funcoes.TempoDeCasaEmAnos(DataAdmissao);
            QtdeBonus = TempoDeCasaEmAnos / 3;

            if ((TempoDeCasaEmAnos / 3) >= 1)
            {
                SalarioInicial = Funcoes.CalculaBonus(TempoDeCasaEmAnos, SalarioInicial);
            }
            else
            {
                QtdeBonus = 0;
            }
        }
    }
}
