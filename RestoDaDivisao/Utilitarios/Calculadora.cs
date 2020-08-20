using System;
using System.Collections.Generic;
using System.Text;

namespace RestoDaDivisao.Utilitarios
{
    public class Calculadora
    {
        public static int RestoDaDivisao(int dividendo, int divisor)
        {
            if(divisor == 0)
            {
                throw new ArgumentException("Excecao Interna: Divisor nao pode ser zero!");
            }
            return dividendo % divisor;
        }

        public static double CalculaInvestimento(double valor, double percentual)
        {
            return valor * (percentual / 100);
        }
    }
}
