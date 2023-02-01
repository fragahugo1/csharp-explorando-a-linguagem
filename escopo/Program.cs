using System;

class Programa
{
    static void Main(string[] args)
    {
        int idade = 18;
        int pessoas = 1;
        bool grupo = pessoas > 1;
        string textoAcompanhado;

        if (grupo == true)
        {
            textoAcompanhado = "Está acompanhado";
        }
        else
        {
            textoAcompanhado = "Está sozinho";
        }

        if (idade >= 18 || grupo)
        {
            Console.WriteLine(textoAcompanhado);
            Console.WriteLine("Pode entrar");
        }
        else
        {
            Console.WriteLine(textoAcompanhado);
            Console.WriteLine("Não pode entar");
        }
    }
}