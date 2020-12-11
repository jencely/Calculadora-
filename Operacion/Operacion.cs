using System;

namespace Operacion
{
    public class Matematica
    {
        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Restar(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public object Dividir(int numero1, int numero2)
        {
            if (numero2 != 0)
            {
                return numero1 / numero2;
            }
            else
            {
                return "No se puede dividir entre 0";
            }
        }
        public int Potencia(int numero1)
        {
            return numero1 * numero1;
        }

        public int Raiz(int numero1)
        {
           return (int)Math.Sqrt(numero1);
        }
    }
}