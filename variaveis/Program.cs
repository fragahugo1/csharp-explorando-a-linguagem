using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Criação de variáveis");

        int idade;
        double salario;

        idade = 19;
        Console.WriteLine("Minha idade é: " + idade);

        idade = (5 + 5) * 2;
        Console.WriteLine("Minha idade ano que vem: " + idade);

        idade = idade + 1;
        Console.WriteLine("Minha idade em 2025: " + idade);

        salario = 1320.13;
        Console.WriteLine("Meu salário hoje: " + salario);
        Console.WriteLine("Salário inteiro: " + (int)salario);

        //outros tipos de variáveis:
        //long: 64 bits
        long x;
        x = 20000000000000000;

        //short: 16 bits
        short y;
        y = 15000;

        float altura = 1.74f;

        char letra = 'O'; char letraDois = (char)(105 + 3); char letraTres = 'á';
        Console.Write(letra); Console.Write(letraDois); Console.Write(letraTres);

        string nome = " Hugo";
        Console.WriteLine(nome);

        idade = 30;
        int idadeHugo = idade + 1;
        Console.WriteLine(idadeHugo);

        string aprendizadoAtual = @"Cursos: 
-C# 
-Unity 
-Visual Studio";
        Console.WriteLine(aprendizadoAtual);

        Console.WriteLine("Aperte enter para fechar");
        Console.ReadLine();
    }
}