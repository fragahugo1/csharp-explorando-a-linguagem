using System;

class Programa
{
    static void Main(string[] args)
    {
        double taxa = 1.005;
        double investimento = 1000;
        int mes, ano;

        for (ano = 1; ano <= 5; ano++)
        {
            for (mes = 1; mes <= 12; mes++)
            {
                investimento *= taxa;
            }
            
            taxa += 0.001;
        }

        Console.WriteLine("Valor final depois de 5 anos: " + investimento);
    }
}