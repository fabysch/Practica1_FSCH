using System;

namespace Practica1_FSCH_Library
{
    public class Practica1FSCH
    {
        public static string Sum(int numero1, int numero2)
        {
             int resultado = numero1 + numero2;
            string valor = numero1 > numero2? "el primer numero "+numero1+" es mayor que el segundo numero "+numero2: "el segundo numero " + numero2 + " es mayor que el primer numero" + numero1+" Resultado de la suma "+resultado;
                         
                return valor;
        }
        public static string Substract(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            string valor = numero1 > numero2 ? "el primer numero " + numero1 + " es mayor que el segundo numero " + numero2 : "el segundo numero " + numero2 + " es mayor que el primer numero" + numero1+ " Resultado de la resta " + resultado;

            return valor;
        }
        public static string salidaprueba(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            string valor = numero1 > numero2 ? "el primer numero " + numero1 + " es mayor que el segundo numero " + numero2 : "el segundo numero " + numero2 + " es mayor que el primer numero" + numero1 + " Resultado de la suma " + resultado;

            return valor;
        }
    }
}
