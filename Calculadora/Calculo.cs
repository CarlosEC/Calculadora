using System;
using static Calculadora.FrmCalculadora;

namespace Calculadora
{
    static class Calculo
    {
        

        private static decimal Somar(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        private static decimal Subtrair(decimal num1, decimal num2)
        {
            return num1 - num2;
        }

        private static decimal Multiplicar(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        private static decimal Dividir(decimal num1, decimal num2)
        {
            return num1 / num2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="idOper">Operador</param>
        /// <returns></returns>
        public static string Resultado(decimal num1, decimal num2, Operador idOper)
        {
            Operador operador = (Operador)idOper;
            decimal valorResultado;
            string resultado = "";
            if ((num1 == 0) || num2 == 0)
            {
                Console.WriteLine("Nenhum dos números pode ser 0.");

            }
            switch (operador)
            {
                case Operador.Soma:
                    valorResultado = Somar(num1, num2);
                    resultado = $"{num1} + {num2} = {valorResultado.ToString("F")}";
                    break;
                case Operador.Subtrai:
                    valorResultado = Subtrair(num1, num2);
                    resultado = $"{num1} - {num2} = {valorResultado.ToString("F")}";
                    break;
                case Operador.Multiplica:
                    valorResultado = Multiplicar(num1, num2);
                    resultado = $"{num1} * {num2} = {valorResultado.ToString("F")}";
                    break;
                case Operador.Divide:
                    valorResultado = Dividir(num1, num2);
                    resultado = $"{num1} / {num2} = {valorResultado.ToString("F")}";
                    break;
                default:
                    break;
            }
            return resultado;
        }
    }
}
