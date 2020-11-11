using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor
{
    class conversor
    {
        // Declarar as variáveis
        public static double cotacao;
        public static double valor;
        public static double iof = 1.06;

        // Calcular valor em reais
        public static double Reais()
        {
            return cotacao * (valor * iof);
        }
    }
}
