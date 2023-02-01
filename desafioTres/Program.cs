using System;

class Programa
{
    static void Main(string[] args)
    {
        int linha, numero;
 
        for (linha = 1; linha <= 10; linha++)
        {
            int resultado = 1;

            for (numero = 1; numero <= linha; numero++)
            {
                Console.Write(numero);
                
                if(numero < linha)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" = ");
                }
                resultado *= numero;
            }
  
            Console.Write(resultado);
            Console.WriteLine();
        }
    }
}

/*
using System;

class Programa
{
    static void Main(String args[])
    {
        int fatorial = 1;
        for (int i = 1; i < 11; i++)
        {
            fatorial *= i;
            Console.WriteLine("Fatorial de " + i + " = " + fatorial);
        }
    }
}
*/