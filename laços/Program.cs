﻿using System;

class Programa
{
    static void Main(string[] args)
    {
        double investimento = 1000;
        int mes = 1;

        while (mes < 13)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " : " + investimento);
            mes++;
        }
    }
}