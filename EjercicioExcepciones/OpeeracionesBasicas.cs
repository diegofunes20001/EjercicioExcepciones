using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    public class OpeeracionesBasicas
    {
        public double numero1 = 0;
        public double numero2 = 0;
        //Métodos para las operaciones básicas
        public double Sumar(double numero1, double numero2)
        {
             return numero1 + numero2;
        }
        public double Restar(double numero1, double numero2)
        {
            return numero1 - numero2;
        }
        public double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }
        public double Dividir(double numero1, double numero2)
        {
            if (numero2 == 0)
            {
                return numero1 / numero2;
            }
            else
            {
                throw new DivideByZeroException("No se pude dividir por cero");
            }
            
        }
    }
}
