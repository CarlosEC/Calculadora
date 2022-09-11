using System;

namespace Calculadora
{
    static class Calculo
    {
        public enum Operador
        {
            Soma = 1,
            Subtrai = 2,
            Multiplica = 3,
            Divide = 4
        }

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
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Nenhum dos números pode ser 0.");
                return 0;
            }
            return num1 / num2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <param name="idOper">Operador</param>
        /// <returns></returns>
        public static string Resultado(decimal num1, decimal num2, int idOper)
        {
            Operador operador = (Operador)idOper;
            decimal valorResultado;
            string resultado = "";
            if (num1 == 0 || num2 == 0)
            {
                Console.WriteLine("Nenhum dos números pode ser 0.");

            }
            switch (operador)
            {
                case Operador.Soma:
                    valorResultado = Somar(num1, num2);
                    resultado = $"{num1} + {num2} = {valorResultado}";
                    break;
                case Operador.Subtrai:
                    valorResultado = Subtrair(num1, num2);
                    resultado = $"{num1} - {num2} = {valorResultado}";
                    break;
                case Operador.Multiplica:
                    valorResultado = Multiplicar(num1, num2);
                    resultado = $"{num1} * {num2} = {valorResultado}";
                    break;
                case Operador.Divide:
                    valorResultado = Dividir(num1, num2);
                    resultado = $"{num1} / {num2} = {valorResultado}";
                    break;
                default:
                    break;
            }
            return resultado;
        }
    }
}
