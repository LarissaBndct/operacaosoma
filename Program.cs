using System;
class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("----------SOMA DE INTEIROS---------");
        Console.WriteLine("Digite o primeiro numero da soma: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero da soma: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());
        int soma = numero1 + numero2;

        Console.WriteLine("O resultado da soma é: "+soma);
        Console.ReadKey();  
    }
}