using System;

class Programa
{
    static void Main(string[] args)
    {
        int numero;

        for (numero = 0; numero <= 100; numero += 3)
        {
            Console.WriteLine(numero);
        }
       
        /*
        for (numero = 0; numero < 101; numero++)
        {
            if (numero % 3 == 0)
            {
                Console.WriteLine(numero);
            }
        }
        */
    }
}