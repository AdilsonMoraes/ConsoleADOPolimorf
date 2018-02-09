using System;

namespace FuncoesGenericas
{
    public class Funcoes
    {
        public static int SubtrairData(DateTime pData)
        {
            DateTime dt2 = DateTime.Now;
            return (dt2 - pData).Days;
        }

        public static int TempoDeCasaEmAnos(DateTime pData)
        {
            return (SubtrairData(pData) / 365);
        }

        //Dissídio anual
        //
        public static double CalculaDissidio(int pTempoDeCasaEmAnos, double pSalarioInicial)
        {
            for (int i = 1; i <= pTempoDeCasaEmAnos; i++)
            {
                pSalarioInicial = Math.Round(pSalarioInicial + (pSalarioInicial * 0.05), 2);
            }

            return pSalarioInicial;
        }

        //Bonus por tempo de casa
        //A cada 3 anos tem um bonus
        public static double CalculaBonus(int pTempoDeCasaEmAnos, double pSalarioInicial)
        {
            for (int i = 1; i <= (pTempoDeCasaEmAnos / 3); i++)
            {
                pSalarioInicial = Math.Round(pSalarioInicial + (pSalarioInicial * 0.07), 2);
            }
            return pSalarioInicial;
        }

        public static bool ValidaNumero(string pString)
        {
            double Num;
            //bool isNum = double.TryParse(pString, out Num);

            return double.TryParse(pString, out Num); ;



        }
    }
}
