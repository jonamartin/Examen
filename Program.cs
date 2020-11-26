//Realizado en aplicación de consola de C#

using System;
namespace Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero para determinar si es primo: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Calculo calculo = new Calculo();
            if(calculo.CalculoEsPrimo(numero))
            {
                Console.WriteLine("El numero {0} es primo. Presione una tecla para cerrar.", numero);
                Console.ReadKey();
                
            }
            else
            {
                Console.WriteLine("El numero {0} no es primo. Presione una tecla para cerrar.", numero);
                Console.ReadKey();
            }
        }
    }
    public class Calculo
    {
        public bool CalculoEsPrimo(int numero)
        {
            bool esPrimo = true;
            for(int i = 2; i <= numero ; i ++)
            {
                if((numero % i == 0)&&(numero != i))
                {
                    esPrimo = false;
                    break;
                }
            }
            return esPrimo;
        }
    }
}
