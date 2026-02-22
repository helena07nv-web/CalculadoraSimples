using System;

namespace CalculadoraSimples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primiero numéro: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo numéro: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");

            double soma = numero1 + numero2;
            double subtracao = numero1 - numero2;
            double multiplicacao = numero1 * numero2;
            double divisao = numero1 / numero2;

            Console.WriteLine($"Soma: {soma}"); 
            Console.WriteLine($"Subtração: {subtracao}");
            Console.WriteLine($"Multiplicação: {multiplicacao}");
            Console.WriteLine($"Divisão: {divisao}");





        }
    }
}
