using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 1320.80;

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine("IR é de 7.5% e pode deduzir R$ 142");
        }
        else if (salario > 2800.0 && salario <= 3751.0)
        {
            Console.WriteLine("IR é de 15% e pode deduzir R$ 350");
        }
        else if (salario > 3751.0 && salario <= 4664.0)
        {
            Console.WriteLine("IR é de 22.5% e pode deduzir R$ 636");
        }
        else
        {
            Console.WriteLine("Seu salário não se encaixa na alíquota");
        }
    }
}