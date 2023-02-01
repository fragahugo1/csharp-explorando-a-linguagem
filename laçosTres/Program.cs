using System;

class Programa
{
    static void Main(string[] args)
    {
        int linhas, colunas;

        for (linhas = 0; linhas < 10; linhas++)
        {
            for (colunas = 0; colunas < 10; colunas++)
            {
                Console.Write("*");
                if (linhas == colunas)
                    break;
            }
            
            Console.WriteLine();  
        }
    }
}