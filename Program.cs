using System;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 3. Hacer una función llamada “primo” que reciba un número entero y devuelva 1 si el número es primo o cero si no lo es. 
           Hacer un programa para ingresar números. El lote corta cuando se ingresa un número cero. 
           Informar el promedio teniendo en cuenta sólo los números primos. */

            int n, cont = 0, contNumerosPrimos = 0;
            double prom;

            Console.WriteLine("Ingrese un valor:");
            n = int.Parse(Console.ReadLine());

            while(n != 0){
                if(primo(n)){
                cont+=n;
                contNumerosPrimos++;
                }

                Console.WriteLine("Ingrese un valor:");
                n = int.Parse(Console.ReadLine());
            }
            prom = cont / contNumerosPrimos;

            Console.WriteLine(prom);
        }

        static bool primo(int a){
            int cont = 0;

            for (int i = 1; i <=a ; i++)
            {
                if(a % i == 0)
                    cont++;
            }
            if(cont == 2)
                return true;
            else
                return false;
        }
    }
}
