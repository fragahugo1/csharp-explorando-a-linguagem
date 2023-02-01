using System;

class Programa
{
    static void Main(string[] args)
    {
        char vogal = 'H';

        switch (vogal)
        {
            case 'A':
                Console.WriteLine("Primeira vogal");
                break;

            case 'E':
                Console.WriteLine("Segunda vogal");
                break;

            case 'I':
                Console.WriteLine("Terceira vogal");
                break;

            case 'O':
                Console.WriteLine("Quarta vogal");
                break;

            case 'U':
                Console.WriteLine("Quinta vogal");
                break;

            default:
                Console.WriteLine("Não é vogal");
                break;
        }
    }
}