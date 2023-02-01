using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem-vindo");

        int idade = 16;
        int pessoas = 2;
        bool grupo = pessoas > 1;

        if (idade >= 18 || grupo)
        {
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine("Não pode entar");
        }
    }
}